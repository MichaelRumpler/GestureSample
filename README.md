# GestureSample

This is the sample project for **MR.Gestures**. It shows all the touch gesture handling possible with that library and Xamarin.Forms.

To find out more about MR.Gestures visit [https://www.mrgestures.com](https://www.mrgestures.com).

## Status of MR.Gestures for .NET MAUI

I waited for a release candidate of MAUI before I started working on it. Now that this is finally available I hope that they won't make big changes anymore and my work will not be lost.

I implemented MAUI handlers for most controls, but I didn't test them completely. From what I saw, there are still a lot of bugs in MAUI - see the list below. I converted the GestureSample to MAUI here in the same repository. Just open GestureSample.MAUI.sln instead. In the XF version I used `RelativeLayout` a lot, but this is not yet built into MAUI. So I had to change the layouts to be `Grid` based. Everything else should have stayed the same. Yet, when you compare the GestureSample and GestureSample.MAUI side by side, you easily see what's still missing in MAUI. I deliberately did not try to work around those issues so that the differences can easily be seen.

### Getting started with MR.Gestures for MAUI

Install the NuGet package MR.Gestures with version 3.0.0-pre1. This version includes both MAUI and Xamarin.Forms. For Xamarin.Forms there are no changes to version 2.2.1.

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
			.ConfigureMRGestures(licenseKey);

		return builder.Build();
	}

The license key will be ignored for now. You can use it with all app names. But it is fixed to MAUI RC2. It will not work on newer versions. I will open it to other MAUI versions when I added the license check back in.

Everything else remains at it was in Xamarin.Forms. The docs are still on [mrgestures.com](https://www.mrgestures.com/).

### Current status of all the elements

Due to [this bug](https://github.com/dotnet/maui/issues/6674) there is no MacCatalyst version yet.

| Element  |  Status  |
| -------- | -------- |
| AbsoluteLayout | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| ActivityIndicator | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| BoxView | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Button | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| ContentPage | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| ContentView | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| DatePicker | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Editor | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Entry | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| FlexLayout | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Grid | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Image | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Label | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Picker | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| ProgressBar | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| ScrollView | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| SearchBar | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Slider | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| StackLayout | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Stepper | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Switch | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| TimePicker | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| WebView | Handlers created, Android, iOS and WinUI raise events, EventArgs not completely tested yet |
| Border | Handlers created, needs sample to test |
| CheckBox | Handlers created, needs sample to test |
| GraphicsView | Handlers created, needs sample to test |
| HorizontalStackLayout | Handlers created, needs sample to test |
| IndicatorView | Handlers created, needs sample to test |
| RadioButton | Handlers created, needs sample to test |
| VerticalStackLayout | Handlers created, needs sample to test |
| CarouselView | has not been in MR.Gestures for XF, needs more testing |
| CollectionView | has not been in MR.Gestures for XF, needs more testing |
| Frame | there's only a Compatibility Renderer in MAUI which is likely to change before GA |
| ListView | there's only a Compatibility Renderer in MAUI which is likely to change before GA |
| TableView | there's only a Compatibility Renderer in MAUI which is likely to change before GA |
| all Cells | there's only a Compatibility Renderer in MAUI which is likely to change before GA |
| ImageButton | ImageButtonHandler.Standard.cs is sealed in MAUI |
| RelativeLayout | not implemented in MAUI yet |
| TabbedPage | not done in MR.Gestures yet |

### Problems in MAUI RC2

Here is a list of problems I stumbled upon during my work on MR.Gestures and the GestureSample. I did not open an issue for everything yet. First I want to finish my work on MR.Gestures. When I'm done with that, I'll link to the issue.

- [MacCatalyst does not compile on Windows](https://github.com/dotnet/maui/issues/6674)
- Platforms folders and files with e.g. .Android.cs extensions are not limited to the respective platform by default
- When copying a file, VS removes it sometimes from Compile in the .csproj
- Deploy to iOS sometimes does not work, F5 starts debugging the old version of the app
- RelativeLayout is still not implemented in MAUI
- no handlers yet for Frame, ListView and TableView
- Label in iOS is only one line high
- On Windows a Label in a Grid is only as high as the content of the Label. It does not span the whole Grid cell.
- A FlexLayout in a StackLayout seems to have 0 height. A following Label is rendered over the FlexLayout on Windows.
- Handlers are not cleaned up - there is a method DisconnectHandler, but [it is never called](https://github.com/dotnet/maui/issues/3604).

## The App

The navigation looks similar as the [Xamarin.Forms Control Gallery](https://developer.xamarin.com/samples/xamarin-forms/FormsGallery/). There are separate pages for every supported control. I.e. the ContentPage, all Layouts, Views and Cells.

All pages have one or more elements at the top and a logging section at the bottom. At the top you can use any gestures on the element and in the logging section you see which events have been raised and which parameters were passed to the handlers.

Be aware that some of Xamarins renderers and the underlying native controls need gesture handling too.
Depending on the way how these work, the gesture events are sometimes consumed and not forwarded to MR.Gestures.
On other elements if you try to handle a gesture which the element needs to observe,
the element does not work anymore.
This depends on how Xamarin implemented their renderers and thus also on the platform.

Luckily this applies mainly to the views which are too small that gesture handling on them would make sense anyway.
But also the `ScrollView` (`Pan` must not be observed on iOS)
and the `WebView` (all events are consumed by it) are affected.
 
## The Code

The GestureSample project uses basic MVVM, but the examples are so simple that it does not need any models. So there is just a `Views` and `ViewModels` folder.

`App` loads the `MainPage` which displays a menu. In `MainPage.xaml.cs` you can find the implementation of the navigation. For each page it creates a view model from the `ViewModels` folder, binds it to a view from the `Views` folder and navigates to that new page.

Most of the views are written in XAML and the gestures are handled by `Commands` in the view model. This way the code behind of the view can be left empty which is how I think MVVM is done best.

If you write your views in code, then you should have a look at `BoxViewCode`. The view and all the event handlers are created in code in that file. The red box uses simple event handlers (lambda expressions) and the green binds to `Commands` in the view model and sends parameters to these commands.

In `BoxViewXaml` the view is built in XAML but the event handlers for the red box are methods in the code behind in `BoxViewXaml.xaml.cs`. The green box binds to `Commands` in the view model again, this time shown how this is done in XAML.

The platform dependent projects have been created by the standard "Blank App (Xamarin.Forms Portable)" template. I only added the `LicenseKey` for the GestureSample and set the app name. There were no other changes at all.  

## Contact

If you have any questions, then please read through the whole page [https://www.mrgestures.com](https://www.mrgestures.com).
There is a lot of information there. Especially in the [FAQ](https://www.mrgestures.com/#FAQs) and
[Documentation](https://www.mrgestures.com/#Documentation) sections.

If you still have any issues, then you can file them [here](https://github.com/MichaelRumpler/GestureSample/issues),
send an email to mrgestures@mrumpler.at or a tweet [#MRGestures](https://twitter.com/MRGestures).
