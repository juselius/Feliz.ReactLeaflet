module App

open System
open Thoth.Fetch
open Feliz
open Feliz.MaterialUI
open Feliz.Router

type Model = {
    CurrentUrl: string list
} with
    static member New () = {
        CurrentUrl = []
    }

type Message =
    | UrlChanged of string list

let init () = Model.New ()

let handleUrlChanged model path = model

let update (model: Model) (msg: Message) =
    match msg with
    | UrlChanged path -> handleUrlChanged model path

let navBar model dispatch = Html.div []

let indexView model dispatch = Html.h1 "Index"

[<ReactComponent>]
let App () =
    let currentUrl, setUrl = React.useState (Router.currentUrl())
    let initialModel = init ()
    let model, dispatch = React.useReducer(update, initialModel)

    Html.div [
        React.router [ router.onUrlChanged setUrl ]
        navBar model dispatch
        match currentUrl with
        | [] -> indexView model dispatch
        | _ -> Html.h2 "404 Not found."
    ]
