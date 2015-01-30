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
	public partial class ListViewXaml
	{
		public ListViewXaml()
		{
			InitializeComponent();
		}


		void Cell_Tapping(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Tapping method called " + e.NumberOfTaps + " times");
		}

		void Cell_Tapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Tapped method called " + e.NumberOfTaps + " times");
		}

		void Cell_DoubleTapped(object sender, MR.Gestures.TapEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_DoubleTapped method called " + e.NumberOfTaps + " times");
		}

		void Cell_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_LongPressing method called");
		}

		void Cell_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_LongPressed method called");
		}

		void Cell_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Panning method called");
		}

		void Cell_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Panned method called");
		}

		void Cell_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Swiped method called, swiped " + e.Direction);
		}

		void Cell_Pinching(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Pinching method called");
		}

		void Cell_Pinched(object sender, MR.Gestures.PinchEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Pinched method called");
		}

		void Cell_Rotating(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Rotating method called");
		}

		void Cell_Rotated(object sender, MR.Gestures.RotateEventArgs e)
		{
			((TextOnlyViewModel)BindingContext).AddText("ListViewXaml.Cell_Rotated method called");
		}
	}
}
