using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prog2370LiamDowlingAssignment3
{
	public partial class Form1 : Form
	{
		//Enums for player turn
		public enum Player
		{
			X,
			O
		}

		// declaring enum
		
		Player currentTurn = Player.X;
		
		



		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// decides if the selected image is an X or and O depending
		/// on the turn order, assigns the correct image to box
		/// sets the tag of the image to and O or X
		/// changes the turn and checks for a winner on each click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void IsAnXOrAnO(object sender, EventArgs e)
		{
			//send image to picturebox
			PictureBox picClick = (PictureBox)sender;

			if (picClick.Tag == null)
			{
				if (currentTurn == Player.O)
				{
					this.BackColor = Color.Red;
					lblTop.Text = "ITS YOUR TURN X";
					picClick.Image = Properties.Resources.RedO;
					picClick.SizeMode = PictureBoxSizeMode.Zoom;
					picClick.Name = "isO";
					picClick.Tag = "O";

					currentTurn = Player.X;
					CheckWinner();

				}
				else if (currentTurn == Player.X)
				{
					this.BackColor = Color.Blue;
					lblTop.Text = "ITS YOUR TURN O";
					picClick.Image = Properties.Resources.blueX;
					picClick.SizeMode = PictureBoxSizeMode.Zoom;
					picClick.Name = "isX";
					picClick.Tag = "X";

					currentTurn = Player.O;
					CheckWinner();
				}
			}
			else if (picClick.Image != null)
			{
				
				MessageBox.Show("Please select an empty box");
			}
		}
		
		//using the isAnXOrAnO method to assign correct picture 
		//when picturebox is clicked
		private void PbOne_Click(object sender, EventArgs e)
		{
			
			if (pbOne.Tag == null)
			{
				pbOne.Click += IsAnXOrAnO;
				CheckWinner();
			}
			


		}

		private void PbTwo_Click(object sender, EventArgs e)
		{
			if(pbTwo.Tag == null)
			{
				pbTwo.Click += IsAnXOrAnO;
				CheckWinner();
			}
			
		}

		private void PbThree_Click(object sender, EventArgs e)
		{
			
			if(pbThree.Tag == null)
			{
				pbThree.Click += IsAnXOrAnO;
				CheckWinner();
			}

		}

		private void PbFour_Click(object sender, EventArgs e)
		{
			if (pbFour.Tag == null)
			{
				pbFour.Click += IsAnXOrAnO;
				CheckWinner();
			}

		}

		private void PbFive_Click(object sender, EventArgs e)
		{
			if (pbFive.Tag == null)
			{
				pbFive.Click += IsAnXOrAnO;
				
			}

		}

		private void PbSix_Click(object sender, EventArgs e)
		{
			if (pbSix.Tag == null)
			{
				pbSix.Click += IsAnXOrAnO;
				
			}

		}

		private void PbSeven_Click(object sender, EventArgs e)
		{
			if (pbSeven.Tag == null)
			{
				pbSeven.Click += IsAnXOrAnO;
				CheckWinner();
			}
			
		}

		private void PbEight_Click(object sender, EventArgs e)
		{
			if (pbEight.Tag == null)
			{
				pbEight.Click += IsAnXOrAnO;
				CheckWinner();
			}

		}

		private void PbNine_Click(object sender, EventArgs e)
		{
			if(pbNine.Tag == null)
			{
				pbNine.Click += IsAnXOrAnO;
				CheckWinner();
			}
		}
		/// <summary>
		/// clears the board by creating a new form
		/// resets the current player to being with X
		/// </summary>
		public void clearBoard()
		{
			//foreach (PictureBox pic in this.Controls)
			//{
			//	listPic.Add(pic);
			//	foreach (PictureBox p in listPic)
			//	{
			//		pic.Tag = null;
			//		pic.Image = null;


			//	}

			//}

			Form1 NewForm = new Form1();
			NewForm.Show();
			this.Dispose(false);
			currentTurn = Player.X;
			

		}
		/// <summary>
		/// checks for a winner for every combination of moves in the game
		/// </summary>
		public void CheckWinner()
		{
			if(pbOne.Tag != null && pbTwo.Tag != null && pbThree.Tag != null && 
				pbFour.Tag != null && pbFive.Tag != null && pbSix.Tag != null && 
				pbSeven.Tag != null && pbEight.Tag != null && pbNine.Tag != null )
			{
				MessageBox.Show("The result is a tie!");
				clearBoard();
			}

			//picturebox 1, 4, 7 check for win
			if(pbOne.Tag == "O" && pbFour.Tag == "O" && pbSeven.Tag =="O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if(pbOne.Tag == "X" && pbFour.Tag == "X" && pbSeven.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 2, 5, 8 check for win
			if (pbTwo.Tag == "O" && pbFive.Tag == "O" && pbEight.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if (pbTwo.Tag == "X" && pbFive.Tag == "X" && pbEight.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 3, 6, 9 check for win
			if (pbThree.Tag == "O" && pbSix.Tag == "O" && pbNine.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if (pbThree.Tag == "X" && pbSix.Tag == "X" && pbNine.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 1, 5, 9 check for win
			if (pbOne.Tag == "O" && pbFive.Tag == "O" && pbNine.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if (pbOne.Tag == "X" && pbFive.Tag == "X" && pbNine.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 3, 5, 7 check for win
			if (pbThree.Tag == "O" && pbFive.Tag == "O" && pbSeven.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if (pbThree.Tag == "X" && pbFive.Tag == "X" && pbSeven.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 1,2,3 check for win
			if (pbOne.Tag == "O" && pbTwo.Tag == "O" && pbThree.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if (pbOne.Tag == "X" && pbTwo.Tag == "X" && pbThree.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 4,5,6 check for win
			if (pbFour.Tag == "O" && pbFive.Tag == "O" && pbSix.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();
			}
			else if (pbFour.Tag == "X" && pbFive.Tag == "X" && pbSix.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			//picturebox 7,8,9 check for win
			if (pbSeven.Tag == "O" && pbEight.Tag == "O" && pbNine.Tag == "O")
			{
				MessageBox.Show("O Wins!");
				clearBoard();

			}
			else if (pbSeven.Tag == "X" && pbEight.Tag == "X" && pbNine.Tag == "X")
			{
				MessageBox.Show("X Wins!");
				clearBoard();
			}
			
		}
		// sets the back colour and text on form load
		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.Yellow;
			lblTop.Text = "Thank you for playing tic tac toe, please select a square to begin";
			
		}
	}
}
