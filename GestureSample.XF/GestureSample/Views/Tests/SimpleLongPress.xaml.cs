using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GestureSample.Views.Tests
{
	public partial class SimpleLongPress : ContentPage
	{
		public SimpleLongPress()
		{
			InitializeComponent();
			box.LongPressing += Box_LongPressing;
		}

		private void Box_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			DisplayAlert("Example", e.Duration.ToString(), "OK");       // in LongPressing Duration is always 0, it only has a value in LongPressed
		}
	}
}
