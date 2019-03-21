## FAQ
{: #FAQs }

### How do I configure my license key?
{: #HowToConfigureTheLicenseKey }

As your app name can be different on each platform, the license key must be configured in all platform specific projects.
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
    var otherAssemblies = new[] {
        typeof(MR.Gestures.ContentPage).GetTypeInfo().Assembly,
        typeof(MR.Gestures.UWP.Renderers.PageRenderer).GetTypeInfo().Assembly,      // only for MR.Gestures 1.*
    };
    Xamarin.Forms.Forms.Init(e, otherAssemblies);

    MR.Gestures.UWP.Settings.LicenseKey = "<your license key>";
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

In Visual Studio open the iOS project properties and go to the "iOS Application" tab. There you'll find the "Application name". If you don't have a "iOS application" tab, then open the info.plist. The app name is in the CFBundleDisplayName or CFBundleName setting (should be the same if both are present).

In Xamarin Studio the "Application name" is the very first textbox when you open the info.plist file.

##### Universal Windows Platform

Here you need to open the Package.appxmanifest file in your platform project. On the "Application" tab change the "Display Name" and on the "Packaging" tab the "Package display name".

##### MacOS

In Visual Studio for Mac open the MacOS project options and go to General / Main Settings. You need to set the "Name".

### How do I install MR.Gestures?
{: #InstallWithNuget }

You can install it with NuGet. In Visual Studio for Windows the easiest way is to right click your solution and choose "Manage NuGet Packages for Solution...", then search for MR.Gestures and install it to all projects which use XF.

On the Mac you need to install the package for each project separately.

### Is there a trial version available?
{: #TrialVersion }

I already released the GestureSample app with complete source code on [GitHub](https://github.com/MichaelRumpler/GestureSample). That app shows how to use MR.Gestures with each and every available element.

If you want to try it in your own app or the final name of your app has not been decided yet, you can simply call your app _GestureSample_ and use the LicenseKey from that app.

### My event handler is called, but some event arg properties are not set.
{: #EmptyEventArgs }

You did not set the `LicenseKey` properly or it does not match your app name. Please check if you set the correct `LicenseKey` in all platform specific projects and that your app name matches the key.

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
