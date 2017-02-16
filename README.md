# Welcome to ASP.NET Core


## This application consists of:

*   ASP.NET Core MVC app that taps into Zillow API to show information given a home address
*   [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

## How to build
*   Pull repo down 
*   Run 'bower install' from directory that has bower.json file in application
*   Then run 'dotnet restore' to collect required NuGet packages
*   Then run 'dotnet build' just to ensure most recent .dll was generated. During dev, ran
        into a problem where running 'dotnet run' did not generate a new .dll
*   Now running 'dotnet run' will start the app in the systems default browser. 

<!--## Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)-->

<!--We would love to hear your [feedback](https://go.microsoft.com/fwlink/?LinkId=518015)-->
