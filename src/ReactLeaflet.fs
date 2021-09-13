namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type ReactLeaflet =
    static member inline mapContainer (properties: IMapContainerProp list) =
        Interop.reactApi.createElement (import "MapContainer" "react-leaflet", createObj !!properties)
    static member inline mapConsumer (renderer: Leaflet.Map -> unit) =
        Fable.React.ReactBindings.React.createElement (import "MapConsumer" "react-leaflet", [], [ !!renderer ])
    static member inline useMap () : Leaflet.Map = import "useMap" "react-leaflet"
    [<Emit("useMapEvent($0, $1)")>]
    static member inline useMapEvent (ev: string * (unit -> unit)) : ReactElement = jsNative
    [<Emit("useMapEvents($0)")>]
    static member inline useMapEvents (ev: Leaflet.LeafletEventHandlerFnMap) : ReactElement = jsNative
    static member inline attributionControl (properties: IAttributionControlProp list) =
       Interop.reactApi.createElement (import "AttributionControl" "react-leaflet", createObj !!properties)
    static member inline circle (properties: ICircleProp list) =
       Interop.reactApi.createElement (import "Circle" "react-leaflet", createObj !!properties)
    static member inline circleMarker (properties: ICircleMarkerProp list) =
       Interop.reactApi.createElement (import "CircleMarker" "react-leaflet", createObj !!properties)
    static member inline featureGroup (properties: IFeatureGroupProp list) =
       Interop.reactApi.createElement (import "FeatureGroup" "react-leaflet", createObj !!properties)
    static member inline geoJSON (properties: IGeoJSONProp list) =
       Interop.reactApi.createElement (import "GeoJSON" "react-leaflet", createObj !!properties)
    static member inline imageOverlay (properties: IImageOverlayProp list) =
       Interop.reactApi.createElement (import "ImageOverlay" "react-leaflet", createObj !!properties)
    static member inline layerGroup (properties: ILayerGroupProp list) =
       Interop.reactApi.createElement (import "LayerGroup" "react-leaflet", createObj !!properties)
    static member inline layersControl (properties: ILayersControlProp list) =
       Interop.reactApi.createElement (import "LayersControl" "react-leaflet", createObj !!properties)
    static member inline marker (properties: IMarkerProp list) =
       Interop.reactApi.createElement (import "Marker" "react-leaflet", createObj !!properties)
    static member inline pane (properties: IPaneProp list) =
       Interop.reactApi.createElement (import "Pane" "react-leaflet", createObj !!properties)
    static member inline polygon (properties: IPolygonProp list) =
       Interop.reactApi.createElement (import "Polygon" "react-leaflet", createObj !!properties)
    static member inline polyline (properties: IPolylineProp list) =
       Interop.reactApi.createElement (import "Polyline" "react-leaflet", createObj !!properties)
    static member inline popup (properties: IPopupProp list) =
       Interop.reactApi.createElement (import "Popup" "react-leaflet", createObj !!properties)
    static member inline rectangle (properties: IRectangleProp list) =
       Interop.reactApi.createElement (import "Rectangle" "react-leaflet", createObj !!properties)
    static member inline svgOverlay (properties: ISVGOverlayProp list) =
       Interop.reactApi.createElement (import "SVGOverlay" "react-leaflet", createObj !!properties)
    static member inline scaleControl (properties: IScaleControlProp list) =
       Interop.reactApi.createElement (import "ScaleControl" "react-leaflet", createObj !!properties)
    static member inline tileLayer (properties: ITileLayerProp list) =
       Interop.reactApi.createElement (import "TileLayer" "react-leaflet", createObj !!properties)
    static member inline tooltip (properties: ITooltipProp list) =
       Interop.reactApi.createElement (import "Tooltip" "react-leaflet", createObj !!properties)
    static member inline videoOverlay (properties: IVideoOverlayProp list) =
       Interop.reactApi.createElement (import "VideoOverlay" "react-leaflet", createObj !!properties)
    static member inline wmsTileLayer (properties: IWMSTileLayerProp list) =
       Interop.reactApi.createElement (import "WMSTileLayer" "react-leaflet", createObj !!properties)
    static member inline zoomControl (properties: IZoomControlProp list) =
       Interop.reactApi.createElement (import "ZoomControl" "react-leaflet", createObj !!properties)

[<Erase>]
type mapContainer =
    inherit BaseProps.ReactLeaflet<IMapContainerProp>
    static member inline bounds (value: Leaflet.LatLngBoundsExpression) = Interop.mkMapContainerProp "bounds" value
    static member inline boundsOptions (value: Leaflet.FitBoundsOptions) = Interop.mkMapContainerProp "boundsOption" value
    static member inline className (value: string) = Interop.mkMapContainerProp "className" value
    static member inline id (value: string) = Interop.mkMapContainerProp "id" value
    static member inline placeholder (value: ReactElement) = Interop.mkMapContainerProp "placeholder" value
    static member inline style (value: IStyleAttribute list) = unbox ("style", createObj !!value)
    static member inline whenCreated (value: (Leaflet.Map -> unit)) = Interop.mkMapContainerProp "whenCreated" value
    static member inline whenReady (value: (unit -> unit)) = Interop.mkMapContainerProp "whenReady" value
    static member inline preferCanvas (value: bool) = Interop.mkMapContainerProp "preferCanvas" value
    static member inline attributionControl (value: bool) = Interop.mkMapContainerProp "attributionControl" value
    static member inline zoomControl (value: bool) = Interop.mkMapContainerProp "zoomControl" value
    static member inline closePopupOnClick (value: bool) = Interop.mkMapContainerProp "closePopupOnClick" value
    static member inline zoomSnap (value: float) = Interop.mkMapContainerProp "zoomSnap" value
    static member inline zoomDelta (value: float) = Interop.mkMapContainerProp "zoomDelta" value
    static member inline trackResize (value: bool) = Interop.mkMapContainerProp "trackResize" value
    static member inline boxZoom (value: bool) = Interop.mkMapContainerProp "boxZoom" value
    static member inline doubleClickZoom (value: Leaflet.Zoom) = Interop.mkMapContainerProp "doubleClickZoom" value
    static member inline dragging (value: bool) = Interop.mkMapContainerProp "dragging" value
    static member inline crs (value: Leaflet.CRS) = Interop.mkMapContainerProp "crs" value
    static member inline layers (value: ResizeArray<Leaflet.Layer>) = Interop.mkMapContainerProp "layers" value
    static member inline renderer (value: Leaflet.Renderer) = Interop.mkMapContainerProp "renderer" value
    static member inline fadeAnimation (value: bool) = Interop.mkMapContainerProp "fadeAnimation" value
    static member inline markerZoomAnimation (value: bool) = Interop.mkMapContainerProp "markerZoomAnimation" value
    static member inline transform3DLimit (value: float) = Interop.mkMapContainerProp "transform3DLimit" value
    static member inline zoomAnimation (value: bool) = Interop.mkMapContainerProp "zoomAnimation" value
    static member inline zoomAnimationThreshold (value: float) = Interop.mkMapContainerProp "zoomAnimationThreshold" value
    static member inline inertia (value: bool) = Interop.mkMapContainerProp "inertia" value
    static member inline inertiaDeceleration (value: float) = Interop.mkMapContainerProp "inertiaDeceleration" value
    static member inline inertiaMaxSpeed (value: float) = Interop.mkMapContainerProp "inertiaMaxSpeed" value
    static member inline easeLinearity (value: float) = Interop.mkMapContainerProp "easeLinearity" value
    static member inline worldCopyJump (value: bool) = Interop.mkMapContainerProp "worldCopyJump" value
    static member inline maxBoundsViscosity (value: float) = Interop.mkMapContainerProp "maxBoundsViscosity" value
    static member inline keyboard (value: bool) = Interop.mkMapContainerProp "keyboard" value
    static member inline keyboardPanDelta (value: float) = Interop.mkMapContainerProp "keyboardPanDelta" value
    static member inline scrollWheelZoom (value: Leaflet.Zoom) = Interop.mkMapContainerProp "scrollWheelZoom" value
    static member inline wheelDebounceTime (value: float) = Interop.mkMapContainerProp "wheelDebounceTime" value
    static member inline wheelPxPerZoomLevel (value: float) = Interop.mkMapContainerProp "wheelPxPerZoomLevel" value
    static member inline tap (value: bool) = Interop.mkMapContainerProp "tap" value
    static member inline tapTolerance (value: float) = Interop.mkMapContainerProp "tapTolerance" value
    static member inline touchZoom (value: Leaflet.Zoom) = Interop.mkMapContainerProp "touchZoom" value
    static member inline bounceAtZoomLimits (value: bool) = Interop.mkMapContainerProp "bounceAtZoomLimits" value
    static member inline animate (value: bool) = Interop.mkMapContainerProp "animate" value
    static member inline center (value: Leaflet.LatLngExpression) = Interop.mkMapContainerProp "center" value
    static member inline maxBounds (value: Leaflet.LatLngBoundsExpression) = Interop.mkMapContainerProp "maxBounds" value
    static member inline minZoom (value: float) = Interop.mkMapContainerProp "minZoom" value
    static member inline useFlyTo (value: bool) = Interop.mkMapContainerProp "useFlyTo" value
    static member inline zoom (value: float) = Interop.mkMapContainerProp "zoom" value
    static member inline watch (value: bool) = Interop.mkMapContainerProp "watch" value
    static member inline setView (value: bool) = Interop.mkMapContainerProp "setView" value
    static member inline maxZoom (value: float) = Interop.mkMapContainerProp "maxZoom" value
    static member inline timeout (value: float) = Interop.mkMapContainerProp "timeout" value
    static member inline maximumAge (value: float) = Interop.mkMapContainerProp "maximumAge" value
    static member inline enableHighAccuracy (value: bool) = Interop.mkMapContainerProp "enableHighAccuracy" value
    static member inline duration (value: float) = Interop.mkMapContainerProp "duration" value
    static member inline noMoveStart (value: bool) = Interop.mkMapContainerProp "noMoveStart" value
    static member inline paddingTopLeft (value: Leaflet.PointExpression) = Interop.mkMapContainerProp "paddingTopLeft" value
    static member inline paddingBottomRight (value: Leaflet.PointExpression) = Interop.mkMapContainerProp "paddingBottomRight" value
    static member inline padding (value: Leaflet.PointExpression) = Interop.mkMapContainerProp "padding" value
    static member inline eventHandlers (value: MapEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

[<Erase>]
type layerGroup = BaseProps.Layer<ILayerGroupProp>

[<Erase>]
type featureGroup = BaseProps.Layer<IFeatureGroupProp>

[<Erase>]
type pathOptions = BaseProps.Path<IPathOption>

[<Erase>]
type geoJSON =
    inherit BaseProps.Layer<IGeoJSONProp>
    static member inline pointToLayer (value: float * float -> obj) = Interop.mkGeoJSONProp "pointToLayer" value
    static member inline style (value: Leaflet.PathOptions) = Interop.mkGeoJSONProp "style" value
    static member inline style (value: Leaflet.StyleFunction<_>) = Interop.mkGeoJSONProp "style" value
    static member inline onEachFeature (value: obj -> obj) = Interop.mkGeoJSONProp "onEachFeature" value
    static member inline filter (value: obj -> bool) = Interop.mkGeoJSONProp "filter" value
    static member inline coordsToLatLng (value: obj -> obj) = Interop.mkGeoJSONProp "coordsToLatLng" value
    static member inline markersInheritOptions (value: bool) = Interop.mkGeoJSONProp "markersInheritOptions" value
    static member inline eventHandlers (value: GeoJSONEvent list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

[<Erase>]
type pane =
    static member inline className (value: string) = Interop.mkPaneProp "className" value
    static member inline name (value: string) = Interop.mkPaneProp "name" value
    static member inline pane (value: string) = Interop.mkPaneProp "pane" value
    static member inline style (value: IStyleAttribute list) = unbox ("style", createObj !!value)
    static member inline children (elements: ReactElement list) = unbox<IPaneProp> (prop.children elements)
