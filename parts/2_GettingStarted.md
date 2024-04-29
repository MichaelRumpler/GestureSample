## Getting Started
{: #GettingStarted }

Install MR.Gestures into your MAUI project(s) with NuGet and then add a call to `ConfigureMRGestures` in your MauiProgram.cs:

~~~~ cs
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMRGestures();

        return builder.Build();
    }
~~~~

And now you can use the new elements from the namespace `MR.Gestures`.

You can also clone the [GestureSample app](https://github.com/MichaelRumpler/GestureSample).
In this app you can see how all the elements use all events. You can change the code however you like, add break points and see what it does.
You will find all the examples from here in the GestureSample and many more.
