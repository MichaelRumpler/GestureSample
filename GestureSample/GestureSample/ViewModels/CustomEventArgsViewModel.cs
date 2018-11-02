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
			DownCommand = new Command<DownUpEventArgs>(OnDown);
			UpCommand = new Command<DownUpEventArgs>(OnUp);
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

		protected virtual void OnDown(DownUpEventArgs e)
		{
			AddText(DownUpInfo("Down", e));
		}

		protected virtual void OnUp(DownUpEventArgs e)
		{
			AddText(DownUpInfo("Up", e));
		}

		protected virtual void OnTapping(TapEventArgs e)
		{
			AddText(TapInfo("Tapping", e));
		}

		protected virtual void OnTapped(TapEventArgs e)
		{
			AddText(TapInfo("Tapped", e));
		}

		protected virtual void OnDoubleTapped(TapEventArgs e)
		{
			AddText(TapInfo("DoubleTapped", e));
		}

		protected virtual void OnLongPressing(LongPressEventArgs e)
		{
			AddText(LongPressInfo("Pressing", e));
		}

		protected virtual void OnLongPressed(LongPressEventArgs e)
		{
			AddText(LongPressInfo("Pressed", e));
		}

		protected virtual void OnPinching(PinchEventArgs e)
		{
			AddText(PinchInfo("Pinching", e));
		}

		protected virtual void OnPinched(PinchEventArgs e)
		{
			AddText(PinchInfo("Pinched", e));
		}

		protected virtual void OnPanning(PanEventArgs e)
		{
			AddText(PanInfo("Panning", e));
		}

		protected virtual void OnPanned(PanEventArgs e)
		{
			AddText(PanInfo("Panned", e));
		}

		protected virtual void OnSwiped(SwipeEventArgs e)
		{
			AddText(PanInfo("Swiped " + e.Direction, e));
		}

		protected virtual void OnRotating(RotateEventArgs e)
		{
			AddText(RotateInfo("Rotating", e));
		}

		protected virtual void OnRotated(RotateEventArgs e)
		{
			AddText(RotateInfo("Rotated", e));
		}

		private string TapInfo(string eventName, TapEventArgs e)
		{
			StringBuilder sb = new StringBuilder(eventName);

			sb.Append($" {GetElementName(e)} {e.NumberOfTaps} times with {e.NumberOfTouches} fingers.");
			sb.Append($" ViewPosition: {e.ViewPosition.X:F}/{e.ViewPosition.Y:F}/{e.ViewPosition.Width:F}/{e.ViewPosition.Height:F}");
			AddTouches(sb, e);
			if (e.Cancelled)
				sb.Append(", Cancelled=true");

			return sb.ToString();
		}

		private string LongPressInfo(string eventName, LongPressEventArgs e)
		{
			StringBuilder sb = new StringBuilder(eventName);

			sb.Append($" {GetElementName(e)} for {e.Duration}ms with {e.NumberOfTouches} fingers");
			AddTouches(sb, e);
			if (e.Cancelled)
				sb.Append(", Cancelled=true");

			return sb.ToString();
		}

		private string DownUpInfo(string eventName, DownUpEventArgs e)
		{
			StringBuilder sb = new StringBuilder(eventName);

			if(e.TriggeringTouches != null)
				sb.Append($" on {GetElementName(e)} with finger(s) {String.Join(", ", e.TriggeringTouches.Select(n => $"#{n}"))}.");
			sb.Append($" ViewPosition: {e.ViewPosition.X:F}/{e.ViewPosition.Y:F}/{e.ViewPosition.Width:F}/{e.ViewPosition.Height:F}");
			AddTouches(sb, e);
			if (e.Cancelled)
				sb.Append(", Cancelled=true");

			return sb.ToString();
		}

		private string PanInfo(string eventName, PanEventArgs e)
		{
			StringBuilder sb = new StringBuilder(eventName);

			sb.Append($" {GetElementName(e)} with {e.NumberOfTouches} fingers");
			sb.Append($", DeltaDistance = {e.DeltaDistance.X:F}/{e.DeltaDistance.Y:F}");
			sb.Append($", TotalDistance = {e.TotalDistance.X:F}/{e.TotalDistance.Y:F}");
			sb.Append($", Velocity = {e.Velocity.X:F}/{e.Velocity.Y:F}");
			AddTouches(sb, e);
			if (e.Cancelled)
				sb.Append(", Cancelled=true");

			return sb.ToString();
		}

		private string RotateInfo(string eventName, RotateEventArgs e)
		{
			StringBuilder sb = new StringBuilder(eventName);

			sb.Append($" {GetElementName(e)} with {e.NumberOfTouches} fingers");
			sb.Append($", DeltaAngle = {e.DeltaAngle:F}");
			sb.Append($", TotalAngle = {e.TotalAngle:F}");
			sb.Append($", Center =  {e.Center.X:F}/{e.Center.Y:F}");
			AddTouches(sb, e);
			if (e.Cancelled)
				sb.Append(", Cancelled=true");

			return sb.ToString();
		}

		private string PinchInfo(string eventName, PinchEventArgs e)
		{
			StringBuilder sb = new StringBuilder(eventName);

			sb.Append($" {GetElementName(e)} with {e.NumberOfTouches} fingers\n");
			sb.Append($"  DeltaScale = {e.DeltaScale:F}");
			sb.Append($", DeltaScaleX = {e.DeltaScaleX:F}");
			sb.Append($", DeltaScaleY = {e.DeltaScaleY:F}\n");
			sb.Append($"  TotalScale = {e.TotalScale:F}");
			sb.Append($", TotalScaleX = {e.TotalScaleX:F}");
			sb.Append($", TotalScaleY = {e.TotalScaleY:F}\n");
			sb.Append($"  Center =  {e.Center.X:F}/{e.Center.Y:F}");
			AddTouches(sb, e);
			if (e.Cancelled)
				sb.Append(", Cancelled=true");

			return sb.ToString();
		}

		protected string GetElementName(BaseGestureEventArgs e)
		{
			return e.Sender.GetType().Name + " " + ((Element)e.Sender).Id;
		}

		private void AddTouches(StringBuilder sb, BaseGestureEventArgs e)
		{
			sb.Append(", Touches: ");
			if (e.Touches != null && e.Touches.Length > 0)
				sb.Append(string.Join(", ", e.Touches.Select(t => $"{t.X:F}/{t.Y:F}")));
			else
				sb.Append("empty");
		}
	}
}
