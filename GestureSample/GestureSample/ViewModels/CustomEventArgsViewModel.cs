using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MR.Gestures;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class CustomEventArgsViewModel : TextOnlyViewModel
	{
		public CustomEventArgsViewModel()
		{
			TappingCommand = new Command<TapEventArgs>(OnTapping);
			TappedCommand = new Command<TapEventArgs>(OnTapped);
			DoubleTappedCommand = new Command<TapEventArgs>(OnDoubleTapped);
			LongPressingCommand = new Command<LongPressEventArgs>(OnLongPressing);
			LongPressedCommand = new Command<LongPressEventArgs>(OnLongPressed);
			PinchingCommand = new Command<PinchEventArgs>(OnPinching);
			PinchedCommand = new Command<PinchEventArgs>(OnPinched);
			PanningCommand = new Command<PanEventArgs>(OnPanning);
			PannedCommand = new Command<PanEventArgs>(OnPanned);
			SwipedCommand = new Command<SwipeEventArgs>(OnSwiped);
			RotatingCommand = new Command<RotateEventArgs>(OnRotating);
			RotatedCommand = new Command<RotateEventArgs>(OnRotated);
		}

		protected virtual void OnTapping(TapEventArgs e)
		{
			AddText(TapInfo("Tapping " + GetElementName(e), e));
		}

		protected virtual void OnTapped(TapEventArgs e)
		{
			AddText(TapInfo("Tapped " + GetElementName(e), e));
		}

		protected virtual void OnDoubleTapped(TapEventArgs e)
		{
			AddText(TapInfo("DoubleTapped " + GetElementName(e), e));
		}

		protected virtual void OnLongPressing(LongPressEventArgs e)
		{
			AddText("Pressing " + GetElementName(e) + " for " + e.Duration + "ms");
		}

		protected virtual void OnLongPressed(LongPressEventArgs e)
		{
			AddText("Pressed " + GetElementName(e) + " for " + e.Duration + "ms");
		}

		protected virtual void OnPinching(PinchEventArgs e)
		{
			AddText("Pinching " + GetElementName(e) + " with " + e.NumberOfTouches + " fingers, scale=" + e.DeltaScale + ", Center =" + e.Center.X + "/" + e.Center.Y);
		}

		protected virtual void OnPinched(PinchEventArgs e)
		{
			AddText("Pinched " + GetElementName(e) + " with " + e.NumberOfTouches + " fingers, scale=" + e.DeltaScale + ", Center =" + e.Center.X + "/" + e.Center.Y);
		}

		protected virtual void OnPanning(PanEventArgs e)
		{
			AddText("Panning " + GetElementName(e) + " with " + e.NumberOfTouches + " fingers, moved by " + e.DeltaDistance.X + "/" + e.DeltaDistance.Y + ", total moved by " + e.TotalDistance.X + "/" + e.TotalDistance.Y);
		}

		protected virtual void OnPanned(PanEventArgs e)
		{
			AddText("Panned " + GetElementName(e) + " with " + e.NumberOfTouches + " fingers, moved by " + e.DeltaDistance.X + "/" + e.DeltaDistance.Y
				+ ", total moved by " + e.TotalDistance.X + "/" + e.TotalDistance.Y
				+ ", velocity " + e.Velocity.X + "/" + e.Velocity.Y);
		}

		protected virtual void OnSwiped(SwipeEventArgs e)
		{
			AddText("Swiped " + e.Direction + " " + GetElementName(e) + " with " + e.NumberOfTouches + " fingers");
		}

		protected virtual void OnRotating(RotateEventArgs e)
		{
			AddText("Rotating " + GetElementName(e) + ", DeltaAngle = " + e.DeltaAngle + ", TotalAngle = " + e.TotalAngle + ", Center =" + e.Center.X + "/" + e.Center.Y);
		}

		protected virtual void OnRotated(RotateEventArgs e)
		{
			AddText("Rotated " + GetElementName(e) + ", DeltaAngle = " + e.DeltaAngle + ", TotalAngle = " + e.TotalAngle + ", Center =" + e.Center.X + "/" + e.Center.Y);
		}

		protected string GetElementName(BaseGestureEventArgs e)
		{
			return e.Sender.GetType().Name + " " + ((Element)e.Sender).Id;
		}

		private string TapInfo(string start, TapEventArgs e)
		{
			StringBuilder sb = new StringBuilder(start);

			sb.AppendFormat(" {0} times with {1} fingers.", e.NumberOfTaps, e.NumberOfTouches);
			sb.AppendFormat(" ViewPosition: {0}/{1}/{2}/{3}, Touches: ", e.ViewPosition.X, e.ViewPosition.Y, e.ViewPosition.Width, e.ViewPosition.Height);
			if (e.Touches != null && e.Touches.Length > 0)
				sb.Append(String.Join(", ", e.Touches.Select(t => t.X + "/" + t.Y)));

			return sb.ToString();
		}
	}
}
