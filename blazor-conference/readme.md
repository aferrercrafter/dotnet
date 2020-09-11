
### Blazor History

### Blazor Server

## What files were created?

Several files were created in the BlazorApp directory, to give you a simple Blazor app that is ready to run.

- `Program.cs` is the entry point for the app that starts the server.
- `Startup.cs` is where you configure the app services and middleware.
- `App.razor` is the root component for the app.
- The `BlazorApp/Pages` directory contains some example web pages for the app.
- `BlazorApp.csproj` defines the app project and its dependencies.

## Understanding Counter Page

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
