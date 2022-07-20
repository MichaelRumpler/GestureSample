## FAQ
{: #FAQs }

### How do I configure my license key?
{: #HowToConfigureTheLicenseKey }

In .NET MAUI you add a call to `ConfigureMRGestures` in your MauiProgram.cs:

~~~~ cs
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMRGestures("your license key");

        return builder.Build();
    }
~~~~

You can try MR.Gestures without license key. Then you just don't pass anything to the `ConfigureMRGestures` method. But you still need to call the method to initialize the handlers.

In Xamarin.Forms you need to set the `LicenseKey` in all platform specific projects.
The best place for it is in each project between the calls to `Xamarin.Forms.Forms.Init(...)` and `LoadApplication(new App())`.

##### Android

In your Android project open `MainActivity.cs` and in the `OnCreate` method after the call to `global::Xamarin.Forms.Forms.Init(...)` add the following line:

~~~~ cs
    MR.Gestures.Android.Settings.LicenseKey = "<your license key>";
~~~~

##### iOS

In the iOS project this has to be done in `AppDelegate.cs`, in the `FinishedLaunching` method. Add this line:

~~~~ cs
    MR.Gestures.iOS.Settings.LicenseKey = "<your license key>";
~~~~

##### Universal Windows Platform

In UWP you add the code to the `OnLaunched` method in `App.xaml.cs`.  
For the .NET Native compilation you also have to tell Xamarin.Forms which assemblies it should scan for custom controls and renderers. Therefore you also have to change the call to `Forms.Init` slightly:

~~~~ cs
    Xamarin.Forms.Forms.Init(e, new[] { typeof(MR.Gestures.ContentPage).Assembly });

    MR.Gestures.UWP.Settings.LicenseKey = "<your license key>";
~~~~

##### WPF

Here the call to `Forms.Init` is in the `MainWindow` constructor in `MainWindow.xaml.cs`.  
Again you should pass the MR.Gestures assembly to `Forms.Init`:

~~~~ cs
    Xamarin.Forms.Forms.Init(e, new[] { typeof(MR.Gestures.ContentPage).Assembly });

    MR.Gestures.WPF.Settings.LicenseKey = "<your license key>";
~~~~

##### MacOS

In the MacOS project, `Forms.Init` is called from `AppDelegate.DidFinishLaunching` and that's also where you set the `LicenseKey`:

~~~~ cs
    MR.Gestures.MacOS.Settings.LicenseKey = "<your license key>";
~~~~

### How do I configure my app name?
{: #HowToConfigureAppName }

The name of the app has to be configured differently on each platform.

##### Android

In the Android project open MainActivity.cs. The `MainActivity` class should have a `Activity` attribute. The `Label` parameter is the app name.

If you configured your activity manually in the Properties / AndroidManifest.xml file, then you need to change the `android:label` attribute there.

##### iOS

Microsoft likes to change where to find the app name for iOS. They move it every couple of versions. So the safest way is to edit the info.plist directly.

In the very beginning of XF (2014) they used to write it to `CFBundleDisplayName`. By the end of 2015 they changed it to `CFBundleName`.
I tried to keep up by reading both values, using `CFBundleName` if it is configured, otherwise `CFBundleDisplayName`.
But in 2021 they suddenly return the Assembly name when no `CFBundleName` is configured, so this stopped working.

So please write the app name to both `CFBundleName` AND `CFBundleDisplayName` in the info.plist.

##### Universal Windows Platform

Here you need to open the Package.appxmanifest file in your platform project. On the "Application" tab change the "Display Name" and on the "Packaging" tab the "Package display name".

##### WPF

The app name is configured in the Properties / AssemblyInfo.cs file. You can use either the `AssemblyTitle` or `AssemblyProduct` attribute. If the former is set, the latter will be ignored.

~~~~ cs
[assembly: AssemblyTitle("<your app name>")]
~~~~

##### MacOS

In Visual Studio for Mac open the MacOS project options and go to General / Main Settings. You need to set the "Name".

### How do I install MR.Gestures?
{: #InstallWithNuget }

You can install it with NuGet. The NuGet package **MR.Gestures** is for both .NET MAUI and Xamarin.Forms.

In Visual Studio for Windows the easiest way is to right click your solution and choose "Manage NuGet Packages for Solution...", then search for **MR.Gestures** and install it to all projects which use MAUI / Xamarin.Forms.

On the Mac you need to install the package for each project separately.

### Is there a trial version available?
{: #TrialVersion }

I already released the GestureSample app with complete source code on [GitHub](https://github.com/MichaelRumpler/GestureSample). That app shows how to use MR.Gestures with each and every available element.

If you want to try it in your own app or the final name of your app has not been decided yet, you can simply call your app _GestureSample_ and use the `LicenseKey` from that app.

### My event handler is called, but some event arg properties are not set.
{: #EmptyEventArgs }

You did not set the `LicenseKey` properly or it does not match your app name. Please check if you set the correct `LicenseKey` in all platform specific projects and that your app name matches the key.

### The mouse events don't work on my iPhone
{: #MouseiPhone }

The iPhone doesn't support mice. You need an iPad with iPadOS 13.0 or later. I use [UIHoverGestureRecognizer](https://developer.apple.com/documentation/uikit/uihovergesturerecognizer) internally and that was only added in iOS 13.0.

### The `Tapped` and `DoubleTapped` events are not raised
{: #NotRaised }

In MR.Gestures 1.* the `LicenseKey` needed to be set properly for these events to be raised. Without `LicenseKey` the `NumberOfTaps` is always 0. `Tapped` was only raised if `NumberOfTaps` was 1 and `DoubleTapped` only if it was 2.

With version 2.0 these events are also raised without `LicenseKey` (although `NumberOfTaps` is still 0).

### What's the license agreement of MR.Gestures?
{: #License }

MR.Gestures is a library to be included in others apps. So Yes, with the license I grant the right to use MR.Gestures in your own app, no matter if it's commercial or free. I wrote MR.Gestures myself and I hold all rights on it.
I do not grant the right to tamper with the library in any way, decompile or resell the whole or only parts of it.

MR.Gestures is licensed per app name. I.e. if your app has the same name on all platforms, you only need one license key. If you have different versions of your app with different names (e.g. different languages, customized for different clients/environments or free and pro), then you need a separate key for each version.

You can use it for as many developers on as many computers for as long as you like.

### I want to swipe with two fingers. How can I handle that gesture?
{: #MultiTouchGestures }

The native standard gesture recognizers only work with the standard amount of fingers. I.e. two fingers for pinch and rotate and one for the others.

I managed to get some gestures on some platforms running with more fingers, but this is not consistent over all platforms.

In the future I may use a different API which is nearer to the wire. But this is a very big change so I'm not sure if I'll do that yet.

### I try to move/zoom/rotate an element, but it jumps on the screen.
{: #Container }

The `Touches` coordinates in the `EventArgs` are always relative to the `View` which handles the event. If you manipulate the `TranslationX`, `TranslationY`, `Scale` or `Rotation(X/Y)` properties during a gesture, then the `Touches` and `Delta*` values cannot be calculated anymore.

So you always have to listen to the events of a container element and manipulate those properties of a child.

So instead of

~~~~ xml
    <mr:Image
        PanningCommand="{Binding PanningCommand}"
        TranslationX="{Binding TranslationX}"
        TranslationY="{Binding TranslationY}" />
~~~~

you should write

~~~~ xml
    <mr:ContentView PanningCommand="{Binding PanningCommand}">
        <Image
            TranslationX="{Binding TranslationX}"
            TranslationY="{Binding TranslationY}" />
    </mr:ContentView>
~~~~

### Event Propagation (aka Event Bubbling)
{: #EventPropagation }

If multiple elements are nested within each other and they all handle the same events, this is called event propagation. Ideally you should be able to tell, which element should handle the event.
When I wrote MR.Gestures, I also wanted to implement this. This is why I added the `Handled` flag to the `EventArgs`.

Unfortunately I couldn't get it working reliably on all platforms. Especially with some of the elements natively handling (and consuming) the events, this proved impossible to implement in a generic way.

Therefore I decided to strive for a solution where all MR.Gestures elements raise the respective events. This way you can decide yourself, which element should handle it.
The easiest way is to start a `Timer` in one handler and do your work unless another handler will be called within a given timeframe.

### The gestures do not work on cells on Windows.
{: #WPCells }

Xamarins Windows renderers (UWP and WPF) for cells do not provide anything I can hook into to add my functionality. So I had to add that functionality to the renderers for `MR.Gestures.ListView` and `MR.Gestures.TableView`.

So if you want to listen to touch gestures on cells, the containing `ListView` or `TableView` must also be used from `MR.Gestures` even if you don't add any gesture listeners on that element itself.

### I get "Could not load file or assembly 'MR.Gestures'" or "Could not load type MR.Gestures...".
{: #CouldNotLoad }

Please check your references. With version 2.0 all projects need a reference to MR.Gestures.
In version 1.* the standard/portable project needs to reference MR.Gestures and the platform specific projects need references to both MR.Gestures and MR.Gestures._platform_.

Every Xamarin.Forms developer should be familiar with the procedure of closing Visual Studio, deleting all bin and obj folders manually and then trying again. I have a .bat file which does that. Cleaning the solution within VS or just recompiling fails to delete old files most of the time.

Please also check, if you set your `Settings.LicenseKey` like it is described [above](#HowToConfigureTheLicenseKey). If this is not set, then the linker may strip it out of your executable.

### What data do you have from me and what do you do with it?
{: #Data }

I don't collect any data from people who are not my customers. I also don't send newsletters, so there's no need to unsubscribe anything.

If you buy a MR.Gestures license, then my distributor will collect all data which they need to process the payment. Once the payment is done, I receive an email with your contacts (technical and payment), app name and issued license key. I do not receive your credit card number or any other sensitive information. I keep this data for future reference in case anybody needs support from me. Also if you send me any emails yourself, I will keep those emails for future reference. You can request the deletion of these emails, but if I can't find your data, then you're no customer of mine and I may be slower with support requests.

There is no cookie banner on this page, because it does not use any cookies at all.
