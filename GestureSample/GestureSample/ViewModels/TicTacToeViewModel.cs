using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class TicTacToeViewModel : CustomEventArgsViewModel
	{
		protected readonly string Path =
			Device.OS == TargetPlatform.iOS ? "images/" :
			Device.OS == TargetPlatform.Android ? "" : "Resources/images/";

		protected char[][] board;
		protected char next;
		protected int signsOnBoard;

		public string ImageCell00 { get { return ValueToImage(board[0][0]); } }
		public string ImageCell01 { get { return ValueToImage(board[0][1]); } }
		public string ImageCell02 { get { return ValueToImage(board[0][2]); } }
		public string ImageCell10 { get { return ValueToImage(board[1][0]); } }
		public string ImageCell11 { get { return ValueToImage(board[1][1]); } }
		public string ImageCell12 { get { return ValueToImage(board[1][2]); } }
		public string ImageCell20 { get { return ValueToImage(board[2][0]); } }
		public string ImageCell21 { get { return ValueToImage(board[2][1]); } }
		public string ImageCell22 { get { return ValueToImage(board[2][2]); } }

		public TicTacToeViewModel()
		{
			InitBoard();
		}

		protected override void OnTapping(MR.Gestures.TapEventArgs e)
		{
			base.OnTapping(e);

			if (e.Touches == null) return;

			if(signsOnBoard == 9)
			{
				InitBoard();
				return;
			}

			if(e.Touches == null || e.Touches.Length == 0)
			{
				AddText("Touch coordinates are missing.");
				return;
			}

			int x = (int)(e.Touches[0].X * 3 / e.ViewPosition.Width);
			int y = (int)(e.Touches[0].Y * 3 / e.ViewPosition.Height);

			if(board[y][x] != ' ')
			{
				AddText("Field {0}/{1} is already filled.", x, y);
				return;
			}

			board[y][x] = next;

			NotifyPropertyChanged("ImageCell" + y + x);

			next = next == 'X' ? 'O' : 'X';
			signsOnBoard++;

			checkGameOver();
		}

		private void checkGameOver()
		{
			char winner = GetWinner();

			if(winner != ' ')
			{
				AddText("{0} won! Congratulations!", winner);
				signsOnBoard = 9;
			}
			else if(signsOnBoard == 9)
			{
				AddText("A draw. Try again.");
			}
		}

		private char GetWinner()
		{
			char sign = board[1][1];
			if (sign != ' ')
			{
				if (sign == board[0][0] && sign == board[2][2]
					|| sign == board[0][1] && sign == board[2][1]
					|| sign == board[0][2] && sign == board[2][0]
					|| sign == board[1][0] && sign == board[1][2])
				{
					return sign;
				}
			}

			sign = board[0][0];
			if (sign != ' ')
			{
				if (sign == board[0][1] && sign == board[0][2]
					|| sign == board[1][0] && sign == board[2][0])
				{
					return sign;
				}
			}

			sign = board[0][2];
			if (sign != ' ')
			{
				if (sign == board[1][2] && sign == board[2][2])
				{
					return sign;
				}
			}

			sign = board[2][0];
			if (sign != ' ')
			{
				if (sign == board[2][1] && sign == board[2][2])
				{
					return sign;
				}
			}

			return ' ';
		}

		private void InitBoard()
		{
			AddText("New game");

			board = new[] {
				new [] {' ', ' ', ' '},
				new [] {' ', ' ', ' '},
				new [] {' ', ' ', ' '},
			};
			next = 'X';
			signsOnBoard = 0;

			NotifyPropertyChanged(() => ImageCell00);
			NotifyPropertyChanged(() => ImageCell01);
			NotifyPropertyChanged(() => ImageCell02);
			NotifyPropertyChanged(() => ImageCell10);
			NotifyPropertyChanged(() => ImageCell11);
			NotifyPropertyChanged(() => ImageCell12);
			NotifyPropertyChanged(() => ImageCell20);
			NotifyPropertyChanged(() => ImageCell21);
			NotifyPropertyChanged(() => ImageCell22);
		}

		private string ValueToImage(char value)
		{
			if (value == 'X') return Path + "X.png";
			if (value == 'O') return Path + "O.png";
			return "";
		}
	}
}
