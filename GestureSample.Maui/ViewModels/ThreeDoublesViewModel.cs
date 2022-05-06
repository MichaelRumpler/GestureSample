using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureSample.ViewModels
{
	public class ThreeDoublesViewModel : CustomEventArgsViewModel
	{
		private double value1;
		public double Value1
		{
			get { return value1; }
			set { SetProperty(ref value1, value); }
		}

		private double value2;
		public double Value2
		{
			get { return value2; }
			set { SetProperty(ref value2, value); }
		}

		private double value3;
		public double Value3
		{
			get { return value3; }
			set { SetProperty(ref value3, value); }
		}
	}
}
