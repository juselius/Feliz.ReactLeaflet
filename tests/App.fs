module App

open System
open Thoth.Fetch
open Feliz
open Feliz.Bulma
open Feliz.Router

type SubModel =
    | Home
    | LoginModel
    | AdminModel
    | AccountModel

type Model = {
    CurrentUrl  : string list
    UserSession : ApiDataTypes.UserSession option
    SubMdl      : SubModel
}

type Message =
    | Authenticate      of Result<bool, FetchError>
    | AdminValidate     of Result<bool, FetchError>
    | Exn               of Exception
    | Logout
    | UrlChanged        of string list

let locale = Locale.Locale

let init () =
    match LocalStorage.tryGetSession () with
    | Ok us ->
       {CurrentUrl = []; UserSession = Some us; SubMdl = Home}
    | _ ->
        {
            CurrentUrl = []
            UserSession = None
            SubMdl = LoginModel
        }

let private handleAuthenticate model res =
    match res with
    | Ok x when x -> model
    | _ ->
        LocalStorage.deleteSession ()
        {model with SubMdl = LoginModel}

let private handleAdminValidate model res =
    match model.UserSession with
    | Some us ->
        match res with
        | Ok x when x -> model
        | Ok x when not x ->
            let newSession = { us with IsAdmin = false }
            LocalStorage.storeSession newSession
            { model with UserSession = Some newSession }
        | Error x ->
            match x with
            | FetchFailed y when y.Status = 401 ->
                let newSession = { us with IsAdmin = false }
                LocalStorage.storeSession newSession
                { model with UserSession = Some newSession }
            | _ -> model
        | _ -> model
    | None -> model

let private handleLogout model =
    LocalStorage.deleteSession ()
    Router.navigate ""
    {model with
        UserSession = None
        SubMdl = LoginModel
    }

let private handleUrlChanged model path =
    match path with
    | ["passwordreset"; token ] -> model
    | _ -> model

let update (model : Model) (msg : Message) =
    match msg with
    | Authenticate res -> handleAuthenticate model res
    | AdminValidate res -> handleAdminValidate model res
    | Logout -> handleLogout model
    | UrlChanged path -> handleUrlChanged model path
    | Exn exn -> printfn "EXCEPTION: %A" exn; model

let private validateSession dispatch =
    promise {
        let! res =
            Promises.tryPost<string, bool>
                "/api/auth/validate" ""
        dispatch (Authenticate res)
    }

let private adminValidate dispatch =
    promise {
        let! res =
            Promises.tryPost<string, bool>
                "/api/auth/admin/validate" ""
        dispatch (AdminValidate res)
    }

let private navBar model dispatch =
    let navLogo =
            Bulma.navbarItem.div [
                prop.style [ style.cursor.pointer ]
                prop.onClick(fun _ -> Router.navigate "")
                prop.children [
                    //Html.img [ prop.src "/img/logo.png" ]
                    Html.span "Serit.Template"
                ]
            ]
    let navBurger updateActive active =
            Bulma.navbarBurger [
                prop.onClick(fun _ -> updateActive (not active))
                prop.children [
                    Html.span []
                    Html.span []
                    Html.span []
                ]
            ]
    let navMenu ddActive updateDD active =
        Bulma.navbarEnd.div [
            match model.UserSession with
            | None -> ()
            | Some us ->
                if us.IsAdmin then
                    Bulma.navbarItem.div [
                        prop.style [ style.cursor.pointer ]
                        prop.onClick(fun _ -> Router.navigate Urls.Admin)
                        prop.children [ Html.i [ prop.className "fas fa-cog" ] ]
                    ]
                Bulma.navbarItem.div [
                    Bulma.navbarItem.hasDropdown
                    Bulma.navbarItem.isHoverable
                    prop.style [ style.zIndex 10000 ]
                    if ddActive then Bulma.navbarItem.isActive
                    prop.onClick(fun _ -> updateDD (not ddActive))
                    prop.children [
                        Bulma.navbarLink.div [
                            Html.text us.Firstname
                        ]
                        Bulma.navbarDropdown.div [
                            Bulma.navbarItem.div [
                                prop.onClick(fun _ -> Router.navigate Urls.Account)
                                prop.style [ style.cursor.pointer]
                                prop.text locale.account.account
                            ]
                            Bulma.navbarDivider []
                            Bulma.navbarItem.div [
                                prop.onClick(fun _ -> dispatch Logout)
                                prop.style [ style.cursor.pointer]
                                prop.text locale.fields.logout
                            ]
                        ]
                    ]
                ]
        ]
    let plays = Option.defaultValue "none"
    React.functionComponent("NavBar", fun (props : {| isActive : bool; dropdownActive : bool |}) ->
        let active, updateActive = React.useState(props.isActive)
        let ddActive, updateDD = React.useState(props.dropdownActive)
        Bulma.navbar [
            color.isLight
            prop.children [
                Bulma.navbarBrand.div [
                    navLogo
                    navBurger updateActive active
                ]
                Bulma.navbarMenu [
                    Bulma.navbar.isFixedTop
                    if active then Bulma.navbarMenu.isActive
                    prop.children [
                        Bulma.navbarStart.div []
                        navMenu ddActive updateDD active
                    ]
                ]
            ]
        ]
    ) {| isActive = false; dropdownActive = false |}

let private homeView =
    Html.div [
        prop.style [
            style.display.flex
            style.width (length.vw 100)
            style.height (length.vh 100)
            style.justifyContent.center
            style.alignItems.center
        ]
        prop.children [
            Html.h3 [
                prop.className "title is-3"
                prop.text "Develop me"
            ]
        ]
    ]

let private notFoundView =
    Html.div [
        prop.style [
            style.display.flex
            style.width (length.vw 100)
            style.height (length.vh 100)
            style.justifyContent.center
            style.alignItems.center
        ]
        prop.children [
            Html.h3 [
                prop.className "title is-3"
                prop.text "404 - Page not found"
            ]
        ]
    ]

let app =
    Fable.React.FunctionComponent.Of (fun () ->
        let currentUrl, setUrl =
            React.useState (Router.currentUrl())

        let initialModel = init ()
        let model, dispatch = React.useReducer(update, initialModel)

        React.useEffect (fun _ ->
            if model.UserSession.IsSome then
                validateSession dispatch
                |> Promise.start

                adminValidate dispatch
                |> Promise.start
        , [||])

        Html.div [
            React.router [
                router.onUrlChanged (setUrl)
            ]
            if model.UserSession.IsNone then
                Login.login ()
            else
                navBar model dispatch
                match currentUrl with
                | [] -> homeView
                | [Urls.Account] -> Account.account ()
                | [Urls.Admin] -> Admin.admin ()
                | _ -> notFoundView
        ]
    )
