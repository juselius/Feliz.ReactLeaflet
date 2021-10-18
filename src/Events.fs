namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop

module BaseEvents =
    [<Erase>]
    type LayerEvents =
       static member inline add (handler: (Leaflet.LayerEvent -> unit)) =  "layeradd" ==> handler |> unbox
       static member inline remove (handler: (Leaflet.LayerEvent -> unit)) =  "layerremove" ==> handler |> unbox
       static member inline popupopen (handler: (Leaflet.PopupEvent -> unit)) =  "popupopen" ==> handler |> unbox
       static member inline popupclose (handler: (Leaflet.PopupEvent -> unit)) =  "popupclose" ==> handler |> unbox
       static member inline tooltipopen (handler: (Leaflet.TooltipEvent -> unit)) =  "tooltipopen" ==> handler |> unbox
       static member inline tooltipclose (handler: (Leaflet.TooltipEvent -> unit)) =  "tooltipclose" ==> handler |> unbox

    [<Erase>]
    type InteractiveLayerEvents =
       inherit LayerEvents
       static member inline click (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "click" ==> handler |> unbox
       static member inline dblclick (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "dblclick" ==> handler |> unbox
       static member inline mousedown (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "mousedown" ==> handler |> unbox
       static member inline mouseup (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "mouseup" ==> handler |> unbox
       static member inline mouseover (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "mouseover" ==> handler |> unbox
       static member inline mouseout (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "mouseout" ==> handler |> unbox
       static member inline contextmenu (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "contextmenu" ==> handler |> unbox

    [<Erase>]
    type ImageOverlayEvents =
       static member inline load (handler: (Leaflet.LeafletEvent -> unit)) =  "load" ==> handler |> unbox
       static member inline error (handler: (Leaflet.LeafletEvent -> unit)) =  "error" ==> handler |> unbox

[<Erase>]
type mapEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline layeradd (handler: (Leaflet.LayerEvent -> unit)) =  "layeradd" ==> handler |> unbox
    static member inline layerremove (handler: (Leaflet.LayerEvent -> unit)) =  "layerremove" ==> handler |> unbox
    static member inline baselayerchange (handler: (Leaflet.LayersControlEvent -> unit)) =  "baselayerchange" ==> handler |> unbox
    static member inline overlayeradd (handler: (Leaflet.LayersControlEvent -> unit)) =  "overlayeradd" ==> handler |> unbox
    static member inline overlayerremove (handler: (Leaflet.LayersControlEvent -> unit)) =  "overlayerremove" ==> handler |> unbox
    static member inline zoom (handler: (Leaflet.LeafletEvent -> unit)) =  "zoom" ==> handler |> unbox
    static member inline zoomstart (handler: (Leaflet.LeafletEvent -> unit)) =  "zoomstart" ==> handler |> unbox
    static member inline zoomend (handler: (Leaflet.LeafletEvent -> unit)) =  "zoomend" ==> handler |> unbox
    static member inline zoomlevelschange (handler: (Leaflet.LeafletEvent -> unit)) =  "zoomlevelschange" ==> handler |> unbox
    static member inline resize (handler: (Leaflet.ResizeEvent -> unit)) =  "resize" ==> handler |> unbox
    static member inline load (handler: (Leaflet.LeafletEvent -> unit)) =  "load" ==> handler |> unbox
    static member inline unload (handler: (Leaflet.LeafletEvent -> unit)) =  "unload" ==> handler |> unbox
    static member inline viewreset (handler: (Leaflet.LeafletEvent -> unit)) =  "viewreset" ==> handler |> unbox
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) =  "move" ==> handler |> unbox
    static member inline movestart (handler: (Leaflet.LeafletEvent -> unit)) =  "movestart" ==> handler |> unbox
    static member inline moveend (handler: (Leaflet.LeafletEvent -> unit)) =  "moveend" ==> handler |> unbox
    static member inline popupopen (handler: (Leaflet.PopupEvent -> unit)) =  "popupopen" ==> handler |> unbox
    static member inline popupclose (handler: (Leaflet.PopupEvent -> unit)) =  "popupclose" ==> handler |> unbox
    static member inline autopanstart (handler: (Leaflet.PopupEvent -> unit)) =  "autopanstart" ==> handler |> unbox
    static member inline tooltipopen (handler: (Leaflet.TooltipEvent -> unit)) =  "tooltipopen" ==> handler |> unbox
    static member inline tooltipclose (handler: (Leaflet.TooltipEvent -> unit)) =  "tooltipclose" ==> handler |> unbox
    static member inline locationfound (handler: (Leaflet.LocationEvent -> unit)) =  "locationfound" ==> handler |> unbox
    static member inline locationerror (handler: (Leaflet.ErrorEvent -> unit)) =  "locationerror" ==> handler |> unbox
    static member inline mousemove (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "mousemove" ==> handler |> unbox
    static member inline keypress (handler: (Leaflet.LeafletKeyboardEvent -> unit)) =  "keypress" ==> handler |> unbox
    static member inline keydown (handler: (Leaflet.LeafletKeyboardEvent -> unit)) =  "keydown" ==> handler |> unbox
    static member inline keyup (handler: (Leaflet.LeafletKeyboardEvent -> unit)) =  "keyup" ==> handler |> unbox
    static member inline preclick (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "preclick" ==> handler |> unbox

type markerEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) =  "move" ==> handler |> unbox
    static member inline dragstart (handler: (Leaflet.LeafletEvent -> unit)) =  "dragstart" ==> handler |> unbox
    static member inline movestart (handler: (Leaflet.LeafletEvent -> unit)) =  "movestart" ==> handler |> unbox
    static member inline drag (handler: (Leaflet.LeafletEvent -> unit)) =  "drag" ==> handler |> unbox
    static member inline dragend (handler: (Leaflet.DragEndEvent -> unit)) =  "dragend" ==> handler |> unbox
    static member inline moveend (handler: (Leaflet.LeafletEvent -> unit)) =  "moveend" ==> handler |> unbox

[<Erase>]
type layerEvent = BaseEvents.LayerEvents

[<Erase>]
type gridLayerEvent =
   inherit BaseEvents.LayerEvents
   static member inline loading (handler: (Leaflet.LeafletEvent -> unit)) =  "loading" ==> handler |> unbox
   static member inline tileloadstart (handler: (Leaflet.TileEvent -> unit)) =  "tileloadstart" ==> handler |> unbox
   static member inline tileload (handler: (Leaflet.TileEvent -> unit)) =  "tileload" ==> handler |> unbox
   static member inline tileunload (handler: (Leaflet.TileEvent -> unit)) =  "tileunload" ==> handler |> unbox
   static member inline tileerror (handler: (Leaflet.TileEvent -> unit)) =  "tileerror" ==> handler |> unbox
   static member inline load (handler: (Leaflet.LeafletEvent -> unit)) =  "load" ==> handler |> unbox
   static member inline click (handler: (Leaflet.LeafletMouseEvent -> unit)) =  "click" ==> handler |> unbox

[<Erase>]
type circleEvent = BaseEvents.InteractiveLayerEvents

[<Erase>]
type polygonEvent = BaseEvents.InteractiveLayerEvents

[<Erase>]
type rectangleEvent = BaseEvents.InteractiveLayerEvents

[<Erase>]
type polylineEvent = BaseEvents.InteractiveLayerEvents

[<Erase>]
type circleMarkerEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) =  "move" ==> handler |> unbox

[<Erase>]
type geoJSONEvent =
    inherit BaseEvents.LayerEvents
    static member inline layeradd (handler: (Leaflet.LayerEvent -> unit)) =  "layeradd" ==> handler |> unbox
    static member inline layerremove (handler: (Leaflet.LayerEvent -> unit)) =  "layerremove" ==> handler |> unbox

[<Erase>]
type imageOverlayEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline load (handler: (Leaflet.LeafletEvent -> unit)) =  "load" ==> handler |> unbox
    static member inline error (handler: (Leaflet.LeafletEvent -> unit)) =  "error" ==> handler |> unbox
