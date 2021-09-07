module App

open System
open Thoth.Fetch
open Feliz
open Feliz.MaterialUI
open Feliz.Router
open Feliz.ReactLeaflet

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

let navBar model dispatch =
    Html.div []

let theMap () =
    let map = ReactLeaflet.useMap ()
    map

let tromso = Fable.Core.U3.Case3 (69.67, 18.95)

let indexView model dispatch =
    Html.div [
        Html.h1 "Feliz.RactLeaflet"
        Html.hr []
        ReactLeaflet.mapContainer [
            mapContainer.id "foo"
            mapContainer.style [ style.height 800 ]
            mapContainer.whenCreated (fun x -> Fable.Core.JS.console.log "hello world")
            mapContainer.center tromso
            mapContainer.zoom 8.0
            mapContainer.children [
                ReactLeaflet.tileLayer [
                    tileLayer.attribution "jonas"
                    tileLayer.url "https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
                ]
                ReactLeaflet.circle [
                    circle.pathOptions [
                        pathOptions.color "red"
                        pathOptions.fillColor "gray"
                        pathOptions.opacity 0.5
                        pathOptions.weight 2.0
                    ]
                    circle.center tromso
                    circle.radius 6000.0
                ]
            //     // ReactLeaflet.rectangle [
            //         // rectangle.foobar "foo"
            //     // ]
            ]
        ]
        // theMap
    ]

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
