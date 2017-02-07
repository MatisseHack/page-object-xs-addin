#r "FakeLib.dll"
open Fake

let mdtool = "\"/Applications/Xamarin Studio.app/Contents/Resources/lib/monodevelop/bin/mdtool.exe\""
let buildDir = currentDirectory + "/UITestPOPAddin/bin/Release/"
let releaseDir = currentDirectory + "/release/"
let projects = [currentDirectory + "/UITestPOPAddin/UITestPOPAddin.csproj"]

Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

Target "Build" (fun _ ->
    MSBuildRelease null "Build" projects
        |> Log "Build-output: "
)

Target "Package" (fun _ ->
    let args =
        System.String.Join(" ",
            [
                mdtool;
                "setup";
                "pack";
                buildDir + "UITestPOPAddin.dll"
            ]
        )

    Shell.Exec("mono", args, releaseDir)
        |> ignore
)

Target "Release" (fun _ ->
    let args =
        System.String.Join(" ",
            [
                mdtool;
                "setup";
                "rep-build";
                releaseDir
            ]
        )

    Shell.Exec("mono", args)
        |> ignore
)

"Clean"
==> "Build"
==> "Package"
==> "Release"

RunTargetOrDefault "Release"