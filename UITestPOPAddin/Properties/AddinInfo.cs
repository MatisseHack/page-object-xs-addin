using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "UITestPOPAddin",
    Namespace = "UITestPOPAddin",
    Version = "0.1.0"
)]

[assembly: AddinName("UITest Page Object Add-In")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("A Xamarin Studio add-in to facilitate using the page object pattern with UITest")]
[assembly: AddinAuthor("Matisse Hack")]

[assembly: AddinDependency("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly: AddinDependency("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]