using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureSample.Views.Tests
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NestedControls : ContentPage
	{
		public NestedControls()
		{
			InitializeComponent();
		}

		private async void MrButton_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			await DisplayAlert("Coordinates", $"{e.ViewPosition.X:F}/{e.ViewPosition.Y:F}/{e.ViewPosition.Width:F}/{e.ViewPosition.Height:F}", "OK");
		}

		void Button_OnClicked(object sender, EventArgs e)
		{
			var lbl = new Label() { Text = "A new item!" };
			StackFirst.Children.Add(lbl);

			var entry = new Entry { Placeholder = "Enter something" };
			StackFirst.Children.Add(entry);

			var box = new BoxView { HeightRequest = 60, BackgroundColor = Color.Blue };
			StackFirst.Children.Add(box);
		}
	}
}