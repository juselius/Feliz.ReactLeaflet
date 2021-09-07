namespace Feliz.ReactLeaflet

open Fable.Core
open Feliz

[<Erase>]
type zoomControl =
    static member inline eventHandlers (value: Leaflet.LeafletEventHandlerFnMap) = Interop.mkZoomControlProp "eventHandlers" value
    static member inline position (value: Leaflet.ControlPosition) = Interop.mkZoomControlProp "position" value
    static member inline ref (value: IRefValue<Leaflet.Control.Zoom>) = Interop.mkZoomControlProp "ref" value

[<Erase>]
type AttributionControl =
    static member inline eventHandlers (value: Leaflet.LeafletEventHandlerFnMap) = Interop.mkAttributionControlProp "eventHandlers" value
    static member inline position (value: Leaflet.ControlPosition) = Interop.mkAttributionControlProp "position" value
    static member inline ref (value: IRefValue<Leaflet.Control.Attribution>) = Interop.mkAttributionControlProp "ref" value

[<Erase>]
type layersControl =
    static member inline collapsed (value: bool) = Interop.mkLayersControlProp "collapsed" value
    static member inline eventHandlers (value: Leaflet.LeafletEventHandlerFnMap) = Interop.mkLayersControlProp "eventHandlers" value
    static member inline position (value: Leaflet.ControlPosition) = Interop.mkLayersControlProp "position" value
    static member inline ref (value: IRefValue<Leaflet.Control.Layers>) = Interop.mkLayersControlProp "ref" value

module LayersControl =
    [<Erase>]
    type baseLayer =
        static member inline ``checked`` (value: bool) = Interop.mkLayerControlProp "checked" value
        static member inline children (value: ReactElement) = Interop.mkLayerControlProp "checked" value
        static member inline name (value: string) = Interop.mkLayerControlProp "checked" value
        static member inline children (elements: ReactElement list) = unbox<ILayerControlProp> (prop.children elements)

    [<Erase>]
    type overlay =
        static member inline ``checked`` (value: bool) = Interop.mkLayerControlProp "checked" value
        static member inline children (value: ReactElement) = Interop.mkLayerControlProp "checked" value
        static member inline name (value: string) = Interop.mkLayerControlProp "checked" value
        static member inline children (elements: ReactElement list) = unbox<ILayerControlProp> (prop.children elements)

[<Erase>]
type scaleControl =
    static member inline eventHandlers (value: Leaflet.LeafletEventHandlerFnMap) = Interop.mkScaleControlProp "eventHandlers" value
    static member inline position (value: Leaflet.ControlPosition) = Interop.mkScaleControlProp "position" value
    static member inline ref (value: IRefValue<Leaflet.Control.Scale>) = Interop.mkScaleControlProp "ref" value
