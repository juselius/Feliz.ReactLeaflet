namespace Feliz.ReactLeaflet

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<StringEnum>]
[<RequireQualifiedAccess>]
type LineCapShape =
    | Butt
    | Round
    | Square
    | Inherit

[<StringEnum>]
[<RequireQualifiedAccess>]
type LineJoinShape =
    | Miter
    | Round
    | Bevel
    | Inherit

[<StringEnum>]
[<RequireQualifiedAccess>]
type FillRule =
    | Nonzero
    | Evenodd
    | Inherit

[<StringEnum>]
[<RequireQualifiedAccess>]
type ControlPosition =
    | Topleft
    | Topright
    | Bottomleft
    | Bottomright

[<StringEnum>]
[<RequireQualifiedAccess>]
type Direction =
    | Right
    | Left
    | Top
    | Bottom
    | Center
    | Auto

module BaseProps =
    [<Erase>]
    type ReactLeaflet<'a> =
        static member inline attribution (value: string) = unbox<'a> ("attribution", value)
        static member inline ref (value: (obj -> unit)) = unbox<'a> ("ref", value)
        static member inline key (value: string) = unbox<'a> ("key", value)
        static member inline custom (key: string, value: obj) = unbox<'a> (key, value)
        static member inline children (elements: ReactElement list) = unbox<'a> (prop.children elements)
        // static member inline eventHandlers (value: EventHandler list) = unbox<'a> ("eventHandlers", keyValueList CaseRules.LowerFirst value)

    [<Erase>]
    type Layer<'a> =
        inherit ReactLeaflet<'a>
        static member inline pane (value: string) = unbox<'a> ("pane", value)
        static member inline className (value: string) = unbox<'a> ("className", value)
        static member inline zIndex (value: float) = unbox<'a> ("zIndex", value)

    [<Erase>]
    type InteractiveLayer<'a> =
        inherit Layer<'a>
        static member inline interactive (value: bool) = unbox<'a> ("interactive", value)
        static member inline bubblingMouseEvents (value: bool) = unbox<'a> ("bubblingMouseEvents", value)

    [<Erase>]
    type GridLayer<'a> =
        inherit Layer<'a>
        static member inline tileSize (value: float) = unbox<'a> ("tileSize", value)
        static member inline tileSize (value: Leaflet.Point) = unbox<'a> ("tileSize", value)
        static member inline opacity (value: float) = unbox<'a> ("opacity", value)
        static member inline updateWhenIdle (value: bool) = unbox<'a> ("updateWhenIdle", value)
        static member inline updateWhenZooming (value: bool) = unbox<'a> ("updateWhenZooming", value)
        static member inline updateInterval (value: float) = unbox<'a> ("updateInterval", value)
        static member inline bounds (value: Leaflet.LatLngBoundsExpression) = unbox<'a> ("bounds", value)
        static member inline minZoom (value: float) = unbox<'a> ("minZoom", value)
        static member inline maxZoom (value: float) = unbox<'a> ("maxZoom", value)
        static member inline maxNativeZoom (value: float) = unbox<'a> ("maxNativeZoom", value)
        static member inline minNativeZoom (value: float) = unbox<'a> ("minNativeZoom", value)
        static member inline noWrap (value: bool) = unbox<'a> ("noWrap", value)
        static member inline keepBuffer (value: float) = unbox<'a> ("keepBuffer", value)

    [<Erase>]
    type Path<'a> =
        inherit InteractiveLayer<'a>
        static member inline stroke (value: bool) = unbox<'a> ("stroke", value)
        static member inline color (value: string) = unbox<'a> ("color", value)
        static member inline weight (value: float) = unbox<'a> ("weight", value)
        static member inline opacity (value: float) = unbox<'a> ("opacity", value)
        static member inline lineCap (value: LineCapShape) = unbox<'a> ("lineCap", value)
        static member inline lineJoin (value: LineJoinShape) = unbox<'a> ("lineJoin", value)
        static member inline dashArray (value: string) = unbox<'a> ("dashArray", value)
        static member inline dashOffset (value: string) = unbox<'a> ("dashOffset", value)
        static member inline fill (value: bool) = unbox<'a> ("fill", value)
        static member inline fillColor (value: string) = unbox<'a> ("fillColor", value)
        static member inline fillOpacity (value: float) = unbox<'a> ("fillOpacity", value)
        static member inline fillRule (value: FillRule) = unbox<'a> ("fillRule", value)
        static member inline renderer (value: Leaflet.Renderer) = unbox<'a> ("renderer", value)


[<Erase>]
type IMapContainerProp = interface end

[<Erase>]
type IAttributionControlProp = interface end

[<Erase>]
type ICircleProp = interface end

[<Erase>]
type ICircleMarkerProp = interface end

[<Erase>]
type IFeatureGroupProp = interface end

[<Erase>]
type IGeoJSONProp = interface end

[<Erase>]
type IImageOverlayProp = interface end

[<Erase>]
type ILayerGroupProp = interface end

[<Erase>]
type ILayersControlProp = interface end

[<Erase>]
type ILayerControlProp = interface end

[<Erase>]
type IMarkerProp = interface end

[<Erase>]
type IPaneProp = interface end

[<Erase>]
type IPolygonProp = interface end

[<Erase>]
type IPolylineProp = interface end

[<Erase>]
type IPopupProp = interface end

[<Erase>]
type IRectangleProp = interface end

[<Erase>]
type ISVGOverlayProp = interface end

[<Erase>]
type IScaleControlProp = interface end

[<Erase>]
type ITooltipProp = interface end

[<Erase>]
type IVideoOverlayProp = interface end

[<Erase>]
type IWMSTileLayerProp = interface end

[<Erase>]
type IZoomControlProp = interface end

[<Erase>]
type IPathOption = interface end

[<Erase>]
type ITileLayerProp = Feliz.IReactProperty
