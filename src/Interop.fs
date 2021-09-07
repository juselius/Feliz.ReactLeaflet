namespace Feliz.ReactLeaflet

open Fable.Core

[<Erase; RequireQualifiedAccess>]
module Interop =
    [<Emit("Object.keys($0)")>]
    let internal objectKeys (x: obj) = jsNative
    let objectHas (keys: string list) (x: obj) =
        objectKeys(x)
        |> Seq.toList
        |> (=) keys

    let inline mkMapContainerProp (key: string) (value: obj) : IMapContainerProp = unbox (key, value)
    let inline mkAttributionControlProp (key: string) (value: obj) : IAttributionControlProp = unbox (key, value)
    let inline mkCircleProp (key: string) (value: obj) : ICircleProp = unbox (key, value)
    let inline mkCircleMarkerProp (key: string) (value: obj) : ICircleMarkerProp = unbox (key, value)
    let inline mkFeatureGroupProp (key: string) (value: obj) : IFeatureGroupProp = unbox (key, value)
    let inline mkGeoJSONProp (key: string) (value: obj) : IGeoJSONProp = unbox (key, value)
    let inline mkImageOverlayProp (key: string) (value: obj) : IImageOverlayProp = unbox (key, value)
    let inline mkLayerGroupProp (key: string) (value: obj) : ILayerGroupProp = unbox (key, value)
    let inline mkLayersControlProp (key: string) (value: obj) : ILayersControlProp = unbox (key, value)
    let inline mkLayerControlProp (key: string) (value: obj) : ILayerControlProp = unbox (key, value)
    let inline mkMarkerProp (key: string) (value: obj) : IMarkerProp = unbox (key, value)
    let inline mkPaneProp (key: string) (value: obj) : IPaneProp = unbox (key, value)
    let inline mkPolygonProp (key: string) (value: obj) : IPolygonProp = unbox (key, value)
    let inline mkPolylineProp (key: string) (value: obj) : IPolylineProp = unbox (key, value)
    let inline mkPopupProp (key: string) (value: obj) : IPopupProp = unbox (key, value)
    let inline mkRectangleProp (key: string) (value: obj) : IRectangleProp = unbox (key, value)
    let inline mkSVGOverlayProp (key: string) (value: obj) : ISVGOverlayProp = unbox (key, value)
    let inline mkScaleControlProp (key: string) (value: obj) : IScaleControlProp = unbox (key, value)
    let inline mkTileLayerProp (key: string) (value: obj) : ITileLayerProp = unbox (key, value)
    let inline mkTooltipProp (key: string) (value: obj) : ITooltipProp = unbox (key, value)
    let inline mkVideoOverlayProp (key: string) (value: obj) : IVideoOverlayProp = unbox (key, value)
    let inline mkWMSTileLayerProp (key: string) (value: obj) : IWMSTileLayerProp = unbox (key, value)
    let inline mkZoomControlProp (key: string) (value: obj) : IZoomControlProp = unbox (key, value)
    let inline mkPathOption (key: string) (value: obj) : IPathOption = unbox (key, value)