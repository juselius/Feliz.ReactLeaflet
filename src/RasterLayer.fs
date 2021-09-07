namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type tileLayer =
    inherit Base.GridLayer<ITileLayerProp>
    static member inline url (value: string) = Interop.mkTileLayerProp "url" value
    static member inline subdomains (value: U2<string, ResizeArray<string>>) = Interop.mkTileLayerProp "subdomains" value
    static member inline errorTileUrl (value: string) = Interop.mkTileLayerProp "errorTileUrl" value
    static member inline zoomOffset (value: float) = Interop.mkTileLayerProp "zoomOffset" value
    static member inline tms (value: bool) = Interop.mkTileLayerProp "tms" value
    static member inline zoomReverse (value: bool) = Interop.mkTileLayerProp "zoomReverse" value
    static member inline detectRetina (value: bool) = Interop.mkTileLayerProp "detectRetina" value
    static member inline crossOrigin (value: bool) = Interop.mkTileLayerProp "crossOrigin" value
    static member inline onLoading (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkTileLayerProp "onLoading" value
    static member inline onLoad (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkTileLayerProp "onLoad" value
    static member inline onTileLoadstart (value: (Leaflet.TileEvent -> unit)) = Interop.mkTileLayerProp "onTileLoadstart" value
    static member inline onTileLoad (value: (Leaflet.TileEvent -> unit)) = Interop.mkTileLayerProp "onTileLoad" value
    static member inline onTileUnload (value: (Leaflet.TileEvent -> unit)) = Interop.mkTileLayerProp "onTileUnload" value
    static member inline onTileError (value: (Leaflet.TileEvent -> unit)) = Interop.mkTileLayerProp "onTileError" value


[<Erase>]
type wmsTileLayer =
    inherit Base.GridLayer<IWMSTileLayerProp>
    static member inline ``params`` (value: Leaflet.WMSParams) = Interop.mkWMSTileLayerProp "params" value
    static member inline url (value: string) = Interop.mkWMSTileLayerProp "url" value
    static member inline subdomains (value: U2<string, ResizeArray<string>>) = Interop.mkWMSTileLayerProp "subdomains" value
    static member inline errorTileUrl (value: string) = Interop.mkWMSTileLayerProp "errorTileUrl" value
    static member inline zoomOffset (value: float) = Interop.mkWMSTileLayerProp "zoomOffset" value
    static member inline tms (value: bool) = Interop.mkWMSTileLayerProp "tms" value
    static member inline zoomReverse (value: bool) = Interop.mkWMSTileLayerProp "zoomReverse" value
    static member inline detectRetina (value: bool) = Interop.mkWMSTileLayerProp "detectRetina" value
    static member inline crossOrigin (value: bool) = Interop.mkWMSTileLayerProp "crossOrigin" value
    static member inline layers (value: string) = Interop.mkWMSTileLayerProp "layers" value
    static member inline styles (value: string) = Interop.mkWMSTileLayerProp "styles" value
    static member inline format (value: string) = Interop.mkWMSTileLayerProp "format" value
    static member inline transparent (value: bool) = Interop.mkWMSTileLayerProp "transparent" value
    static member inline version (value: string) = Interop.mkWMSTileLayerProp "version" value
    static member inline crs (value: Leaflet.CRS) = Interop.mkWMSTileLayerProp "crs" value
    static member inline uppercase (value: bool) = Interop.mkWMSTileLayerProp "uppercase" value
    static member inline onLoading (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkWMSTileLayerProp "onLoading" value
    static member inline onLoad (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkWMSTileLayerProp "onLoad" value
    static member inline onTileLoadstart (value: (Leaflet.TileEvent -> unit)) = Interop.mkWMSTileLayerProp "onTileLoadstart" value
    static member inline onTileLoad (value: (Leaflet.TileEvent -> unit)) = Interop.mkWMSTileLayerProp "onTileLoad" value
    static member inline onTileUnload (value: (Leaflet.TileEvent -> unit)) = Interop.mkWMSTileLayerProp "onTileUnload" value
    static member inline onTileError (value: (Leaflet.TileEvent -> unit)) = Interop.mkWMSTileLayerProp "onTileError" value

[<Erase>]
type imageOverlay =
    inherit Base.InteractiveLayer<IImageOverlayProp>
    static member inline bounds (value: Leaflet.LatLngBounds) = Interop.mkImageOverlayProp "bounds" value
    static member inline opacity (value: float) = Interop.mkImageOverlayProp "opacity" value
    static member inline url (value: string) = Interop.mkImageOverlayProp "url" value
    static member inline alt (value: string) = Interop.mkImageOverlayProp "alt" value
    static member inline crossOrigin (value: bool) = Interop.mkImageOverlayProp "crossOrigin" value

// [<Erase>]
// type videoOverlay =
//     static member inline attribution (value: string) = Interop.mkVideoOverlayProp "attribution" value
//     static member inline bounds (value: Leaflet.LatLngBounds) = Interop.mkVideoOverlayProp "bounds" value
//     static member inline eventHandlers (value: Leaflet.LeafletEventHandlerFnMap) = Interop.mkVideoOverlayProp "eventHandlers" value
//     static member inline play (value: bool) = Interop.mkVideoOverlayProp "play" value
//     static member inline ref (value: IRefValue<Leaflet.VideoOverlay>) = Interop.mkVideoOverlayProp "ref" value
//     static member inline url (value: string) = Interop.mkVideoOverlayProp "url" value
//     static member inline url (value: string []) = Interop.mkVideoOverlayProp "url" value
//     static member inline url (value: HTMLVideoElement) = Interop.mkVideoOverlayProp "url" value
//     static member inline zIndex (value: float) = Interop.mkVideoOverlayProp "zIndex" value
