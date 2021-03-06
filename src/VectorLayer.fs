namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type circle =
    inherit BaseProps.Path<ICircleProp>
    static member inline center (value: LatLng) = Interop.mkCircleProp "center" value
    static member inline center (value: LatLngAlt) = Interop.mkCircleProp "center" value
    static member inline radius (value: float) = Interop.mkCircleProp "radius" value
    static member inline eventHandlers (value: circleEvent list) = unbox<ICircleProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Circle<_>>) = Interop.mkCircleProp "ref" value

[<Erase>]
type circleMarker =
    inherit BaseProps.Path<ICircleMarkerProp>
    static member inline center (value: LatLng) = Interop.mkCircleMarkerProp "center" value
    static member inline center (value: LatLngAlt) = Interop.mkCircleMarkerProp "center" value
    static member inline radius (value: float) = Interop.mkCircleMarkerProp "radius" value
    static member inline eventHandlers (value: circleMarkerEvent list) = unbox<ICircleMarkerProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.CircleMarker<_>>) = Interop.mkCircleMarkerProp "ref" value

[<Erase>]
type polyline =
    inherit BaseProps.Path<IPolylineProp>
    static member inline positions (value: LatLng []) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: LatLng [][]) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: LatLng [][][]) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: LatLngAlt []) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: LatLngAlt [][]) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: LatLngAlt [][][]) = Interop.mkPolylineProp "positions" value
    static member inline smoothFactor (value: float) = Interop.mkPolylineProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkPolylineProp "noClip" value
    static member inline eventHandlers (value: polylineEvent list) = unbox<IPolylineProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Polyline<_, _>>) = Interop.mkPolylineProp "ref" value

[<Erase>]
type polygon =
    inherit BaseProps.Path<IPolygonProp>
    static member inline positions (value: LatLng []) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: LatLng [][]) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: LatLng [][][]) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: LatLngAlt []) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: LatLngAlt [][]) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: LatLngAlt [][][]) = Interop.mkPolygonProp "positions" value
    static member inline smoothFactor (value: float) = Interop.mkPolygonProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkPolygonProp "noClip" value
    static member inline eventHandlers (value: polygonEvent list) = unbox<IPolygonProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Polygon<_>>) = Interop.mkPolygonProp "ref" value

[<Erase>]
type rectangle =
    inherit BaseProps.Path<IRectangleProp>
    static member inline bounds (value: LatLngBounds) = Interop.mkRectangleProp "bounds" value
    static member inline bounds (value: LatLngAltBounds) = Interop.mkRectangleProp "bounds" value
    static member inline popupContainer (value: Leaflet.FeatureGroup<obj>) = Interop.mkRectangleProp "popupContainer" value
    static member inline smoothFactor (value: float) = Interop.mkRectangleProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkRectangleProp "noClip" value
    static member inline eventHandlers (value: rectangleEvent list) = unbox<IRectangleProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    static member inline ref (value: IRefValue<Leaflet.Rectangle<_>>) = Interop.mkRectangleProp "ref" value

[<Erase>]
type svgOverlay =
    inherit BaseProps.InteractiveLayer<ISVGOverlayProp>
    static member inline bounds (value: LatLngBounds) = Interop.mkSVGOverlayProp "bounds" value
    static member inline bounds (value: LatLngAltBounds) = Interop.mkSVGOverlayProp "bounds" value
    static member inline opacity (value: float) = Interop.mkSVGOverlayProp "opacity" value
    static member inline url (value: string) = Interop.mkSVGOverlayProp "url" value
    static member inline alt (value: string) = Interop.mkSVGOverlayProp "alt" value
    static member inline crossOrigin (value: bool) = Interop.mkSVGOverlayProp "crossOrigin" value
    static member inline eventHandlers (value: svgOverlayEvent list) = unbox<ISVGOverlayProp> ("eventHandlers" ==> keyValueList CaseRules.LowerFirst value)
    // static member inline ref (value: IRefValue<Leaflet.ImageOverlay>) = Interop.mkImageOverlayProp "ref" value
