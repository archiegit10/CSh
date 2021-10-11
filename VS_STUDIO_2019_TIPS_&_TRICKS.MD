# Tips & Tricks for VS 2019 & .NET

## Keyboard Shortcuts

### Window Shortcuts

| Keyboard Shortcuts                        | Description                                                           |
| ---                                       | ---                                                                   |
| `CTRL + F5`                               | runs the application                                                  |
| `F5`                                      | runs the application in debug mode, continues if paused               |
| `CTRL + K, CTRL + D`                      | formats code file                                                     |
| `CTRL + C`                                | Stops a running application (click inside console before running)     |
| `CTRL + SHIFT + N`                        | Opens the new project window                                          |
| `F2`                                      | Click file, press F2 to trigger rename                                |
| `CTRL + F4`                               | Closes the current open window                                        |
| `CTRL + TAB`                              | Pop-up with Open Files & Windows, hold CTRL for it to remain open     |
| `CTRL + SHIFT + F`                        | Opens Find & Replace window on Find tab                               |
| `CTRL + SHIFT + H`                        | Opens Find & Replace window on Replace tab                            |
| `CTRL + SHIFT + B`                        | Builds the project                                                    |

### Editor Shortcuts

| Keyboard Shortcuts                        | Description                                                           |
| ---                                       | ---                                                                   |
| `CTRL + N`                                | Create new file                                                       |
| `CTRL + SHIFT + A`                        | Add new C# item                                                       |
| `CTRL + SHIFT + S`                        | Save all                                                              |
| `CTRL + S`                                | Save currently open file/item                                         |
| `CTRL + K, CTRL + C`                      | Single-line comment, highlight to apply to multiple lines             |
| `CTRL + K, CTRL + U`                      | Uncomment single-line comment, highlight for group                    |
| `CTRL + .`                                | Opens the Quick Action window                                         |
| `CTRL + K, CTRL + X`                      | Opens the Code Snippets window                                        |
| `CTRL + K, CTRL + S`                      | Surround with code snippet, select option from opened window          |
| `F9`                                      | Add breakpoint                                                        |
| `CTRL + SHIFT + F9`                       | Delete all breakpoints                                                |

### Debug Mode Shortcuts

| Keyboard Shortcuts                        | Description                                                           |
| ---                                       | ---                                                                   |
| `F5`                                      | runs the application in debug mode, continues if paused               |
| `F11`                                     | Step into                                                             |
| `F10`                                     | Step over                                                             |
| `SHIFT + F11`                             | Step out                                                              |
| `SHIFT + F5`                              | Exit application                                                      |
| `F9`                                      | Add breakpoint                                                        |
| `CTRL + SHIFT + F9`                       | Delete all breakpoints                                                |
| `CTRL + K, CTRL + I`                      | Show hover window for code under current cursor position              |

## .NET CLI Tool Commands

| Commands                                  | Description                                                           |
| ---                                       | ---                                                                   |
| `dotnet run`                              | Runs the application                                                  |
| `dotnet run -- args`                      | Runs an application and passes in args                                |
| `dotnet watch run`                        | Runs the application with a change watcher, rebuilds on change        |
| `dotnet new <template> [flags]`           | Creates a new dotnet project, config file, or solution                |
| `dotnet new web -n <name> -o .`           | Creates a new ASP.NET Core Empty web project                          |
| `dotnet new mvc -n <name> -o .`           | Creates a new ASP.NET Core Web App (MVC)                              |
| `dotnet new webApp -o <name> --no-https`  | Creates a new ASP.NET Core Web App without https                      |
| `dotnet new webapi -n <name> -o .`        | Creates a new ASP.NET Core Web API                                    |
| `dotnet new console -n <name> -o .`       | Creates a new console app in the current dir                          |
| `dotnet new gitignore`                    | Generates a dotnet gigignore file                                     |
| `dotnet clean`                            | Cleans build outputs                                                  |
| `dotnet help <command>`                   | Opens online documentation                                            |
| `dotnet help <command> -h|--help`         | Prints short help for command                                         |
| `dotnet pack`                             | Builds and packages a project as a NuGet package (.nupkg). Web projects are not packable by default |
| `dotnet pack --no-build`                  | Packages the project without the build phase                          |
| `dotnet restore`                          | Restores dependencies, usually automatically triggered                |
| `dotnet test`                             | Runs tests using the projects test runner                             |
| `dotnet add <project> package <package>`  | Runs compatibility check, adds `<PackageReference>` element to project file and runs `dotnet restore`, project defaults to the current if not specified |
| `dotnet remove <project> package <package>` | Removes a package reference from the project file                   |
| `dotnet tool install <package> --global`  | Installs the specified .NET tool globally on the machine              |
| `dotnet tool install <package>`           | Installs the specified .NET tool locally (current dir) on the machine |
| `dotnet tool list --global`               | Lists all globally installed .NET tools                               |
| `dotnet tool list --local`                | Lists all tools installed locally for the current dir                 |
| `dotnet tool uninstall <package>`         | Uninstalls a local tool                                               |
| `dotnet tool uninstall <package> --global`| Uninstalls a global tool

## NuGet Package Manager Commands

| Commands                                          | Description                                                           |
| ---                                               | ---                                                                   |
| `Find-Package <package>`                          | Finds packages containing the specified keyword                       |
| `Find-Package <package> -StartsWith`              | Finds packages that start with the specified keyword                  |
| `Find-Package <package> -First <n>`               | Finds and lists the first n packages, 20 by default                   |
| `Find-Package <package> -AllVersions -ExactMatch` | Finds all versions for the specified package                          |
| `Install-Package <package> -ProjectName <project>`| Installs the package in the specified project                         |
| `Install-Package <package>`                       | Installs the package in the current default project                   |
| `Install-Package <package> -Version x.x.x`        | Installs the package of the specified version                         |
| `Uninstall-Package <package>`                     | Uninstalls the specified package from the default project             |
| `Uninstall-Package <package> -Version x.x.x`      | Uninstalls the package of the specified version from the default project |
| `Uninstall-Package <package> -RemoveDependencies` | Uninstalls the package and removes all unused dependencies            |
| `Uninstall-Package <package> -Force`              | Uninstalls the package even if another depends on it                  |
| `Get-Package -updates`                            | Checks for updates for currently installed packages                   |
| `Update-Package <package>`                        | Updates the specified package using its identifier                    |
| `Update-Package -ProjectName <project>`           | Update all packages in the specified project                          |
| `Update-Package`                                  | Updates all packages in the current solution                          |

## Code Snippets

Code snippets are typed and then tabbed twice to generate a template of code for a specific feature:

| Code                                      | Description                                                           |
| ---                                       | ---                                                                   |
| prop                                      | Generates a Property template with get and set accessors              |
| foreach                                   | Generates a for each loop template                                    |
| if                                        | Generates an if statement template                                    |
| for                                       | Generates a for loop template                                         |
| try                                       | Generates a try-catch block                                           |
| tryf                                      | Generates a try-finally block                                         |
| cl                                        | Generates a class template                                            |
| ctor                                      | Generates a constructor template                                      |

## Packaging web apps

Web apps require a property in the `.csproj` file:

```xml
<PropertyGroup>
   <IsPackable>true</IsPackable>
</PropertyGroup>
```