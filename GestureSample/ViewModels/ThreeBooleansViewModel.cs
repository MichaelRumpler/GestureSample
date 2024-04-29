
namespace GestureSample.ViewModels
{
	public class ThreeBooleansViewModel : CustomEventArgsViewModel
	{
		private bool value1;
		public bool Value1
		{
			get { return value1; }
			set { SetProperty(ref value1, value); }
		}

		private bool value2 = true;
		public bool Value2
		{
			get { return value2; }
			set { SetProperty(ref value2, value); }
		}

		private bool value3;
		public bool Value3
		{
			get { return value3; }
			set { SetProperty(ref value3, value); }
		}
	}
}
