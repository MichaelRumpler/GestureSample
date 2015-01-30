
using GestureSample.ViewModels;
namespace GestureSample.Views
{
	public partial class PickerXaml
	{

		private PickerViewModel VM;

		public PickerXaml()
		{
			InitializeComponent();

			this.BindingContextChanged += PickerXaml_BindingContextChanged;

			Picker1.SelectedIndexChanged += (s, e) => VM.Value1 = Picker1.Items[Picker1.SelectedIndex];
			Picker2.SelectedIndexChanged += (s, e) => VM.Value2 = Picker2.Items[Picker2.SelectedIndex];
			Picker3.SelectedIndexChanged += (s, e) => VM.Value3 = Picker3.Items[Picker3.SelectedIndex];
		}

		void PickerXaml_BindingContextChanged(object sender, System.EventArgs e)
		{
			VM = (PickerViewModel)BindingContext;

			Picker1.Items.Clear();
			foreach (var s in VM.Items1)
				Picker1.Items.Add(s);

			Picker2.Items.Clear();
			foreach (var s in VM.Items2)
				Picker2.Items.Add(s);

			Picker3.Items.Clear();
			foreach (var s in VM.Items3)
				Picker3.Items.Add(s);
		}
	}
}
