using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace GestureSample.Views
{
	public class DisposeInHandlerPage : ContentPage
	{
		public static Label Log { get; set; }

		public DisposeInHandlerPage()
		{
			var cv = new DisposeInHandlerContentView();

			Log = new Label();
			var syncLbl = new MR.Gestures.Label { Text = "Clear synchronously", HorizontalOptions = LayoutOptions.Start, BackgroundColor = Color.Silver };
#pragma warning disable CS4014
			syncLbl.Tapping += (s, e) => { Log.Text = "Sync clear from outside"; cv.ClearContent(); };
#pragma warning restore CS4014
			var asyncLbl = new MR.Gestures.Label { Text = "Clear asynchronously", HorizontalOptions = LayoutOptions.CenterAndExpand, BackgroundColor = Color.Silver };
			asyncLbl.Tapping += async (s, e) => { Log.Text = "Async clear from outside"; await cv.ClearContent(); };
			var fillLbl = new MR.Gestures.Label { Text = "Set Content", HorizontalOptions = LayoutOptions.End, BackgroundColor = Color.Silver };
			fillLbl.Tapping += (s, e) => { Log.Text = "Set content from outside"; cv.SetContent(); };

			Content = new StackLayout
			{
				Padding = 20,
				Children = {
					cv,
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						Children = {
							syncLbl,
							asyncLbl,
							fillLbl,
						}
					},
					Log,
				}
			};
		}
	}
}
