using System.Collections.Generic;
using Xamarin.Forms;

using GestureSample.ViewModels;

namespace GestureSample.Views.Legacy
{
	public partial class LegacyPickerXaml : ContentPage
	{
		public LegacyPickerXaml()
		{
			InitializeComponent();

			BindingContextChanged += LegacyPickerXaml_BindingContextChanged;
		}

		void LegacyPickerXaml_BindingContextChanged(object sender, System.EventArgs e)
		{
			var VM = (PickerViewModel)BindingContext;

			PoorMansBinding(LegacyPicker1, VM.Items1);
			PoorMansBinding(LegacyPicker2, VM.Items2);
			PoorMansBinding(Picker1, VM.Items1);
			PoorMansBinding(Picker2, VM.Items2);
		}

		private void PoorMansBinding(Picker picker, IEnumerable<string> items)
		{
			picker.Items.Clear();
			foreach (var s in items)
				picker.Items.Add(s);
		}
	}
}
