
namespace GestureSample.ViewModels
{
	public class ThreeStringsViewModel : CustomEventArgsViewModel
	{
		private string value1 = "Initial String 1";
		public string Value1
		{
			get { return value1; }
			set { SetProperty(ref value1, value); }
		}

		private string value2;
		public string Value2
		{
			get { return value2; }
			set { SetProperty(ref value2, value); }
		}

		private string value3;
		public string Value3
		{
			get { return value3; }
			set { SetProperty(ref value3, value); }
		}
	}
}
