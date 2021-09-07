namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type circle =
    inherit Base.Path<ICircleProp>
    static member inline center (value: Leaflet.LatLngExpression) = Interop.mkCircleProp "center" value
    static member inline pathOptions (value: IPathOption list) = unbox<ICircleProp> ("pathOptions", createObj !!value)
    static member inline radius (value: float) = Interop.mkCircleProp "radius" value
    static member inline onClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleProp "onClick" value
    static member inline onDblClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleProp "onDblClick" value
    static member inline onMouseDown (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleProp "onMouseDown" value
    static member inline onMouseOver (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleProp "onMouseOver" value
    static member inline onMouseOut (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleProp "onMouseOut" value
    static member inline onContextMenu (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleProp "onContextMenu" value
    static member inline onAdd (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkCircleProp "onAdd" value
    static member inline onRemove (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkCircleProp "onRemove" value
    static member inline onPopupOpen (value: (Leaflet.PopupEvent -> unit)) = Interop.mkCircleProp "onPopupOpen" value
    static member inline onPopupClose (value: (Leaflet.PopupEvent -> unit)) = Interop.mkCircleProp "onPopupClose" value

[<Erase>]
type circleMarker =
    inherit Base.Path<ICircleMarkerProp>
    static member inline center (value: Leaflet.LatLngExpression) = Interop.mkCircleMarkerProp "center" value
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkCircleMarkerProp "pathOptions" value
    static member inline radius (value: float) = Interop.mkCircleMarkerProp "radius" value
    static member inline onClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleMarkerProp "onClick" value
    static member inline onDblClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleMarkerProp "onDblClick" value
    static member inline onMouseDown (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleMarkerProp "onMouseDown" value
    static member inline onMouseOver (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleMarkerProp "onMouseOver" value
    static member inline onMouseOut (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleMarkerProp "onMouseOut" value
    static member inline onContextMenu (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkCircleMarkerProp "onContextMenu" value
    static member inline onAdd (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkCircleMarkerProp "onAdd" value
    static member inline onRemove (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkCircleMarkerProp "onRemove" value
    static member inline onPopupOpen (value: (Leaflet.PopupEvent -> unit)) = Interop.mkCircleMarkerProp "onPopupOpen" value
    static member inline onPopupClose (value: (Leaflet.PopupEvent -> unit)) = Interop.mkCircleMarkerProp "onPopupClose" value

[<Erase>]
type polyline =
    inherit Base.Path<IPolylineProp>
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkPolylineProp "pathOptions" value
    static member inline positions (value: Leaflet.LatLngExpression []) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][]) = Interop.mkPolylineProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][][]) = Interop.mkPolylineProp "positions" value
    static member inline smoothFactor (value: float) = Interop.mkPolylineProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkPolylineProp "noClip" value
    static member inline onClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolylineProp "onClick" value
    static member inline onDblClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolylineProp "onDblClick" value
    static member inline onMouseDown (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolylineProp "onMouseDown" value
    static member inline onMouseOver (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolylineProp "onMouseOver" value
    static member inline onMouseOut (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolylineProp "onMouseOut" value
    static member inline onContextMenu (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolylineProp "onContextMenu" value
    static member inline onAdd (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkPolylineProp "onAdd" value
    static member inline onRemove (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkPolylineProp "onRemove" value
    static member inline onPopupOpen (value: (Leaflet.PopupEvent -> unit)) = Interop.mkPolylineProp "onPopupOpen" value
    static member inline onPopupClose (value: (Leaflet.PopupEvent -> unit)) = Interop.mkPolylineProp "onPopupClose" value
    static member inline positions (value: U3<Leaflet.LatLngExpression [], Leaflet.LatLngExpression [][], Leaflet.LatLngExpression [][][]>) = Interop.mkPolylineProp "positions" value

[<Erase>]
type polygon =
    inherit Base.Path<IPolygonProp>
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkPolygonProp "pathOptions" value
    static member inline positions (value: Leaflet.LatLngExpression []) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][]) = Interop.mkPolygonProp "positions" value
    static member inline positions (value: Leaflet.LatLngExpression [][][]) = Interop.mkPolygonProp "positions" value
    static member inline smoothFactor (value: float) = Interop.mkPolygonProp "smoothFactor" value
    static member inline noClip (value: bool) = Interop.mkPolygonProp "noClip" value
    static member inline onClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolygonProp "onClick" value
    static member inline onDblClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolygonProp "onDblClick" value
    static member inline onMouseDown (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolygonProp "onMouseDown" value
    static member inline onMouseOver (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolygonProp "onMouseOver" value
    static member inline onMouseOut (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolygonProp "onMouseOut" value
    static member inline onContextMenu (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkPolygonProp "onContextMenu" value
    static member inline onAdd (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkPolygonProp "onAdd" value
    static member inline onRemove (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkPolygonProp "onRemove" value
    static member inline onPopupOpen (value: (Leaflet.PopupEvent -> unit)) = Interop.mkPolygonProp "onPopupOpen" value
    static member inline onPopupClose (value: (Leaflet.PopupEvent -> unit)) = Interop.mkPolygonProp "onPopupClose" value

[<Erase>]
type rectangle =
    inherit Base.Path<IRectangleProp>
    static member inline bounds (value: Leaflet.LatLngBoundsExpression) = Interop.mkRectangleProp "bounds" value
    static member inline pathOptions (value: Leaflet.PathOptions) = Interop.mkRectangleProp "pathOptions" value
    static member inline onClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkRectangleProp "onClick" value
    static member inline onDblClick (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkRectangleProp "onDblClick" value
    static member inline onMouseDown (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkRectangleProp "onMouseDown" value
    static member inline onMouseOver (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkRectangleProp "onMouseOver" value
    static member inline onMouseOut (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkRectangleProp "onMouseOut" value
    static member inline onContextMenu (value: (Leaflet.LeafletMouseEvent -> unit)) = Interop.mkRectangleProp "onContextMenu" value
    static member inline onAdd (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkRectangleProp "onAdd" value
    static member inline onRemove (value: (Leaflet.LeafletEvent -> unit)) = Interop.mkRectangleProp "onRemove" value
    static member inline onPopupOpen (value: (Leaflet.PopupEvent -> unit)) = Interop.mkRectangleProp "onPopupOpen" value
    static member inline onPopupClose (value: (Leaflet.PopupEvent -> unit)) = Interop.mkRectangleProp "onPopupClose" value
    static member inline popupContainer (value: Leaflet.FeatureGroup<obj>) = Interop.mkRectangleProp "popupContainer" value

// [<Erase>]
// type svgOverlay =
//     static member inline attributes (value: Record<string) = Interop.mk string>Prop "attributes" value,SVGOverlay
//     static member inline attribution (value: string) = Interop.mkSVGOverlayProp "attribution" value
//     static member inline children (value: ReactElement) = Interop.mkSVGOverlayProp "children" value
//     static member inline pane (value: string) = Interop.mkSVGOverlayProp "pane" value
//     static member inline ref (value: IRefValue<Leaflet.SVGOverlay>) = Interop.mkSVGOverlayProp "ref" value
