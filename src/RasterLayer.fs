namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type tileLayer =
    inherit BaseProps.GridLayer<ITileLayerProp>
    static member inline url (value: string) = Interop.mkTileLayerProp "url" value
    static member inline subdomains (value: string) = Interop.mkTileLayerProp "subdomains" value
    static member inline subdomains (value: ResizeArray<string>) = Interop.mkTileLayerProp "subdomains" value
    static member inline errorTileUrl (value: string) = Interop.mkTileLayerProp "errorTileUrl" value
    static member inline zoomOffset (value: float) = Interop.mkTileLayerProp "zoomOffset" value
    static member inline tms (value: bool) = Interop.mkTileLayerProp "tms" value
    static member inline zoomReverse (value: bool) = Interop.mkTileLayerProp "zoomReverse" value
    static member inline detectRetina (value: bool) = Interop.mkTileLayerProp "detectRetina" value
    static member inline crossOrigin (value: bool) = Interop.mkTileLayerProp "crossOrigin" value
    static member inline eventHandlers (value: gridLayerEvent list) = unbox<ITileLayerProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.TileLayerOptions>) = Interop.mkTileLayerProp "ref" value

[<Erase>]
type wmsTileLayer =
    inherit BaseProps.GridLayer<IWMSTileLayerProp>
    static member inline ``params`` (value: Leaflet.WMSParams) = Interop.mkWMSTileLayerProp "params" value
    static member inline url (value: string) = Interop.mkWMSTileLayerProp "url" value
    static member inline subdomains (value: string) = Interop.mkWMSTileLayerProp "subdomains" value
    static member inline subdomains (value: ResizeArray<string>) = Interop.mkWMSTileLayerProp "subdomains" value
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
    static member inline eventHandlers (value: gridLayerEvent list) = unbox<IWMSTileLayerProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.WMSOptions>) = Interop.mkWMSTileLayerProp "ref" value

[<Erase>]
type imageOverlay =
    inherit BaseProps.InteractiveLayer<IImageOverlayProp>
    static member inline bounds (value: LatLngBounds) = Interop.mkImageOverlayProp "bounds" value
    static member inline bounds (value: LatLngAltBounds) = Interop.mkImageOverlayProp "bounds" value
    static member inline opacity (value: float) = Interop.mkImageOverlayProp "opacity" value
    static member inline url (value: string) = Interop.mkImageOverlayProp "url" value
    static member inline alt (value: string) = Interop.mkImageOverlayProp "alt" value
    static member inline crossOrigin (value: bool) = Interop.mkImageOverlayProp "crossOrigin" value
    static member inline eventHandlers (value: imageOverlayEvent list) = unbox<IImageOverlayProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.ImageOverlay>) = Interop.mkImageOverlayProp "ref" value

[<Erase>]
type videoOverlay =
    inherit BaseProps.InteractiveLayer<IVideoOverlayProp>
    static member inline play (value: bool) = Interop.mkVideoOverlayProp "play" value
    static member inline zIndex (value: float) = Interop.mkVideoOverlayProp "zIndex" value
    static member inline bounds (value: LatLngBounds) = Interop.mkVideoOverlayProp "bounds" value
    static member inline bounds (value: LatLngAltBounds) = Interop.mkVideoOverlayProp "bounds" value
    static member inline opacity (value: float) = Interop.mkVideoOverlayProp "opacity" value
    static member inline url (value: string) = Interop.mkVideoOverlayProp "url" value
    static member inline url (value: string []) = Interop.mkVideoOverlayProp "url" value
    static member inline alt (value: string) = Interop.mkVideoOverlayProp "alt" value
    static member inline crossOrigin (value: bool) = Interop.mkVideoOverlayProp "crossOrigin" value
    static member inline autoplay (value: bool) = Interop.mkVideoOverlayProp "autoplay" value
    static member inline loop (value: bool) = Interop.mkVideoOverlayProp "loop" value
    static member inline keepAspectRatio (value: bool) = Interop.mkVideoOverlayProp "keepAspectRatio" value
    static member inline muted (value: bool) = Interop.mkVideoOverlayProp "muted" value
    static member inline eventHandlers (value: imageOverlayEvent list) = unbox<IVideoOverlayProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    // static member inline ref (value: IRefValue<Leaflet.VideoOverlay>) = Interop.mkVideoOverlayProp "ref" value
