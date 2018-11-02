using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class TextOnlyViewModel : ObservableObject
	{
		protected static readonly string ImagePath =
			(Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.macOS) ? "images/" :
			Device.RuntimePlatform == Device.Android ? "" : "Resources/images/";

		private string text = "Initialized";
		public string Text
		{
			get { return text; }
			set { SetProperty(ref text, value); }
		}

		public ICommand DownCommand { get; protected set; }
		public ICommand UpCommand { get; protected set; }
		public ICommand TappingCommand { get; protected set; }
		public ICommand TappedCommand { get; protected set; }
		public ICommand DoubleTappedCommand { get; protected set; }
		public ICommand LongPressingCommand { get; protected set; }
		public ICommand LongPressedCommand { get; protected set; }
		public ICommand PinchingCommand { get; protected set; }
		public ICommand PinchedCommand { get; protected set; }
		public ICommand PanningCommand { get; protected set; }
		public ICommand PannedCommand { get; protected set; }
		public ICommand SwipedCommand { get; protected set; }
		public ICommand RotatingCommand { get; protected set; }
		public ICommand RotatedCommand { get; protected set; }

		public TextOnlyViewModel()
		{
			DownCommand = new Command<string>(s => AddText("Down " + s));
			UpCommand = new Command<string>(s => AddText("Up " + s));
			TappingCommand = new Command<string>(s => AddText("Tapping " + s));
			TappedCommand = new Command<string>(s => AddText(s + " was tapped once"));
			DoubleTappedCommand = new Command<string>(s => AddText(s + " was tapped twice "));
			LongPressingCommand = new Command<string>(s => AddText("Pressing " + s + " long"));
			LongPressedCommand = new Command<string>(s => AddText(s + " was long pressed"));
			PinchingCommand = new Command<string>(s => AddText("Pinching " + s));
			PinchedCommand = new Command<string>(s => AddText(s + " was pinched"));
			PanningCommand = new Command<string>(s => AddText("Panning " + s));
			PannedCommand = new Command<string>(s => AddText(s + " was panned"));
			SwipedCommand = new Command<string>(s => AddText(s + " was swiped"));
			RotatingCommand = new Command<string>(s => AddText("Rotating " + s));
			RotatedCommand = new Command<string>(s => AddText(s + " was rotated"));
		}

		public virtual void AddText(string text)
		{
			var sb = new StringBuilder(text).Append("\n").Append(Text);
			Text = sb.ToString(0, Math.Min(sb.Length, 2000));
		}

		public virtual void AddText(string format, params object[] args)
		{
			var sb = new StringBuilder().AppendFormat(format, args).Append("\n").Append(Text);
			Text = sb.ToString(0, Math.Min(sb.Length, 2000));
		}
	}
}
