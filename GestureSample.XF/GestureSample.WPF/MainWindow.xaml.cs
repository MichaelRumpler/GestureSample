using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace GestureSample.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : FormsApplicationPage
	{
		public MainWindow()
		{
			InitializeComponent();

			Forms.Init();

			MR.Gestures.WPF.Settings.LicenseKey = "ALZ9-BPVU-XQ35-CEBG-5ZRR-URJQ-ED5U-TSY8-6THP-3GVU-JW8Z-RZGE-CQW6";           // key for GestureSample

			LoadApplication(new GestureSample.App());
		}
	}
}
