# Feliz.ReactLeaflet

Fable and Feliz bindings for [React Leaflet](https://react-leaflet.js.org). The bindings try to follow the naming and type conventions of Leaflet and  React Leaflet as closely as practically convenient. Some notable exceptions are `LatLng`, `Bounds` and `Point` which have been slightly modified with respect to their definitons in `Fable.Leaflet` in order to make them easy to work with from F# in practice.

**NB!** The interfaces are still largely untested and there are certainly bugs. Please file issues (or better, PR:s) when you encounter things which don't work like expected.

## Build and run

To build the NuGet package:

```dotnet run pack```

To run the web application for testing:

```dotnet run```
