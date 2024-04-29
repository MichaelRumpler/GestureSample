using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GestureSample.ViewModels.Tests
{
    public class DeleteBoundItemsViewModel : TextOnlyViewModel
	{
		public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

		public ICommand AddCommand { get; }
		public ICommand DeleteCommand { get; }
		public ICommand ResetCommand { get; }

		public string AddImage { get; } = ImagePath + "add.png";
		public string DeleteImage { get; } = ImagePath + "delete.png";

		private int nextNumber = 0;

		public DeleteBoundItemsViewModel()
		{
			AddCommand = new Command(o => Add((MR.Gestures.TapEventArgs)o));
			DeleteCommand = new Command(o => Delete((string)o));
			ResetCommand = new Command(Reset);

			Reset();
			Text = "";
		}

		public void Add(MR.Gestures.TapEventArgs args)
		{
			var item = (string)((BindableObject)args.Sender).BindingContext;
			var i = Items.IndexOf(item)+1;

			var newitem = ListOfStringsViewModel.Numbers[nextNumber++];
			if (nextNumber >= ListOfStringsViewModel.Numbers.Length)
				nextNumber = 0;

			AddText($"Adding {newitem} at position {i}");
			Items.Insert(i, newitem);
		}

		public void Delete(string item)
		{
			AddText($"Deleting {item}");
			Items.Remove((string)item);
		}

		public void Reset()
		{
			Items.Clear();
			for(int i=0;i<5;i++)
			{
				Items.Add(ListOfStringsViewModel.Numbers[nextNumber++]);
				if (nextNumber >= ListOfStringsViewModel.Numbers.Length)
					nextNumber = 0;
			}

			AddText("----------- Reset -----------");
		}
	}
}
