# GestureSample #

This is the sample project for **MR.Gestures**. It shows all the touch gesture handling possible with that library and Xamarin.Forms.

To find out more about MR.Gestures visit [https://www.mrgestures.com](https://www.mrgestures.com).

## The App ##

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
 
## The Code ##

The GestureSample project uses basic MVVM, but the examples are so simple that it does not need any models. So there is just a `Views` and `ViewModels` folder.

`App` loads the `MainPage` which displays a menu. In `MainPage.xaml.cs` you can find the implementation of the navigation. For each page it creates a view model from the `ViewModels` folder, binds it to a view from the `Views` folder and navigates to that new page.

Most of the views are written in XAML and the gestures are handled by `Commands` in the view model. This way the code behind of the view can be left empty which is how I think MVVM is done best.

If you write your views in code, then you should have a look at `BoxViewCode`. The view and all the event handlers are created in code in that file. The red box uses simple event handlers (lambda expressions) and the green binds to `Commands` in the view model and sends parameters to these commands.

In `BoxViewXaml` the view is built in XAML but the event handlers for the red box are methods in the code behind in `BoxViewXaml.xaml.cs`. The green box binds to `Commands` in the view model again, this time shown how this is done in XAML.

The platform dependent projects have been created by the standard "Blank App (Xamarin.Forms Portable)" template. I only added the `LicenseKey` for the GestureSample and set the app name. There were no other changes at all.  

## Contact ##

If you have any questions, then please read through the whole page [https://www.mrgestures.com](https://www.mrgestures.com).
There is a lot of information there. Especially in the [FAQ](https://www.mrgestures.com/#FAQs) and
[Documentation](https://www.mrgestures.com/#Documentation) sections.

If you still have any issues, then you can file them [here](https://github.com/MichaelRumpler/GestureSample/issues),
send an email to mrgestures@mrumpler.at or a tweet [#MRGestures](https://twitter.com/MRGestures).
I also have a dedicated post in the [Xamarin.Forms forum](https://forums.xamarin.com/discussion/32956/mr-gestures-handles-all-touch-gestures), but that got too big and it's not easy to find anything there.