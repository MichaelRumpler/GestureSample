using System.Diagnostics;

namespace GestureSample.Views.Tests
{
	public partial class ListViewItemTemplatePage : ContentPage
	{
		public ListViewItemTemplatePage()
		{
			InitializeComponent();
		}

		private void Label_Tapped(object sender, MR.Gestures.TapEventArgs e)
		{
			Debug.WriteLine($"mr:Label {((Label)sender).Text} Tapped");
		}

		private void Label_Tapping(object sender, MR.Gestures.TapEventArgs e)
		{
			Debug.WriteLine($"mr:Label {((Label)sender).Text} Tapping");
		}

		private void Label_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			Debug.WriteLine($"mr:Label {((Label)sender).Text} Panning");

		}

		private void ListView_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			Debug.WriteLine("mr:ListView Down");
		}
	}
}