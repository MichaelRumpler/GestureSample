# GestureSample

This is the sample project for **MR.Gestures**. It shows all the touch gesture handling possible with that library and .NET MAUI or Xamarin.Forms.

To find out more about MR.Gestures visit [https://www.mrgestures.com](https://www.mrgestures.com).

## Which version should I install?

MR.Gestures started in 2015 as enhancement for Xamarin.Forms. Forms´ successor is .NET MAUI. Microsoft will stop supporting Xamarin.Forms on May 1, 2024.

Therefore MR.Gestures will also stop supporting Xamarin.Forms and focus on MAUI instead.

Version 3.0.0 is for Xamarin.Forms and .NET MAUI with .NET6. This version contains dlls for both UI frameworks.

Version 4.0.0 is only for .NET MAUI with .NET7 and .NET8.

Version 5.0.0 is only for .NET MAUI with .NET8. This is the first version which works without license key.

Your IDE should automatically install the version which can be used by your solution. This uses the `TargetFramework` of your project.

| TargetFramework  |  MR.Gestures version  |
| -------- | -------- |
| net8* | 5.0.0 |
| net7* | 4.0.0 |
| net6* | 3.0.0 for MAUI |
| anything older | 3.0.0 for Xamarin.Forms |

## Structure in this repository

GestureSample.sln is the MAUI solution with the code in GestureSample.
The GestureSample.XF.sln is the original Xamarin.Forms version with the code in the folder GestureSample.XF.

## Getting started with MR.Gestures for MAUI

Install the NuGet package MR.Gestures.

In your MauiProgram.cs add a call to `ConfigureMRGestures`

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMRGestures();

		return builder.Build();
	}

MR.Gestures version 5.0.0 is available for free. In the older versions you needed to pass a license key to `ConfigureMRGestures`.

For more information how to use the library, please see [mrgestures.com](https://www.mrgestures.com/).

## The GestureSample App

The navigation looks similar as the [Xamarin.Forms Control Gallery](https://developer.xamarin.com/samples/xamarin-forms/FormsGallery/). There are separate pages for every supported control. I.e. the ContentPage, all Layouts, Views and Cells.

All pages have one or more elements at the top and a logging section at the bottom. At the top you can use any gestures on the element and in the logging section you see which events have been raised and which parameters were passed to the handlers.

Be aware that some of MAUI´s handlers and the underlying native controls need gesture handling too. Depending on the way how these work, the gesture events are sometimes consumed and not forwarded to MR.Gestures. On other elements if you try to handle a gesture which the element needs to observe, the element does not work anymore. This depends on how Microsoft implemented their handlers and thus also on the platform.

Luckily this applies mainly to the views which are too small that gesture handling on them would make sense anyway.
But also the `ScrollView` (`Pan` must not be observed on iOS)
and the `WebView` are affected.
 
## The Code

The GestureSample project uses basic MVVM, but the examples are so simple that it does not need any models. So there is just a `Views` and `ViewModels` folder.

`App` loads the `MainPage` which displays a menu. In `MainPage.xaml.cs` you can find the implementation of the navigation. For each page it creates a view model from the `ViewModels` folder, binds it to a view from the `Views` folder and navigates to that new page.

Most of the views are written in XAML and the gestures are handled by `Commands` in the view model. This way the code behind of the view can be left empty which is how I think MVVM is done best.

If you write your views in code, then you should have a look at `BoxViewCode`. The view and all the event handlers are created in code in that file. The red box uses simple event handlers (lambda expressions) and the green binds to `Commands` in the view model and sends parameters to these commands.

In `BoxViewXaml` the view is built in XAML but the event handlers for the red box are methods in the code behind in `BoxViewXaml.xaml.cs`. The green box binds to `Commands` in the view model again, this time shown how this is done in XAML.

## Problems with MR.Gestures

If you have any problems, then please read through the whole page [https://www.mrgestures.com](https://www.mrgestures.com).
There is a lot of information there. Especially in the [FAQ](https://www.mrgestures.com/#FAQs) and [Documentation](https://www.mrgestures.com/#Documentation) sections.

If you still have any issues, then you can find the source of MR.Gestures in [this repository](https://github.com/MichaelRumpler/MR.Gestures). If you run into any problems, then please use it as project reference and debug it. If you still cannot resolve it, then open an issue here or in the MR.Gestures repo.

It would also help if you could add a test page to the GestureSample which reproduces the problem. The View goes in `GestureSample/Views/Tests`, if you need a ViewModel then place it in `GestureSample/ViewModels/Tests` and then add a line in `MainPage.xaml.cs` in the [PageConfig Tests section](https://github.com/MichaelRumpler/GestureSample/blob/master/GestureSample/Views/MainPage.xaml.cs#L71). This should show the new test page in the navigation.
