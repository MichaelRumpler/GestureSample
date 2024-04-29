namespace GestureSample.Views.Tests
{
	public partial class BindableLayoutWithTemplateNoMRGestures
	{
		public BindableLayoutWithTemplateNoMRGestures()
		{
			InitializeComponent();

			this.ItemsContainer.BindingContext = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		}
	}
}