namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop

module BaseEvents =
    [<Erase>]
    type LayerEvents =
       static member inline add (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layeradd" ==> handler ]
       static member inline remove (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layerremove" ==> handler ]
       static member inline popupopen (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupopen" ==> handler ]
       static member inline popupclose (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupclose" ==> handler ]
       static member inline tooltipopen (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipopen" ==> handler ]
       static member inline tooltipclose (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipclose" ==> handler ]

    [<Erase>]
    type InteractiveLayerEvents =
       inherit LayerEvents
       static member inline click (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "click" ==> handler ]
       static member inline dblclick (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "dblclick" ==> handler ]
       static member inline mousedown (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mousedown" ==> handler ]
       static member inline mouseup (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mouseup" ==> handler ]
       static member inline mouseover (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mouseover" ==> handler ]
       static member inline mouseout (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mouseout" ==> handler ]
       static member inline contextmenu (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "contextmenu" ==> handler ]

    [<Erase>]
    type ImageOverlayEvents =
       static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ]
       static member inline error (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "error" ==> handler ]

[<Erase>]
type MapEvents =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline layeradd (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layeradd" ==> handler ]
    static member inline layerremove (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layerremove" ==> handler ]
    static member inline baselayerchange (handler: (Leaflet.LayersControlEvent -> unit)) = createObj [ "baselayerchange" ==> handler ]
    static member inline overlayeradd (handler: (Leaflet.LayersControlEvent -> unit)) = createObj [ "overlayeradd" ==> handler ]
    static member inline overlayerremove (handler: (Leaflet.LayersControlEvent -> unit)) = createObj [ "overlayerremove" ==> handler ]
    static member inline zoom (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoom" ==> handler ]
    static member inline zoomstart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoomstart" ==> handler ]
    static member inline zoomend (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoomend" ==> handler ]
    static member inline zoomlevelschange (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "zoomlevelschange" ==> handler ]
    static member inline resize (handler: (Leaflet.ResizeEvent -> unit)) = createObj [ "resize" ==> handler ]
    static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ]
    static member inline unload (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "unload" ==> handler ]
    static member inline viewreset (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "viewreset" ==> handler ]
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "move" ==> handler ]
    static member inline movestart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "movestart" ==> handler ]
    static member inline moveend (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "moveend" ==> handler ]
    static member inline popupopen (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupopen" ==> handler ]
    static member inline popupclose (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "popupclose" ==> handler ]
    static member inline autopanstart (handler: (Leaflet.PopupEvent -> unit)) = createObj [ "autopanstart" ==> handler ]
    static member inline tooltipopen (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipopen" ==> handler ]
    static member inline tooltipclose (handler: (Leaflet.TooltipEvent -> unit)) = createObj [ "tooltipclose" ==> handler ]
    static member inline locationfound (handler: (Leaflet.LocationEvent -> unit)) = createObj [ "locationfound" ==> handler ]
    static member inline locationerror (handler: (Leaflet.ErrorEvent -> unit)) = createObj [ "locationerror" ==> handler ]
    static member inline mousemove (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "mousemove" ==> handler ]
    static member inline keypress (handler: (Leaflet.LeafletKeyboardEvent -> unit)) = createObj [ "keypress" ==> handler ]
    static member inline keydown (handler: (Leaflet.LeafletKeyboardEvent -> unit)) = createObj [ "keydown" ==> handler ]
    static member inline keyup (handler: (Leaflet.LeafletKeyboardEvent -> unit)) = createObj [ "keyup" ==> handler ]
    static member inline preclick (handler: (Leaflet.LeafletMouseEvent -> unit)) = createObj [ "preclick" ==> handler ]

[<Erase>]
type Misc =
    static member inline focus (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "focus" ==> handler ]
    static member inline blur (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "blur" ==> handler ]
    static member inline autopasstart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "autopasstart" ==> handler ]
    static member inline eachfeature (handler: obj -> unit) = createObj [ "eachfeature" ==> handler ]
    static member inline close (handler: unit -> unit) = createObj [ "close" ==> handler ]
    static member inline ``open`` (handler: unit -> unit) = createObj [ "open" ==> handler ]
    static member inline add (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "add" ==> handler ]
    static member inline remove (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "remove" ==> handler ]

type MarkerEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "move" ==> handler ]
    static member inline dragstart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "dragstart" ==> handler ]
    static member inline movestart (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "movestart" ==> handler ]
    static member inline drag (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "drag" ==> handler ]
    static member inline dragend (handler: (Leaflet.DragEndEvent -> unit)) = createObj [ "dragend" ==> handler ]
    static member inline moveend (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "moveend" ==> handler ]


[<Erase>]
type LayerEvent = BaseEvents.LayerEvents

[<Erase>]
type GridLayerEvent =
   inherit BaseEvents.LayerEvents
   static member inline loading (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "loading" ==> handler ]
   static member inline tileloadstart (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileloadstart" ==> handler ]
   static member inline tileload (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileload" ==> handler ]
   static member inline tileunload (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileunload" ==> handler ]
   static member inline tileerror (handler: (Leaflet.TileEvent -> unit)) = createObj [ "tileerror" ==> handler ]
   static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ]

[<Erase>]
type PathEvent = BaseEvents.InteractiveLayerEvents

[<Erase>]
type CircleMarkerEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline move (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "move" ==> handler ]

[<Erase>]
type GeoJSONEvent =
    inherit BaseEvents.LayerEvents
    static member inline layeradd (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layeradd" ==> handler ]
    static member inline layerremove (handler: (Leaflet.LayerEvent -> unit)) = createObj [ "layerremove" ==> handler ]

[<Erase>]
type ImageOverlayEvent =
    inherit BaseEvents.InteractiveLayerEvents
    static member inline load (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "load" ==> handler ]
    static member inline error (handler: (Leaflet.LeafletEvent -> unit)) = createObj [ "error" ==> handler ]

// type PopupEvent = BaseEvents.LayerEvents
// type TooltipEvent = BaseEvents.LayerEvents
// type WMSTileLayerEvent = BaseEvents.GridLayerEvents
// type TileLayerEvent = BaseEvents.GridLayerEvents
