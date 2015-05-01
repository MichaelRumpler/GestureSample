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
	public partial class BoxViewXaml
	{
		public BoxViewXaml()
		{
			InitializeComponent();
		}


		void Red_Down(object sender, DownUpEventArgs e)
		{
			AddText("BoxViewXaml.Red_Down method called with " + e.TriggeringTouches.Length + " fingers");
		}

		void Red_Up(object sender, DownUpEventArgs e)
		{
			AddText("BoxViewXaml.Red_Up method called with " + e.TriggeringTouches.Length + " fingers");
		}

		void Red_Tapping(object sender, TapEventArgs e)
		{
			AddText("BoxViewXaml.Red_Tapping method called with " + e.NumberOfTouches + " fingers");
		}

		void Red_Tapped(object sender, TapEventArgs e)
		{
			AddText("BoxViewXaml.Red_Tapped method called with " + e.NumberOfTouches + " fingers");
		}

		void Red_DoubleTapped(object sender, TapEventArgs e)
		{
			AddText("BoxViewXaml.Red_DoubleTapped method called with " + e.NumberOfTouches + " fingers");
		}

		void Red_LongPressing(object sender, MR.Gestures.LongPressEventArgs e)
		{
			AddText("BoxViewXaml.Red_LongPressing method called with " + e.NumberOfTouches + " fingers");
		}

		void Red_LongPressed(object sender, MR.Gestures.LongPressEventArgs e)
		{
			AddText("BoxViewXaml.Red_LongPressed method called, ViewPosition X/Y/W/H = " + e.ViewPosition.X + "/" + e.ViewPosition.Y + "/" + e.ViewPosition.Width + "/" + e.ViewPosition.Height);
		}

		void Red_Pinching(object sender, MR.Gestures.PinchEventArgs e)
		{
			AddText("BoxViewXaml.Red_Pinching method called");
		}

		void Red_Pinched(object sender, MR.Gestures.PinchEventArgs e)
		{
			AddText("BoxViewXaml.Red_Pinched method called");
		}

		void Red_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			AddText("BoxViewXaml.Red_Panning method called");
		}

		void Red_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			AddText("BoxViewXaml.Red_Panned method called");
		}

		void Red_Swiped(object sender, MR.Gestures.SwipeEventArgs e)
		{
			AddText("BoxViewXaml.Red_Swiped method called, swiped " + e.Direction);
		}

		void Red_Rotating(object sender, MR.Gestures.RotateEventArgs e)
		{
			AddText("BoxViewXaml.Red_Rotating method called");
		}

		void Red_Rotated(object sender, MR.Gestures.RotateEventArgs e)
		{
			AddText("BoxViewXaml.Red_Rotated method called");
		}

		void AddText(string text)
		{
			((TextOnlyViewModel)BindingContext).AddText(text);
		}
	}
}
