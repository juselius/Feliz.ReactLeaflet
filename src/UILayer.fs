namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type marker =
    inherit BaseProps.InteractiveLayer<IMarkerProp>
    static member inline draggable (value: bool) = Interop.mkMarkerProp "draggable" value
    static member inline icon (value: U2<Leaflet.Icon<obj>, Leaflet.DivIcon>) = Interop.mkMarkerProp "icon" value
    static member inline opacity (value: float) = Interop.mkMarkerProp "opacity" value
    static member inline position (value: Leaflet.LatLngExpression) = Interop.mkMarkerProp "position" value
    static member inline zIndexOffset (value: float) = Interop.mkMarkerProp "zIndexOffset" value
    static member inline clickable (value: bool) = Interop.mkMarkerProp "clickable" value
    static member inline keyboard (value: bool) = Interop.mkMarkerProp "keyboard" value
    static member inline title (value: string) = Interop.mkMarkerProp "title" value
    static member inline alt (value: string) = Interop.mkMarkerProp "alt" value
    static member inline riseOnHover (value: bool) = Interop.mkMarkerProp "riseOnHover" value
    static member inline riseOffset (value: float) = Interop.mkMarkerProp "riseOffset" value
    static member inline shadowPane (value: string) = Interop.mkMarkerProp "shadowPane" value
    static member inline eventHandlers (value: markerEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Marker<_>>) = Interop.mkMarkerProp "ref" value

[<Erase>]
type popup =
    inherit BaseProps.Layer<IPopupProp>
    static member inline onClose (value: unit -> unit) = Interop.mkPopupProp "onClose" value
    static member inline onOpen (value: unit -> unit) = Interop.mkPopupProp "onOpen" value
    static member inline position (value: Leaflet.LatLngExpression) = Interop.mkPopupProp "position" value
    static member inline offset (value: Leaflet.PointExpression) = Interop.mkPopupProp "offset" value
    static member inline zoomAnimation (value: bool) = Interop.mkPopupProp "zoomAnimation" value
    static member inline maxWidth (value: float) = Interop.mkPopupProp "maxWidth" value
    static member inline minWidth (value: float) = Interop.mkPopupProp "minWidth" value
    static member inline maxHeight (value: float) = Interop.mkPopupProp "maxHeight" value
    static member inline autoPan (value: bool) = Interop.mkPopupProp "autoPan" value
    static member inline autoPanPaddingTopLeft (value: Leaflet.PointExpression) = Interop.mkPopupProp "autoPanPaddingTopLeft" value
    static member inline autoPanPaddingBottomRight (value: Leaflet.PointExpression) = Interop.mkPopupProp "autoPanPaddingBottomRight" value
    static member inline autoPanPadding (value: Leaflet.PointExpression) = Interop.mkPopupProp "autoPanPadding" value
    static member inline keepInView (value: bool) = Interop.mkPopupProp "keepInView" value
    static member inline closeButton (value: bool) = Interop.mkPopupProp "closeButton" value
    static member inline autoClose (value: bool) = Interop.mkPopupProp "autoClose" value
    static member inline closeOnClick (value: bool) = Interop.mkPopupProp "closeOnClick" value
    static member inline closeOnEscapeKey (value: bool) = Interop.mkPopupProp "closeOnEscapeKey" value
    static member inline eventHandlers (value: layerEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Popup>) = Interop.mkPopupProp "ref" value


[<Erase>]
type tooltip =
    inherit BaseProps.Layer<ITooltipProp>
    static member inline onClose (value: unit -> unit) = Interop.mkTooltipProp "onClose" value
    static member inline onOpen (value: unit -> unit) = Interop.mkTooltipProp "onOpen" value
    static member inline position (value: Leaflet.LatLngExpression) = Interop.mkTooltipProp "position" value
    static member inline offset (value: Leaflet.PointExpression) = Interop.mkTooltipProp "offset" value
    static member inline direction (value: Direction) = Interop.mkTooltipProp "direction" value
    static member inline permanent (value: bool) = Interop.mkTooltipProp "permanent" value
    static member inline sticky (value: bool) = Interop.mkTooltipProp "sticky" value
    static member inline interactive (value: bool) = Interop.mkTooltipProp "interactive" value
    static member inline opacity (value: float) = Interop.mkTooltipProp "opacity" value
    static member inline eventHandlers (value: layerEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Tooltip>) = Interop.mkTooltipProp "ref" value
