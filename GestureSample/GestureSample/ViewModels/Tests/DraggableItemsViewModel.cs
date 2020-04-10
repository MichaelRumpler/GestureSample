using MR.Gestures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GestureSample.ViewModels.Tests
{
	public class DraggableItemsViewModel : ObservableObject
	{
		public ICommand PagePanningCommand { get; protected set; }

		public ICommand Object1DownCommand { get; protected set; }
		public ICommand Object1UpCommand { get; protected set; }
		public ICommand Object2DownCommand { get; protected set; }
		public ICommand Object2UpCommand { get; protected set; }
		public ICommand Object3DownCommand { get; protected set; }
		public ICommand Object3UpCommand { get; protected set; }

		protected double object1X = 0;
		public double Object1X { get => object1X; set => SetProperty(ref object1X, value); }

		protected double object1Y = 0;
		public double Object1Y { get => object1Y; set => SetProperty(ref object1Y, value); }

		protected double object2X = 0;
		public double Object2X { get => object2X; set => SetProperty(ref object2X, value); }

		protected double object2Y = 0;
		public double Object2Y { get => object2Y; set => SetProperty(ref object2Y, value); }

		protected double object3X = 0;
		public double Object3X { get => object3X; set => SetProperty(ref object3X, value); }

		protected double object3Y = 0;
		public double Object3Y { get => object3Y; set => SetProperty(ref object3Y, value); }

		private bool fingerOnObject1 = false;
		private bool fingerOnObject2 = false;
		private bool fingerOnObject3 = false;


		public DraggableItemsViewModel()
		{
			PagePanningCommand = new Command<PanEventArgs>(OnPagePanning);
			Object1DownCommand = new Command<DownUpEventArgs>(_ => fingerOnObject1 = true);
			Object1UpCommand = new Command<DownUpEventArgs>(_ => fingerOnObject1 = false);
			Object2DownCommand = new Command<DownUpEventArgs>(_ => fingerOnObject2 = true);
			Object2UpCommand = new Command<DownUpEventArgs>(_ => fingerOnObject2 = false);
			Object3DownCommand = new Command<DownUpEventArgs>(_ => fingerOnObject3 = true);
			Object3UpCommand = new Command<DownUpEventArgs>(_ => fingerOnObject3 = false);
		}

		private void OnPagePanning(PanEventArgs e)
		{
			Debug.WriteLine($"DraggableItemsViewModel.OnPagePanning: fingerOnObject1={fingerOnObject1}, fingerOnObject2={fingerOnObject2}, fingerOnObject3={fingerOnObject3}");

			if(fingerOnObject1)
			{
				Object1X += e.DeltaDistance.X;
				Object1Y += e.DeltaDistance.Y;
				e.Handled = true;
			}
			if (fingerOnObject2)
			{
				Object2X += e.DeltaDistance.X;
				Object2Y += e.DeltaDistance.Y;
				e.Handled = true;
			}
			if (fingerOnObject3)
			{
				Object3X += e.DeltaDistance.X;
				Object3Y += e.DeltaDistance.Y;
				e.Handled = true;
			}
		}
	}
}
