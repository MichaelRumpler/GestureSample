using GestureSample.ViewModels;

namespace GestureSample.Views
{
	public partial class EditorXaml
	{
		public EditorXaml()
		{
			InitializeComponent();
		}

		private void Editor_TextChanged(object sender, TextChangedEventArgs e)
		{
			AddText("TextChanged");
		}

		private void Editor_Completed(object sender, EventArgs e)
		{
			AddText("Completed");
		}

		private void AddText(string text)
		{
			((TextOnlyViewModel)BindingContext).AddText(text);
		}
	}
}
