using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using Xamarin.Forms;

namespace GestureSample.ViewModels.Tests
{
	public class DragAndDropViewModel : CustomEventArgsViewModel
	{
		public struct ItemViewModel
		{
			public string Text { get; }
			public Color Color { get; }

			public ItemViewModel(string text)
			{
				Text = text;
			
				var rnd = new Random();
				Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
			}
		}

		// from https://slipsum.com/
		private readonly string LoremIpsumLong = "You think water moves fast? You should see ice. It moves like it has a mind. Like it knows it killed the world once and got a taste for murder. After the avalanche, it took us a week to climb out. Now, I don't know exactly when we turned on each other, but I know that seven of us survived the slide... and only five made it out. Now we took an oath, that I'm breaking now. We said we'd say it was the snow that killed the other two, but it wasn't. Nature is lethal but it doesn't hold a candle to man.";
		private readonly string LoremIpsumShort = "Then they show that show to the people who make shows, and on the strength of that one show they decide if they're going to make more shows.";


		public List<ItemViewModel> Items { get; }
		public ICommand StartDraggingCommand { get; }
		public ICommand DroppedCommand { get; }


		public DragAndDropViewModel()
		{
			var text = Device.Idiom == TargetIdiom.Phone ? LoremIpsumShort : LoremIpsumLong;
			Items = text
				.Split(' ')
				.Select(s => new ItemViewModel(s))
				.ToList();

			TappedCommand = new Command<ItemViewModel>(OnItemTapped);
			StartDraggingCommand = new Command<ItemViewModel>(OnStartItemDragging);
			DroppedCommand = new Command<ItemViewModel>(OnItemDropped);
		}

		private void OnItemTapped(ItemViewModel item)
		{
			AddText($"Item {item.Text} was tapped.");
		}

		private void OnStartItemDragging(ItemViewModel item)
		{
			AddText($"Started dragging Item {item.Text}.");
		}

		private void OnItemDropped(ItemViewModel item)
		{
			AddText($"Item {item.Text} was dropped.");
			AddText($"The whole text is now: " + string.Join(" ", Items.Select(i => i.Text)));
		}
	}
}
