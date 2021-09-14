open Fake.Core
open Fake.IO
open Farmer
open Farmer.Builders

open Helpers

initializeContext()

let srcPath    = Path.getFullName "src"
let testPath  = Path.getFullName "test"
let deployPath = Path.getFullName "deploy"
let packPath = Path.getFullName "packages"

Target.create "Clean" (fun _ -> Shell.cleanDir deployPath)

Target.create "InstallClient" (fun _ -> run npm "install" ".")

Target.create "Bundle" (fun _ ->
    run dotnet $"publish -c Release -o \"{deployPath}\"" srcPath
)

Target.create "Pack" (fun _ ->
    run dotnet $"pack -c Release -o \"{packPath}\"" srcPath
)

Target.create "Run" (fun _ ->
    run dotnet "fable watch -o js --run webpack serve --mode development -c ../webpack.config.js" testPath
)

Target.create "Format" (fun _ ->
    run dotnet "fantomas . -r" "src"
)

open Fake.Core.TargetOperators

let dependencies = [
    "Clean"
        ==> "Bundle"

    "Clean"
        ==> "InstallClient"
        ==> "Run"

    "Clean"
        ==> "Pack"
]

[<EntryPoint>]
let main args = runOrDefault args
