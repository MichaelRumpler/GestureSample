using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureSample.Views.Tests
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InvisibleButtonPage : ContentPage
	{
		public InvisibleButtonPage()
		{
			InitializeComponent();
		}

		private void ContainerVisibility_Toggled(object sender, ToggledEventArgs e)
		{
			Container.IsVisible = e.Value;
		}

		private void ButtonVisibility_Toggled(object sender, ToggledEventArgs e)
		{
			theButton.IsVisible = e.Value;
		}

		private void TheButton_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			LogCall();
		}

		private void TheButton_Up(object sender, MR.Gestures.DownUpEventArgs e)
		{
			LogCall();
		}

		private void TheButton_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			LogCall();
		}

		private void TheButton_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			LogCall();
		}

		private void TheButton_Clicked(object sender, EventArgs e)
		{
			LogCall();
		}

		private void LogCall([CallerMemberName] string caller = "")
		{
			Log.Text = caller + "\n" + Log.Text;
			Debug.WriteLine(caller);
		}
	}
}