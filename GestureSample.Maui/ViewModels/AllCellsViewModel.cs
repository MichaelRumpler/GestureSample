namespace GestureSample.ViewModels
{
	public class AllCellsViewModel : CustomEventArgsViewModel
	{
		public string Icon1 => "pic1.png";
		public string Icon2 => "pic2.png";
		public string Icon3 => "pic3.png";
		public string Icon4 => "pic4.png";
		public string Icon5 => "pic5.png";

		public string EntryValue { get; set; }

		private bool switchValue = true;
		public bool SwitchValue
		{
			get { return switchValue; }
			set
			{
				SetProperty(ref switchValue, value);
			}
		}
	}
}
