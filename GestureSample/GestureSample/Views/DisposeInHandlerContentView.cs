using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.Views
{
	public class DisposeInHandlerContentView : ContentView
	{
		public DisposeInHandlerContentView()
		{
			BackgroundColor = Color.Blue;

			SetContent();
		}

		public void SetContent()
		{
			var syncLbl = new MR.Gestures.Label { Text = "Clear synchronously", HorizontalOptions = LayoutOptions.Start, BackgroundColor = Color.Silver };
#pragma warning disable CS4014
			syncLbl.Tapping += (s, e) => { DisposeInHandlerPage.Log.Text = "Sync clear from inside"; ClearContent(); };
#pragma warning restore CS4014
			var asyncLbl = new MR.Gestures.Label { Text = "Clear asynchronously", HorizontalOptions = LayoutOptions.EndAndExpand, BackgroundColor = Color.Silver };
			asyncLbl.Tapping += async (s, e) => { DisposeInHandlerPage.Log.Text = "Async clear from inside"; await ClearContent(); };

			Content = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Padding = 20,
				Children =
				{
					syncLbl,
					asyncLbl,
				}
			};
		}

#pragma warning disable CS1998
		public async Task ClearContent()
		{
			Content = null;
		}
#pragma warning restore CS1998
	}
}
