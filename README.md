# GestureSample #

This is the sample project for **MR.Gestures**. It shows all the touch gesture handling possible with that library and Xamarin.Forms.

To find out more about MR.Gestures visit [http://www.mrgestures.com](http://www.mrgestures.com).

## The App ##

The navigation looks similar as the [Xamarin.Forms Control Gallery](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/controls/). There are separate pages for every supported control. I.e. the ContentPage, all Layouts, Views and Cells. The other pages just add functionality to the ContentPage thus gesture handling on them is not needed.

All pages have one or more elements at the top and a logging section at the bottom. At the top you can use any gestures on the element and in the logging section you see which events have been raised and which parameters were passed to the handlers.

Be aware that some of Xamarins renderers need gesture handling too. Depending on the way how they implemented it, the gesture events are sometimes not forwarded to MR.Gestures. On other elements if you try to handle a gesture which the element needs to observe, the element does not work anymore. This depends on how Xamarin implemented their renderers and thus also on the platform.
Luckily this applies mainly to the views which are too small that gesture handling on them would make sense anyway. But also the ScrollView (Pan must not be observed) and the WebView (all events are contained within it) are affected.
 
## The Code ##

The GestureSample project uses basic MVVM only that the examples are so simple that it does not need any models. So there is just a `Views` and `ViewModels` folder.

`App` loads the `MainPage` which displays a menu. In `MainPage.xaml.cs` you can find the implementation of the navigation. For each page it creates a view model from the `ViewModels` folder, binds it to a view from the `Views` folder and navigates to that new page.

Most of the views are written in XAML and the gestures are handled by `Commands` in the view model. This way the code behind of the view can be left empty which is how I think MVVM is done best.

If you write your views in code, then you should have a look at `BoxViewCode`. There the view and all the event handlers are created in code. The red box uses simple event handlers (lambda expressions) and the green binds to `Commands` in the view model and sends parameters to these commands.

In `BoxViewXaml` the view is built in XAML but the event handlers for the red box are methods in the code behind in `BoxViewXaml.xaml.cs`. The green box binds to `Commands` in the view model again, this time shown how this is done in XAML.

The platform dependent projects have been created by the standard "Blank App (Xamarin.Forms Portable)" template. I only added the `LicenseKey` for the GestureSample and set the app name. There were no other changes at all.  

## Contact ##

If you have any questions, suggestions, you find bugs or whatever, you can send an email to mrgestures@mrumpler.at or a tweet [#MRGestures](https://twitter.com/MRGestures).
