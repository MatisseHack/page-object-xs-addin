# UITest page object add-in for Xamarin Studio

A Xamarin Studio add-in to facilitate using the page object pattern with UITest

## Installation

### Recommended - add-in repository

1. Open Xamarin Studio's add-in manager and locate the Gallery. Under "Repository" choose "Manage Repositories..." and then add a new one with the following url:

    ```
    https://matissehack.github.io/page-object-xs-addin/release/
    ```

1. Close the repository manager and choose "UITest Page Object Add-In" under "IDE extensions."

1. Install and enjoy

### Alternate - direct download

If you don't want to add the add-in repository to Xamarin Studio you can also download the [latest release](https://github.com/MatisseHack/page-object-xs-addin/releases/latest) and install that manually through the add-in manager.

## Features

### Project template

The new template helps initialize test suites that use the page object pattern. The template can be found under Multiplatform > Other > Page Object UI Test App.

### File templates

The new files can be found in new file wizard in the "Page Object" category. There are templates for:

* Test fixtures
* Page classes

### Code templates

The new code completion templates include:

`test`:
```csharp
[Test]
public void $name$()
{
    $end$
}
```

`xx`:
```csharp
x => x
```

`qry`:
```csharp
readonly Query $name$;
```

`fqry`:
```csharp
readonly Func<$inputType$, Query> $name$;
```

`uqry`:
```csharp
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
```
