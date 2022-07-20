using MR.Gestures;

namespace GestureSample.Maui;

public static class MauiProgram
{
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
			//.ConfigureMRGestures("ALZ9-BPVU-XQ35-CEBG-5ZRR-URJQ-ED5U-TSY8-6THP-3GVU-JW8Z-RZGE-CQW6");        // GestureSample
			.ConfigureMRGestures("NDTK-G7T7-QBLH-B48D-CKGP-F2NP-CV2N-B4M3-BXUR-WGQA-PLNK-BZVD-ZVCY");       // GestureSample.Maui

		return builder.Build();
	}
}
