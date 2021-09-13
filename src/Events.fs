namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop

module BaseEvents =
    [<Erase>]
    type LayerEvents =
       static member inline add (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layeradd" ==> handler ] |> unbox
       static member inline remove (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layerremove" ==> handler ] |> unbox
       static member inline popupopen (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupopen" ==> handler ] |> unbox
       static member inline popupclose (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupclose" ==> handler ] |> unbox
       static member inline tooltipopen (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipopen" ==> handler ] |> unbox
       static member inline tooltipclose (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipclose" ==> handler ] |> unbox

    [<Erase>]
    type InteractiveLayerEvents =
       inherit LayerEvents
       static member inline click (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "click" ==> handler ] |> unbox
       static member inline dblclick (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "dblclick" ==> handler ] |> unbox
       static member inline mousedown (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mousedown" ==> handler ] |> unbox
       static member inline mouseup (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mouseup" ==> handler ] |> unbox
       static member inline mouseover (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mouseover" ==> handler ] |> unbox
       static member inline mouseout (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mouseout" ==> handler ] |> unbox
       static member inline contextmenu (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "contextmenu" ==> handler ] |> unbox

    [<Erase>]
    type ImageOverlayEvents =
       static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ] |> unbox
       static member inline error (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "error" ==> handler ] |> unbox

[<Erase>]
type mapEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline layeradd (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layeradd" ==> handler ] |> unbox
    static member inline layerremove (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layerremove" ==> handler ] |> unbox
    static member inline baselayerchange (handler: (Leaflet.LayersControlEvent -> unit)) = createObj [ "baselayerchange" ==> handler ] |> unbox
    static member inline overlayeradd (handler: (Leaflet.LayersControlEvent -> unit)) = createObj [ "overlayeradd" ==> handler ] |> unbox
    static member inline overlayerremove (handler: (Leaflet.LayersControlEvent -> unit)) = createObj [ "overlayerremove" ==> handler ] |> unbox
    static member inline zoom (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoom" ==> handler ] |> unbox
    static member inline zoomstart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoomstart" ==> handler ] |> unbox
    static member inline zoomend (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoomend" ==> handler ] |> unbox
    static member inline zoomlevelschange (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoomlevelschange" ==> handler ] |> unbox
    static member inline resize (handler: (Leaflet.ResizeEvent -> unit)) = createObj [ "resize" ==> handler ] |> unbox
    static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ] |> unbox
    static member inline unload (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "unload" ==> handler ] |> unbox
    static member inline viewreset (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "viewreset" ==> handler ] |> unbox
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "move" ==> handler ] |> unbox
    static member inline movestart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "movestart" ==> handler ] |> unbox
    static member inline moveend (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "moveend" ==> handler ] |> unbox
    static member inline popupopen (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupopen" ==> handler ] |> unbox
    static member inline popupclose (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupclose" ==> handler ] |> unbox
    static member inline autopanstart (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "autopanstart" ==> handler ] |> unbox
    static member inline tooltipopen (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipopen" ==> handler ] |> unbox
    static member inline tooltipclose (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipclose" ==> handler ] |> unbox
    static member inline locationfound (handler: (Leaflet.LocationEvent -> unit)) = createObj [ "locationfound" ==> handler ] |> unbox
    static member inline locationerror (handler: (Leaflet.ErrorEvent -> unit)) = createObj [ "locationerror" ==> handler ] |> unbox
    static member inline mousemove (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mousemove" ==> handler ] |> unbox
    static member inline keypress (handler: (Leaflet.LeafletKeyboardEvent -> unit)) = createObj [ "keypress" ==> handler ] |> unbox
    static member inline keydown (handler: (Leaflet.LeafletKeyboardEvent -> unit)) = createObj [ "keydown" ==> handler ] |> unbox
    static member inline keyup (handler: (Leaflet.LeafletKeyboardEvent -> unit)) = createObj [ "keyup" ==> handler ] |> unbox
    static member inline preclick (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "preclick" ==> handler ] |> unbox

type markerEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "move" ==> handler ] |> unbox
    static member inline dragstart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "dragstart" ==> handler ] |> unbox
    static member inline movestart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "movestart" ==> handler ] |> unbox
    static member inline drag (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "drag" ==> handler ] |> unbox
    static member inline dragend (handler: (Leaflet.DragEndEvent -> unit)) = createObj [ "dragend" ==> handler ] |> unbox
    static member inline moveend (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "moveend" ==> handler ] |> unbox

[<Erase>]
type layerEvent = BaseEvents.LayerEvents

[<Erase>]
type gridLayerEvent =
   inherit BaseEvents.LayerEvents
   static member inline loading (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "loading" ==> handler ] |> unbox
   static member inline tileloadstart (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileloadstart" ==> handler ] |> unbox
   static member inline tileload (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileload" ==> handler ] |> unbox
   static member inline tileunload (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileunload" ==> handler ] |> unbox
   static member inline tileerror (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileerror" ==> handler ] |> unbox
   static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ] |> unbox

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
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "move" ==> handler ] |> unbox

[<Erase>]
type geoJSONEvent =
    inherit BaseEvents.LayerEvents
    static member inline layeradd (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layeradd" ==> handler ] |> unbox
    static member inline layerremove (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layerremove" ==> handler ] |> unbox

[<Erase>]
type imageOverlayEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ] |> unbox
    static member inline error (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "error" ==> handler ] |> unbox
