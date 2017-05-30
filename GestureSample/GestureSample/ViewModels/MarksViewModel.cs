using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MR.Gestures;

namespace GestureSample.ViewModels
{
	public class MarksViewModel : TransformViewModel
	{
		public string FingerMark	{ get { return ImagePath + "mark_red.png"; } }
		public string CenterMark	{ get { return ImagePath + "mark_blue.png"; } }

		protected static readonly Point halfMarkSize = new Point(32, 32);
		protected static readonly Size autoSize = new Size(Xamarin.Forms.AbsoluteLayout.AutoSize, Xamarin.Forms.AbsoluteLayout.AutoSize);
		protected static readonly Rectangle offScreen = new Rectangle(-100, 0, Xamarin.Forms.AbsoluteLayout.AutoSize, Xamarin.Forms.AbsoluteLayout.AutoSize);

		protected Rectangle finger1 = offScreen;
		public Rectangle Finger1
		{
			get { return finger1; }
			set { SetProperty(ref finger1, value); }
		}

		protected Rectangle finger2 = offScreen;
		public Rectangle Finger2
		{
			get { return finger2; }
			set { SetProperty(ref finger2, value); }
		}

		protected Rectangle center = offScreen;
		public Rectangle Center
		{
			get { return center; }
			set { SetProperty(ref center, value); }
		}


		protected override void OnTapping(MR.Gestures.TapEventArgs e)
		{
			base.OnTapping(e);
			UpdateMarks(e);
		}

		protected override void OnPanning(MR.Gestures.PanEventArgs e)
		{
			base.OnPanning(e);
			UpdateMarks(e);
		}

		protected override void OnPinching(MR.Gestures.PinchEventArgs e)
		{
			base.OnPinching(e);
			UpdateMarks(e);
		}

		protected override void OnRotating(MR.Gestures.RotateEventArgs e)
		{
			base.OnRotating(e);
			UpdateMarks(e);
		}

		private void UpdateMarks(MR.Gestures.BaseGestureEventArgs e)
		{
			if(e.Touches == null || e.Touches.Length == 0)
			{
				Finger1 = offScreen;
				Finger2 = offScreen;
				Center = offScreen;
			}
			else if(e.Touches.Length == 1)
			{
				Finger1 = new Rectangle(e.Touches[0].Subtract(halfMarkSize), autoSize);
				Finger2 = offScreen;
				Center = offScreen;
			}
			else
			{
				Finger1 = new Rectangle(e.Touches[0].Subtract(halfMarkSize), autoSize);
				Finger2 = new Rectangle(e.Touches[1].Subtract(halfMarkSize), autoSize);
				Center = new Rectangle(e.Center.Subtract(halfMarkSize), autoSize);
			}
		}

		protected override void OnSwiped(MR.Gestures.SwipeEventArgs e)
		{
			base.OnSwiped(e);

			if(e.Direction == MR.Gestures.Direction.Right)
			{
				Finger1 = offScreen;
				Finger2 = offScreen;
				Center = offScreen;
			}
		}
	}
}
