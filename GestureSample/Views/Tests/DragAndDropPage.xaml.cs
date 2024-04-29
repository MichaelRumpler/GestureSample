using GestureSample.ViewModels.Tests;

namespace GestureSample.Views.Tests
{
	public partial class DragAndDropPage : ContentPage
	{
		public DragAndDropPage()
		{
			InitializeComponent();
		}

		DragAndDropViewModel VM => (DragAndDropViewModel)BindingContext;

		bool dragging = false;
		Frame draggingObject;
		AbsoluteLayout cloneContainer;
		Frame clone;
		double x, y, w, h;
		int originalIndex, currentIndex;

		private void Frame_Down(object sender, MR.Gestures.DownUpEventArgs e)
		{
			// remember draggingObject
			draggingObject = (Frame)sender;
		}

		private void Grid_Panning(object sender, MR.Gestures.PanEventArgs e)
		{
			if(!dragging && draggingObject != null)
			{
				// start dragging

				VM.StartDraggingCommand.Execute(draggingObject.BindingContext);

				dragging = true;

				originalIndex = currentIndex = theFlexLayout.Children.IndexOf(draggingObject);

				var draggingItem = (DragAndDropViewModel.ItemViewModel)draggingObject.BindingContext;

				// create a clone which looks like the draggingObject

				clone = new Frame()
				{
					BindingContext = draggingObject.BindingContext,

					BackgroundColor = draggingItem.Color,
					CornerRadius = draggingObject.CornerRadius,
					BorderColor = Colors.Red,

					Content = new Label()
					{
						Text = draggingItem.Text,
						HorizontalOptions= LayoutOptions.Center,
					}
				};

				// get position and size of the object
				(x, y) = GetAbsolutePosition(draggingObject);
				w = draggingObject.Width;
				h = draggingObject.Height;

				// add clone to the page at the same position as the draggingObject but on top
				cloneContainer = new AbsoluteLayout();
				clone.SetValue(AbsoluteLayout.XProperty, x);
				clone.SetValue(AbsoluteLayout.YProperty, y);
				clone.SetValue(AbsoluteLayout.WidthProperty, w);
				clone.SetValue(AbsoluteLayout.HeightProperty, h);
				cloneContainer.Children.Add(clone);
				theGrid.Children.Add(cloneContainer);

				// make the draggingObject invisible, but the gap should be there
				draggingObject.Opacity = 0;
			}

			if (dragging && draggingObject != null)
			{
				// drag the clone
				x += e.DeltaDistance.X;
				y += e.DeltaDistance.Y;

				AbsoluteLayout.SetLayoutBounds(clone, new Rect(x, y, w, h));

				// check if the child under the touch coordinates changed
				var newIndex = GetChildAt(e.Touches[0]);
				if (newIndex == -1)
					newIndex = originalIndex;

				if(newIndex != currentIndex)
				{
					// child under touch changed

					// -> move the draggingObject (=the gap) to the new position
					theFlexLayout.Children.RemoveAt(currentIndex);
					theFlexLayout.Children.Insert(newIndex, draggingObject);

					currentIndex = newIndex;
				}
			}
		}

		private void Grid_Panned(object sender, MR.Gestures.PanEventArgs e)
		{
			if (dragging && draggingObject != null)
			{
				// drop object

				// remove clone
				theGrid.Children.Remove(cloneContainer);

				// make draggingObject visible again
				draggingObject.Opacity = 1;

				// change Items in ViewModel
				var draggingItem = VM.Items[originalIndex];
				VM.Items.RemoveAt(originalIndex);
				VM.Items.Insert(currentIndex, draggingItem);

				// tell VM that the order changed
				VM.DroppedCommand.Execute(draggingObject.BindingContext);
			}

			dragging = false;
			draggingObject = null;
			clone = null;
			cloneContainer = null;
		}

		private (double x, double y) GetAbsolutePosition(View view)
		{
			var x = view.X;
			var y = view.Y;

			while(!(view.Parent is Page))
			{
				view = (View)view.Parent;
				x += view.X;
				y += view.Y;
			}

			return (x, y);
		}

		private int GetChildAt(Point touch)
		{
			for (int i = 0; i < theFlexLayout.Children.Count; i++)
			{
				if (IsOver(touch, (View)theFlexLayout.Children[i]))
					return i;
			}
			return -1;
		}

		private bool IsOver(Point touch, View view)
		{
			var (viewX, viewY) = GetAbsolutePosition(view);
			return new Rect(viewX, viewY, view.Width, view.Height).Contains(touch);
		}
	}
}