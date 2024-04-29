using System;

namespace GestureSample.ViewModels
{
	public class ThreeDatesViewModel : CustomEventArgsViewModel
	{
		private DateTime value1;
		public DateTime Value1
		{
			get { return value1; }
			set { SetProperty(ref value1, value); }
		}

		private DateTime value2 = new DateTime(2014, 12, 17, 16, 18, 27);
		public DateTime Value2
		{
			get { return value2; }
			set { SetProperty(ref value2, value); }
		}

		private DateTime value3 = new DateTime(2014, 12, 13, 14, 15, 16, 123);
		public DateTime Value3
		{
			get { return value3; }
			set { SetProperty(ref value3, value); }
		}
	}
}
