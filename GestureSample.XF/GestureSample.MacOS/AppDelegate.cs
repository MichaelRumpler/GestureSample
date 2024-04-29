using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace GestureSample.MacOS
{
	[Register("AppDelegate")]
	public class AppDelegate : FormsApplicationDelegate
	{
		NSWindow _window;
		public AppDelegate()
		{
			var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

			var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
			_window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
			_window.Title = "GestureSample on Mac!";
			_window.TitleVisibility = NSWindowTitleVisibility.Hidden;
		}

		public override NSWindow MainWindow
		{
			get { return _window; }
		}

		public override void DidFinishLaunching(NSNotification notification)
		{
			Forms.Init();
			MR.Gestures.MacOS.Settings.LicenseKey = "PBXY-DBDU-Y6CB-7V76-923N-G7N8-FU34-5EAS-C6BM-5CUV-C6WU-XLHV-SCLK";           // key for GestureSample.MacOS
			LoadApplication(new App());
			base.DidFinishLaunching(notification);
		}
	}
}
