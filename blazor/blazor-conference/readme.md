
## Blazor History

- Interactive web UI with C#
- UI Components (Think in components)
- Single-Page App (dynamically rewriting the current web page with new data from the web server, instead of the default method of the browser loading entire new pages.)
- Open-source and free

## Blazor Server

### What files were created?

Several files were created in the BlazorApp directory, to give you a simple Blazor app that is ready to run.

- `Program.cs` is the entry point for the app that starts the server. Build and Run
- `Startup.cs` is where you configure the app services and middleware. MapBlazorHub()
- `App.razor` is the root component for the app.
- The `BlazorApp/Pages` directory contains some example web pages for the app.
- `BlazorApp.csproj` defines the app project and its dependencies.

### Understanding Counter Page

the implementation of the Counter component at Pages/Counter.razor.

@page "/counter"

``` [csharp]

<h1>Counter</h1>

<p>Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
``` 

A request for `/counter` in the browser, as specified by the `@page` directive at the top, causes the `Counter` component to render its content.

Each time the Click me button is selected:

- The `onclick` event is fired.
- The `IncrementCount` method is called.
- The `currentCount` is incremented.
- The `component` is rendered to show the updated count.

## What is WebAssembly ##
WebAssembly (abbreviated Wasm) is a binary instruction format for a stack-based virtual machine. Wasm is designed as a portable compilation target for programming languages, enabling deployment on the web for client and server applications. 
From https://webassembly.org/

Think of WASM as the Universal Virtual Machine (sandbox), where you write ANY code once, and it runs everywhere.

WASM is a compile target, not a language. As if you were to compile for Windows, Mac OS, and Linux at once!

I don’t think that WASM is about dethroning JS, it’s about having alternatives without any sacrifices.

Imagine all the people that are developing in Go, Swift, Rust, Ruby, C++, OCaml or others. Now, they can use their preferred language to create an interactive, networked, fast, offline-capable websites and web apps.
From https://www.freecodecamp.org/news/webassembly-with-golang-is-fun-b243c0e34f02/

## Blazor Web Assembly ##
Blazor WebAssembly is a single-page app framework for building interactive client-side web apps with .NET. Blazor WebAssembly uses open web standards without plugins or code transpilation and works in all modern web browsers, including mobile browsers.

Running .NET code inside web browsers is made possible by WebAssembly (abbreviated wasm). WebAssembly is a compact bytecode format optimized for fast download and maximum execution speed. WebAssembly is an open web standard and supported in web browsers without plugins.

WebAssembly code can access the full functionality of the browser via JavaScript, called JavaScript interoperability (or JavaScript interop). .NET code executed via WebAssembly in the browser runs in the browser's JavaScript sandbox with the protections that the sandbox provides against malicious actions on the client machine.

https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1#blazor-webassembly

## Blazor Web Components (Razor components) ##
Blazor is based on a powerful and flexible component model for building rich interactive web UI. You implement Blazor UI components using a combination of .NET code and Razor syntax: an elegant melding of HTML and C#. Blazor components can seamlessly handle UI events, bind to user input, and efficiently render UI updates.

Components are implemented in Razor component files (.razor) using a combination of C# and HTML markup. A component in Blazor is formally referred to as a Razor component.

## Blazor PWA ##
https://docs.microsoft.com/en-us/aspnet/core/blazor/progressive-web-app?view=aspnetcore-3.1&tabs=visual-studio
