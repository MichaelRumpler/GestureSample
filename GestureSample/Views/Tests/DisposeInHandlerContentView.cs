namespace GestureSample.Views.Tests
{
	public class DisposeInHandlerContentView : ContentView
	{
		public DisposeInHandlerContentView()
		{
			BackgroundColor = Colors.Blue;

			SetContent();
		}

		public void SetContent()
		{
			var syncLbl = new MR.Gestures.Label { Text = "Clear synchronously", HorizontalOptions = LayoutOptions.Start, BackgroundColor = Colors.Silver };
#pragma warning disable CS4014
			syncLbl.Tapping += (s, e) => { DisposeInHandlerPage.Log.Text = "Sync clear from inside"; ClearContentAsync(); };
#pragma warning restore CS4014
			var asyncLbl = new MR.Gestures.Label { Text = "Clear asynchronously", HorizontalOptions = LayoutOptions.EndAndExpand, BackgroundColor = Colors.Silver };
			asyncLbl.Tapping += async (s, e) => { DisposeInHandlerPage.Log.Text = "Async clear from inside"; await ClearContentAsync(); };

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

		public Task ClearContentAsync()
		{
			Content = null;
			return Task.CompletedTask;
		}
	}
}
