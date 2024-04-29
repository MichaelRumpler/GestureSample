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


        void Red_Down(object sender, DownUpEventArgs e) => AddText("BoxViewXaml.Red_Down method called with " + e.TriggeringTouches.Length + " fingers");

        void Red_Up(object sender, DownUpEventArgs e) => AddText("BoxViewXaml.Red_Up method called with " + e.TriggeringTouches.Length + " fingers");

        void Red_Tapping(object sender, TapEventArgs e) => AddText("BoxViewXaml.Red_Tapping method called with " + e.NumberOfTouches + " fingers");

        void Red_Tapped(object sender, TapEventArgs e) => AddText("BoxViewXaml.Red_Tapped method called with " + e.NumberOfTouches + " fingers");

        void Red_DoubleTapped(object sender, TapEventArgs e) => AddText("BoxViewXaml.Red_DoubleTapped method called with " + e.NumberOfTouches + " fingers");

        void Red_LongPressing(object sender, LongPressEventArgs e) => AddText("BoxViewXaml.Red_LongPressing method called with " + e.NumberOfTouches + " fingers");

        void Red_LongPressed(object sender, LongPressEventArgs e) => AddText("BoxViewXaml.Red_LongPressed method called, ViewPosition X/Y/W/H = " + e.ViewPosition.X + "/" + e.ViewPosition.Y + "/" + e.ViewPosition.Width + "/" + e.ViewPosition.Height);

        void Red_Pinching(object sender, PinchEventArgs e) => AddText("BoxViewXaml.Red_Pinching method called");

        void Red_Pinched(object sender, PinchEventArgs e) => AddText("BoxViewXaml.Red_Pinched method called");

        void Red_Panning(object sender, PanEventArgs e) => AddText("BoxViewXaml.Red_Panning method called");

        void Red_Panned(object sender, PanEventArgs e) => AddText("BoxViewXaml.Red_Panned method called");

        void Red_Swiped(object sender, SwipeEventArgs e) => AddText("BoxViewXaml.Red_Swiped method called, swiped " + e.Direction);

        void Red_Rotating(object sender, RotateEventArgs e) => AddText("BoxViewXaml.Red_Rotating method called");

        void Red_Rotated(object sender, RotateEventArgs e) => AddText("BoxViewXaml.Red_Rotated method called");

        void Red_MouseEntered(object sender, MouseEventArgs e) => AddText("BoxViewXaml.Red_MouseEntered method called");

        void Red_MouseMoved(object sender, MouseEventArgs e) => AddText("BoxViewXaml.Red_MouseMoved method called");

        void Red_MouseExited(object sender, MouseEventArgs e) => AddText("BoxViewXaml.Red_MouseExited method called");

        void Red_ScrollWheelChanged(object sender, ScrollWheelEventArgs e) => AddText("BoxViewXaml.Red_ScrollWheelChanged method called");

        void AddText(string text)
		{
			((TextOnlyViewModel)BindingContext).AddText(text);
		}
	}
}
