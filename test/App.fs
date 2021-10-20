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

[<ReactComponent>]
let leafletMap () =
    let map = ReactLeaflet.useMap ()
    let z = map.getZoom ()
    Fable.Core.JS.console.log ("zoom: " + string z)
    Html.div []

let tromso = 69.67, 18.95
let lyngen = [| (69.15, 19.65); (69.99, 20.5) |]

let indexView model dispatch =
    Html.div [
        Html.h1 "Feliz.ReactLeaflet"
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
                    circle.eventHandlers [
                        circleEvent.click (fun _ -> Fable.Core.JS.console.log "circle clicked")
                    ]
                    circle.center tromso
                    circle.radius 6000.0
                ]
                ReactLeaflet.rectangle [
                    rectangle.pathOptions [
                        pathOptions.color "green"
                        pathOptions.fillColor "green"
                        pathOptions.opacity 0.2
                        pathOptions.weight 4.0
                    ]
                    rectangle.eventHandlers [
                        rectangleEvent.click (fun _ -> Fable.Core.JS.console.log "rectangle clicked")
                    ]
                    rectangle.bounds lyngen
                ]
                leafletMap ()
            ]
        ]
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
