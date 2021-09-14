module Index

open Fable.Core.JsInterop

importAll "./style.scss"
importAll "../node_modules/leaflet/dist/leaflet.css"

open Browser.Dom
open Feliz

ReactDOM.render(App.App (), document.getElementById "feliz-app")
