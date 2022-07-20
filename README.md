# GestureSample

This is the sample project for **MR.Gestures**. It shows all the touch gesture handling possible with that library and Xamarin.Forms.

To find out more about MR.Gestures visit [https://www.mrgestures.com](https://www.mrgestures.com).

## Status of MR.Gestures for .NET MAUI

There are still many bugs in .NET MAUI, but at least the API should be stable with the GA version.

I converted the GestureSample to MAUI here. Both are in the same repository. Just open GestureSample.MAUI.sln instead. In the XF version I used `RelativeLayout` a lot, but this is not yet built into MAUI. So I had to change the layouts to be `Grid` based. Everything else should have stayed the same. Yet, when you compare the GestureSample and GestureSample.MAUI side by side, you easily see what's still missing in MAUI. I only worked around the most important issues so that the app can be used. I hope that the other issues get fixed by Microsoft.

### Getting started with MR.Gestures for MAUI

Install the NuGet package MR.Gestures with version 3 or higher. This version includes both MAUI and Xamarin.Forms.

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

You can also omit the `licenseKey` to test MR.Gestures without a license. This should behave the same as MR.Gestures in Xamarin.Forms without setting `Settings.LicenseKey`.

Everything else remains at it was in Xamarin.Forms. The docs are still on [mrgestures.com](https://www.mrgestures.com/).

### Current status of all the elements

I finally managed to compile a MacCatalyst version. This was added in MR.Gestures 3.0.0.

| Element  |  Status  |
| -------- | -------- |
| AbsoluteLayout | Handlers created, events are raised, EventArgs not completely tested yet |
| ActivityIndicator | Handlers created, events are raised, EventArgs not completely tested yet |
| BoxView | Handlers created, events are raised, EventArgs not completely tested yet |
| Button | Handlers created, events are raised, EventArgs not completely tested yet |
| ContentPage | Handlers created, events are raised, EventArgs not completely tested yet |
| ContentView | Handlers created, events are raised, EventArgs not completely tested yet |
| DatePicker | Handlers created, events are raised, EventArgs not completely tested yet |
| Editor | Handlers created, events are raised, EventArgs not completely tested yet |
| Entry | Handlers created, events are raised, EventArgs not completely tested yet |
| FlexLayout | Handlers created, events are raised, EventArgs not completely tested yet |
| Grid | Handlers created, events are raised, EventArgs not completely tested yet |
| Image | Handlers created, events are raised, EventArgs not completely tested yet |
| ImageButton | Handlers created, events are raised, EventArgs not completely tested yet |
| Label | Handlers created, events are raised, EventArgs not completely tested yet |
| Picker | Handlers created, events are raised, EventArgs not completely tested yet |
| ProgressBar | Handlers created, events are raised, EventArgs not completely tested yet |
| ScrollView | Handlers created, events are raised, EventArgs not completely tested yet |
| SearchBar | Handlers created, events are raised, EventArgs not completely tested yet |
| Slider | Handlers created, events are raised, EventArgs not completely tested yet |
| StackLayout | Handlers created, events are raised, EventArgs not completely tested yet |
| Stepper | Handlers created, events are raised, EventArgs not completely tested yet |
| Switch | Handlers created, events are raised, EventArgs not completely tested yet |
| TimePicker | Handlers created, events are raised, EventArgs not completely tested yet |
| WebView | Handlers created, events are raised, EventArgs not completely tested yet |
| Frame | inherited from MAUI's Compatibility renderer, events are raised |
| ListView | inherited from MAUI's Compatibility renderer, events are raised |
| TableView | inherited from MAUI's Compatibility renderer, events are raised |
| all Cells | inherited from MAUI's Compatibility renderer, events are raised |
| Border | Handlers created, needs sample to test |
| CheckBox | Handlers created, needs sample to test |
| GraphicsView | Handlers created, needs sample to test |
| HorizontalStackLayout | Handlers created, needs sample to test |
| IndicatorView | Handlers created, needs sample to test |
| RadioButton | Handlers created, needs sample to test |
| VerticalStackLayout | Handlers created, needs sample to test |
| CarouselView | has not been in MR.Gestures for XF, needs more testing |
| CollectionView | has not been in MR.Gestures for XF, needs more testing |
| RelativeLayout | not implemented in MAUI yet |
| TabbedPage | not done in MR.Gestures yet |

### Problems in MAUI GA

Here is a list of problems I stumbled upon during my work on MR.Gestures and the GestureSample. I did not open an issue for everything yet.

- Android: ListView: handling gestures on a Android.Widget.ListView prevents it from working. This worked in XF.
- Windows: NavigationPage sometimes crashes when navigating
- MacCatalyst: NavigationPage: the back button is not easily clickable
- Android: dark theme colors are not applied in a TextCell, Style for TextCell doesn't work

### Problems in older MAUI versions

These have either been fixed or I found a workaround.

- [MacCatalyst does not compile on Windows](https://github.com/dotnet/maui/issues/6674) - found a workaround
- Platforms folders and files with e.g. .Android.cs extensions are not limited to the respective platform by default - fixed in GA
- When copying a file, VS removes it sometimes from Compile in the .csproj - inconvenience
- Deploy to iOS sometimes does not work, F5 starts debugging the old version of the app - did not occur after GA
- RelativeLayout is still not implemented in MAUI - changed to Grid
- no handlers yet for Frame, ListView and TableView - used Compatibility renderers instead
- Label in iOS and MacCatalyst is only one line high - fixed
- On Windows a Label in a Grid is only as high as the content of the Label. It does not span the whole Grid cell - used ContainerView instead of PlatformView
- A FlexLayout in a StackLayout seems to have 0 height. A following Label is rendered over the FlexLayout on Windows - fixed
- Handlers are not cleaned up - there is a method DisconnectHandler, but [it is never called](https://github.com/dotnet/maui/issues/3604) - used other events to clean up

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
send an email to mrgestures@mrumpler.at or a tweet [@MRGestures](https://twitter.com/MRGestures).
