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