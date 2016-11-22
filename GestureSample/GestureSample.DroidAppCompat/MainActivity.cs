using Android.App;
using Android.Content.PM;
using Android.OS;

namespace GestureSample.DroidAppCompat
{
	[Activity(Label = "GestureSample", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			ToolbarResource = Resource.Layout.toolbar;
			TabLayoutResource = Resource.Layout.tabs;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			MR.Gestures.Android.Settings.LicenseKey = "ALZ9-BPVU-XQ35-CEBG-5ZRR-URJQ-ED5U-TSY8-6THP-3GVU-JW8Z-RZGE-CQW6";           // key for GestureSample

			LoadApplication(new App());
		}
	}
}

