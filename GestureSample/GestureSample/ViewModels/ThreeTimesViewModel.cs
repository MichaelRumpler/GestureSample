using System;

namespace GestureSample.ViewModels
{
	public class ThreeTimesViewModel : CustomEventArgsViewModel
	{
		private TimeSpan value1 = new TimeSpan(0, 0, 1);
		public TimeSpan Value1
		{
			get { return value1; }
			set { SetProperty(ref value1, value); }
		}

		private TimeSpan value2 = new TimeSpan(16, 21, 58);
		public TimeSpan Value2
		{
			get { return value2; }
			set { SetProperty(ref value2, value); }
		}

		private TimeSpan value3 = new TimeSpan(0, 16, 21, 58, 987);		// hours > 24 throws exception in TimePicker.Time property
		public TimeSpan Value3
		{
			get { return value3; }
			set { SetProperty(ref value3, value); }
		}
	}
}
