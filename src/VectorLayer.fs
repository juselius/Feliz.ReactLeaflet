namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type circle =
    inherit BaseProps.Path<ICircleProp>
    static member inline center (value: Leaflet.LatLngExpression) = Interop.mkCircleProp "center" value
    static member inline pathOptions (value: IPathOption list) = unbox<ICircleProp> ("pathOptions", createObj !!value)
    static member inline radius (value: float) = Interop.mkCircleProp "radius" value
    static member inline eventHandlers (value: pathEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

[<Erase>]
type circleMarker =
    inherit BaseProps.Path<ICircleMarkerProp>
    static member inline center (value: Leaflet.LatLngExpression) = Interop.mkCircleMarkerProp "center" value
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkCircleMarkerProp "pathOptions" value
    static member inline radius (value: float) = Interop.mkCircleMarkerProp "radius" value
    static member inline eventHandlers (value: circleMarkerEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

[<Erase>]
type polyline =
    inherit BaseProps.Path<IPolylineProp>
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkPolylineProp "pathOptions" value
    static member inline positions (value: Leaflet.LatLngExpression []) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][]) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][][]) = Interop.mkPolylineProp "positions" value
    static member inline smoothFactor (value: float) = Interop.mkPolylineProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkPolylineProp "noClip" value
    static member inline eventHandlers (value: pathEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

[<Erase>]
type polygon =
    inherit BaseProps.Path<IPolygonProp>
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkPolygonProp "pathOptions" value
    static member inline positions (value: Leaflet.LatLngExpression []) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][]) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][][]) = Interop.mkPolygonProp "positions" value
    static member inline smoothFactor (value: float) = Interop.mkPolygonProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkPolygonProp "noClip" value
    static member inline eventHandlers (value: pathEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

[<Erase>]
type rectangle =
    inherit BaseProps.Path<IRectangleProp>
    static member inline bounds (value: Leaflet.LatLngBoundsExpression) = Interop.mkRectangleProp "bounds" value
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkRectangleProp "pathOptions" value
    static member inline popupContainer (value: Leaflet.FeatureGroup<obj>) = Interop.mkRectangleProp "popupContainer" value
    static member inline eventHandlers (value: pathEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

// [<Erase>]
// type svgOverlay =
//     static member inline attributes (value: Record<string) = Interop.mk string>Prop "attributes" value,SVGOverlay
//     static member inline attribution (value: string) = Interop.mkSVGOverlayProp "attribution" value
//     static member inline children (value: ReactElement) = Interop.mkSVGOverlayProp "children" value
//     static member inline pane (value: string) = Interop.mkSVGOverlayProp "pane" value
//     static member inline ref (value: IRefValue<Leaflet.SVGOverlay>) = Interop.mkSVGOverlayProp "ref" value
//     static member inline eventHandlers (value: PathEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)
