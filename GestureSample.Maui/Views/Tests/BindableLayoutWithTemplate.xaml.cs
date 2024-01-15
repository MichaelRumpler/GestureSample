namespace GestureSample.Views.Tests
{
	public partial class BindableLayoutWithTemplate
	{
		public BindableLayoutWithTemplate()
		{
			InitializeComponent();

			this.ItemsContainer.BindingContext = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		}

		private void ContentView_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("\n");
			System.Diagnostics.Debug.WriteLine("## pressing down:");
			foreach (var source in e.Sources)
			{
				System.Diagnostics.Debug.WriteLine($"## via {source}");
			}
		}

		private void ContentView_Up(object sender, MR.Gestures.DownUpEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("## pressing up:");
			foreach (var source in e.Sources)
			{
				System.Diagnostics.Debug.WriteLine($"## via {source}");
			}
		}
	}
}