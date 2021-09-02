module Index

open Fable.Core.JsInterop

importAll "./style.scss"

open App

open Browser.Dom
open Feliz
ReactDOM.render(App.app (), document.getElementById "feliz-app")
