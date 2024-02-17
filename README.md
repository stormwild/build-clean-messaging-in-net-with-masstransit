# Build Clean Messaging in .NET with MassTransit

[Build Clean Messaging in .NET with MassTransit - YouTube](https://www.youtube.com/watch?v=4FFYefcx4Bg&t=140s)

## Steps

1. Create a new .NET Core Console Application

   ```csharp
    dotnet new sln -n MassTransitDemo
    dotnet new console -o MassTransitDemo.Console
    dotnet sln add MassTransitDemo.Console/MassTransitDemo.Console.csproj
   ```

2. Modify the csproj file to change the project sdk

    from

    ```xml
    <Project Sdk="Microsoft.NET.Sdk">
    ```

    to

    ```xml
    <Project Sdk="Microsoft.NET.Sdk.Web">
    ```

3. Modify the Program.cs file to use the `WebHostBuilder`

    ```csharp
    using Microsoft.AspNetCore.Builder;

    var builder = WebApplication.CreateBuilder(args);

    var app = builder.Build();

    app.Run();
    ```

    We can test the application by running `dotnet run`. Sample output:

    ```bash
    $ dotnet run
    info: Microsoft.Hosting.Lifetime[14]
          Now listening on: <http://localhost:5000>
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    ```
