namespace GestureSample.Maui.Views.Tests;


// This does the same as the repro project from https://github.com/MichaelRumpler/GestureSample/issues/43
// Just see if those warnings appear here too. I can debug it to see if everything is disposed what I can dispose.

public class ObserverWarningPage : ContentPage
{
    public ObserverWarningPage()
    {
        Grid g;
		Content = new ScrollView()
		{
			Orientation = ScrollOrientation.Vertical,
			Content = g = new Grid()
		};

		for (int i = 0; i < 10; i++)
		{
			g.Children.Add(
				new MR.Gestures.Border()
				{
					Content = new Label() {
						Text = "Test " + i,
						VerticalOptions = LayoutOptions.Fill,
						HorizontalOptions = LayoutOptions.Fill,
					},
					Margin = new Thickness(0, 20 * i, 0, 0),
				}
			);
		}
	}
}
