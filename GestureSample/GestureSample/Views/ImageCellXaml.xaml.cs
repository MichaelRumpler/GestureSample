using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestureSample.ViewModels;
using MR.Gestures;

namespace GestureSample.Views
{
	public partial class ImageCellXaml
	{
		public ImageCellXaml()
		{
			InitializeComponent();
		}


		void Cell_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Down method called on cell '" + ((ImageCell)sender).Text + "' with " + e.TriggeringTouches.Length + " fingers");
		}

		void Cell_Up(object sender, MR.Gestures.DownUpEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Up method called on cell '" + ((ImageCell)sender).Text + "' with " + e.TriggeringTouches.Length + " fingers");
		}

		void Cell_Tapping(object sender, MR.Gestures.TapEventArgs e)
		{
			var vm = (ListOfObjectsViewModel)BindingContext;
			var item = (GestureSample.ViewModels.ListOfObjectsViewModel.TextAndImage)((ImageCell)sender).BindingContext;
			vm.Item = item;
			vm.AddText("ImageCellXaml.Cell_Tapping method called on cell '" + item.Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_Tapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Tapped method called on cell '" + ((ImageCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_DoubleTapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_DoubleTapped method called on cell '" + ((ImageCell)sender).Text + "' " + e.NumberOfTaps + " times");
		}

		void Cell_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_LongPressing method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_LongPressed method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Panning method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Panned method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Swiped method called on cell '" + ((ImageCell)sender).Text + "', swiped " + e.Direction);
		}

		void Cell_Pinching(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Pinching method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_Pinched(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Pinched method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_Rotating(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Rotating method called on cell '" + ((ImageCell)sender).Text + "'");
		}

		void Cell_Rotated(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ImageCellXaml.Cell_Rotated method called on cell '" + ((ImageCell)sender).Text + "'");
		}
	}
}
