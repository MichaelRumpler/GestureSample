using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace GestureSample.MacOS
{
	[Register("AppDelegate")]
	public class AppDelegate : FormsApplicationDelegate
	{
		NSWindow window;
		public AppDelegate()
		{
			var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

			var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
			window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
			window.Title = "GestureSample";
			window.TitleVisibility = NSWindowTitleVisibility.Hidden;
		}

		public override NSWindow MainWindow
		{
			get { return window; }
		}

		public override void DidFinishLaunching(NSNotification notification)
		{
			Forms.Init();
			MR.Gestures.MacOS.Settings.LicenseKey = "PBXY-DBDU-Y6CB-7V76-923N-G7N8-FU34-5EAS-C6BM-5CUV-C6WU-XLHV-SCLK";           // key for GestureSample.MacOS
			MR.Gestures.MacOS.Settings.TrackpadCoordinateRatio = new Point(3, 4);
			LoadApplication(new App());
			base.DidFinishLaunching(notification);
		}
	}
}
