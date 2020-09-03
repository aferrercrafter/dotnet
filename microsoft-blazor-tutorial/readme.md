## First Step

Creating the app with dotnet cli

``` [console]
dotnet new blazorserver -o BlazorApp --no-https
cd BlazorApp
```

### What do these commands mean?
- The `dotnet new blazorserver` command creates a new Blazor Server app for you.
- The `-o` parameter creates a directory named BlazorApp where your app is stored and populates it with the required files.
- The `--no-https` flag specifies not to enable HTTPS.
- The command `cd BlazorApp` changes your directory to the one you just created.

### What files were created?

Several files were created in the BlazorApp directory, to give you a simple Blazor app that is ready to run.

- `Program.cs` is the entry point for the app that starts the server.
- `Startup.cs` is where you configure the app services and middleware.
- `App.razor` is the root component for the app.
- The `BlazorApp/Pages` directory contains some example web pages for the app.
- `BlazorApp.csproj` defines the app project and its dependencies.

## Second Step 

### Run your app

In your command prompt, run the following command:

``` [console]
Copy
dotnet run
```
Wait for the app to display that it's listening on http://localhost:5000 and then, open a browser and navigate to that address.

The displayed page is defined by the Pages/Index.razor file.

``` [html]
@page "/"

<h1>Hello, world!</h1>

Welcome to your new app.

<SurveyPrompt Title="How is Blazor working for you?" />
```

It already contains the code that sets it as the homepage and displays the text "Hello, world!" and "Welcome to your new app". It also includes a `SurveyPrompt` component that renders a link to the Blazor feedback survey.

## Thirs Step

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

## Thirs Step

### Add a component

Each of the `.razor` files defines a UI component that can be reused.

Open `Pages/Index.razor` in a text editor of your choice. Add a Counter component to the app's homepage by adding a <Counter /> element at the end of the file.

Re-run your app
End the previous `dotnet run` command that is running the site locally, then run the following command to re-launch the site and Refresh the browser to see the change.

## Forth Step

### Modify a component