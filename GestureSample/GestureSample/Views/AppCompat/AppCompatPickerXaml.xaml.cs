using System.Collections.Generic;
using Xamarin.Forms;

using GestureSample.ViewModels;

namespace GestureSample.Views.AppCompat
{
	public partial class AppCompatPickerXaml : ContentPage
	{
		public AppCompatPickerXaml()
		{
			InitializeComponent();

			BindingContextChanged += AppCompatPickerXaml_BindingContextChanged;
		}

		void AppCompatPickerXaml_BindingContextChanged(object sender, System.EventArgs e)
		{
			var VM = (PickerViewModel)BindingContext;

			PoorMansBinding(AppCompatPicker1, VM.Items1);
			PoorMansBinding(AppCompatPicker2, VM.Items2);
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
