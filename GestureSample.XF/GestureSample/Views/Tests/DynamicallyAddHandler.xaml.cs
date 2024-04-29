using GestureSample.ViewModels;
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
	public partial class DynamicallyAddHandler : ContentPage
	{
		CustomEventArgsViewModel ViewModel => (CustomEventArgsViewModel)BindingContext;
		bool button2_attached = false;

		public DynamicallyAddHandler ()
		{
			InitializeComponent ();
		}

		private void Button1_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			if(button2_attached)
			{
				ViewModel.AddText("Button 1 down, removing event handler for Button2.Down.");
				Button2.Down -= Button2_Down;
				button2_attached = false;
			}
			else
			{
				ViewModel.AddText("Button 1 down, adding event handler for Button2.Down.");
				Button2.Down += Button2_Down;
				button2_attached = true;
			}
		}

		private void Button2_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			ViewModel.AddText("Button 2 down");
		}
	}
}