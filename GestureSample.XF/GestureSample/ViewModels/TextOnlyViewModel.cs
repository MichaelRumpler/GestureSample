using System;
using System.Diagnostics;
using System.Text;
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
		public ICommand MouseEnteredCommand { get; protected set; }
		public ICommand MouseMovedCommand { get; protected set; }
		public ICommand MouseExitedCommand { get; protected set; }
		public ICommand ScrollWheelChangedCommand { get; protected set; }

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
			MouseEnteredCommand = new Command<string>(s => AddText($"Mouse entered {s}"));
			MouseMovedCommand = new Command<string>(s => AddText($"Mouse moved over {s}"));
			MouseExitedCommand = new Command<string>(s => AddText($"Mouse exited {s}"));
			ScrollWheelChangedCommand = new Command<string>(s => AddText($"Scroll wheel changed over {s}"));
		}

		public virtual void AddText(string text)
		{
			var s = $"{ThreadInfo} {text}\n{Text}";
			if (s.Length > 2000)
				s = s.Substring(0, 2000);
			Text = s;

			//Debug.WriteLine(text);
		}

		public virtual void AddText(string format, params object[] args)
			=> AddText(string.Format(format, args));

		public static string ThreadInfo
		{
			get
		{
				var threadType = System.Threading.Thread.CurrentThread.IsBackground ? "BG" : "UI";
				var threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

				return $"[T:{threadType}#{threadId}]";
			}
		}
	}
}
