open Fake.Core
open Fake.IO
open Farmer
open Farmer.Builders

open Helpers

initializeContext()

let clientPath = Path.getFullName "src/Client"
let sharedPath = Path.getFullName "src/Shared"
let serverPath = Path.getFullName "src/Server"
let testPath   = Path.getFullName "test"
let libPath    = Path.getFullName "src"

let deployPath = Path.getFullName "deploy"
let packPath = Path.getFullName "packages"
let versionFile = Path.getFullName ".version"

Target.create "Clean" (fun _ -> Shell.cleanDir deployPath)

Target.create "InstallClient" (fun _ -> run npm "install" ".")

Target.create "Bundle" (fun _ ->
    run dotnet $"publish -c Release -o \"{deployPath}\"" libPath
)

Target.create "BundleDebug" (fun _ ->
    run dotnet $"publish -c Debug -o \"{deployPath}\"" libPath
)

Target.create "Pack" (fun _ ->
    run dotnet $"pack -c Release -o \"{packPath}\"" libPath
)

Target.create "Run" (fun _ ->
    run dotnet "fable watch -o js --run webpack serve --mode development -c ../webpack.config.js" testPath
)

Target.create "Format" (fun _ ->
    run dotnet "fantomas . -r" "src"
)

Target.create "Test" (fun _ ->
    if System.IO.Directory.Exists testPath then
      run dotnet "run" testPath
    else ()
)

open Fake.Core.TargetOperators

let dependencies = [
    "Clean"
        ==> "InstallClient"
        ==> "Bundle"

    "Clean"
        ==> "BundleDebug"

    "Clean"
        ==> "Test"

    "Clean"
        ==> "InstallClient"
        ==> "Run"

    "Clean"
        ==> "Pack"
]

[<EntryPoint>]
let main args = runOrDefault args
