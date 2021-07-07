using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_interface
{
	public partial class Form1 : Form
	{
		int aSol, bSol, cSol, dSol, digitFind, digitInSol, digitInSola, digitInSolb, digitInSolc, digitInSold, colSolution;
		int[,] board = new int[13, 4];
		int tryNum = 0;

		bool solInitOk = false;

		private void buttonReset_Click(object sender, EventArgs e)
        {
			solInitOk = false;
			digitFind = 0;
			digitInSola = 0;
			digitInSolb = 0;
			digitInSolc = 0;
			digitInSold = 0;
			digitInSol = 0;
			tryNum = 0;

			sola.Clear();
			solb.Clear();
			solc.Clear();
			sold.Clear();

			currentTesta.Clear();
			currentTestb.Clear();
			currentTestc.Clear();
			currentTestd.Clear();

			testa0.Clear();
			testa1.Clear();
			testa2.Clear();
			testa3.Clear();
			testa4.Clear();
			testa5.Clear();
			testa6.Clear();
			testa7.Clear();
			testa8.Clear();
			testa9.Clear();
			testa10.Clear();
			testa11.Clear();

			testb0.Clear();
			testb1.Clear();
			testb2.Clear();
			testb3.Clear();
			testb4.Clear();
			testb5.Clear();
			testb6.Clear();
			testb7.Clear();
			testb8.Clear();
			testb9.Clear();
			testb10.Clear();
			testb11.Clear();

			testc0.Clear();
			testc1.Clear();
			testc2.Clear();
			testc3.Clear();
			testc4.Clear();
			testc5.Clear();
			testc6.Clear();
			testc7.Clear();
			testc8.Clear();
			testc9.Clear();
			testc10.Clear();
			testc11.Clear();

			testd0.Clear();
			testd1.Clear();
			testd2.Clear();
			testd3.Clear();
			testd4.Clear();
			testd5.Clear();
			testd6.Clear();
			testd7.Clear();
			testd8.Clear();
			testd9.Clear();
			testd10.Clear();
			testd11.Clear();

			goodDigit0.Clear();
			goodDigit1.Clear();
			goodDigit2.Clear();
			goodDigit3.Clear();
			goodDigit4.Clear();
			goodDigit5.Clear();
			goodDigit6.Clear();
			goodDigit7.Clear();
			goodDigit8.Clear();
			goodDigit9.Clear();
			goodDigit10.Clear();
			goodDigit11.Clear();

			digitAllOk0.Clear();
			digitAllOk1.Clear();
			digitAllOk2.Clear();
			digitAllOk3.Clear();
			digitAllOk4.Clear();
			digitAllOk5.Clear();
			digitAllOk6.Clear();
			digitAllOk7.Clear();
			digitAllOk8.Clear();
			digitAllOk9.Clear();
			digitAllOk10.Clear();
			digitAllOk11.Clear();
		}

        

		private void button1_Click(object sender, EventArgs e)
		{
			if (solInitOk == false)
			{
				if (sola.Text == "")
				{
					sola.Text = "1";
				}
				else if (solb.Text == "")
				{
					solb.Text = "1";
				}
				else if (solc.Text == "")
				{
					solc.Text = "1";
				}
				else if (sold.Text == "")
				{
					sold.Text = "1";
				}
			}

			else if (solInitOk == true)
			{
				if (currentTesta.Text == "")
				{
					currentTesta.Text = "1";
				}
				else if (currentTestb.Text == "")
				{
					currentTestb.Text = "1";
				}
				else if (currentTestc.Text == "")
				{
					currentTestc.Text = "1";
				}
				else if (currentTestd.Text == "")
				{
					currentTestd.Text = "1";
				}
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (solInitOk == false)
			{
				if (sola.Text == "")
				{
					sola.Text = "2";
				}
				else if (solb.Text == "")
				{
					solb.Text = "2";
				}
				else if (solc.Text == "")
				{
					solc.Text = "2";
				}
				else if (sold.Text == "")
				{
					sold.Text = "2";
				}
			}

			else if (solInitOk == true)
			{
				if (currentTesta.Text == "")
				{
					currentTesta.Text = "2";
				}
				else if (currentTestb.Text == "")
				{
					currentTestb.Text = "2";
				}
				else if (currentTestc.Text == "")
				{
					currentTestc.Text = "2";
				}
				else if (currentTestd.Text == "")
				{
					currentTestd.Text = "2";
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (solInitOk == false)
			{
				if (sola.Text == "")
				{
					sola.Text = "3";
				}
				else if (solb.Text == "")
				{
					solb.Text = "3";
				}
				else if (solc.Text == "")
				{
					solc.Text = "3";
				}
				else if (sold.Text == "")
				{
					sold.Text = "3";
				}
			}

			else if (solInitOk == true)
			{
				if (currentTesta.Text == "")
				{
					currentTesta.Text = "3";
				}
				else if (currentTestb.Text == "")
				{
					currentTestb.Text = "3";
				}
				else if (currentTestc.Text == "")
				{
					currentTestc.Text = "3";
				}
				else if (currentTestd.Text == "")
				{
					currentTestd.Text = "3";
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (solInitOk == false)
			{
				if (sola.Text == "")
				{
					sola.Text = "4";
				}
				else if (solb.Text == "")
				{
					solb.Text = "4";
				}
				else if (solc.Text == "")
				{
					solc.Text = "4";
				}
				else if (sold.Text == "")
				{
					sold.Text = "4";
				}
			}

			else if (solInitOk == true)
			{
				if (currentTesta.Text == "")
				{
					currentTesta.Text = "4";
				}
				else if (currentTestb.Text == "")
				{
					currentTestb.Text = "4";
				}
				else if (currentTestc.Text == "")
				{
					currentTestc.Text = "4";
				}
				else if (currentTestd.Text == "")
				{
					currentTestd.Text = "4";
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (solInitOk == false)
			{
				if (sola.Text == "")
				{
					sola.Text = "5";
				}
				else if (solb.Text == "")
				{
					solb.Text = "5";
				}
				else if (solc.Text == "")
				{
					solc.Text = "5";
				}
				else if (sold.Text == "")
				{
					sold.Text = "5";
				}
			}

			else if (solInitOk == true)
			{
				if (currentTesta.Text == "")
				{
					currentTesta.Text = "5";
				}
				else if (currentTestb.Text == "")
				{
					currentTestb.Text = "5";
				}
				else if (currentTestc.Text == "")
				{
					currentTestc.Text = "5";
				}
				else if (currentTestd.Text == "")
				{
					currentTestd.Text = "5";
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (solInitOk == false)
			{
				if (sola.Text == "")
				{
					sola.Text = "6";
				}
				else if (solb.Text == "")
				{
					solb.Text = "6";
				}
				else if (solc.Text == "")
				{
					solc.Text = "6";
				}
				else if (sold.Text == "")
				{
					sold.Text = "6";
				}
			}

			else if (solInitOk == true)
			{
				if (currentTesta.Text == "")
				{
					currentTesta.Text = "6";
				}
				else if (currentTestb.Text == "")
				{
					currentTestb.Text = "6";
				}
				else if (currentTestc.Text == "")
				{
					currentTestc.Text = "6";
				}
				else if (currentTestd.Text == "")
				{
					currentTestd.Text = "6";
				}
			}
		}

		private void panel15_Paint(object sender, PaintEventArgs e)
		{

		}

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSol_Click(object sender, EventArgs e)
		{
			if ((sola.Text == "" || solb.Text == "" || solc.Text == "" || sold.Text == "") && solInitOk == false)
			{
				MessageBox.Show("Entrez les 4 chiffres du nombre secret");
			}

			else if ((sola.Text == "" || solb.Text == "" || solc.Text == "" || sold.Text == "") && solInitOk == true)
			{
				MessageBox.Show("Vous avez déjà donné votre nombre secret");
			}

			else
			{
				aSol = Convert.ToInt32(sola.Text);
				bSol = Convert.ToInt32(solb.Text);
				cSol = Convert.ToInt32(solc.Text);
				dSol = Convert.ToInt32(sold.Text);
				solInitOk = true;
				sola.Clear();
				solb.Clear();
				solc.Clear();
				sold.Clear();
			}
		}

		private void valider_Click(object sender, EventArgs e)
		{
			int[,] solution = new int[1, 4];

			if (currentTesta.Text == "" || currentTestb.Text == "" || currentTestc.Text == "" || currentTestd.Text == "")
			{
				MessageBox.Show("Entrez les 4 chiffres de votre nombre essai");
			}

			else
            {
				solution[0, 0] = aSol;
				solution[0, 1] = bSol;
				solution[0, 2] = cSol;
				solution[0, 3] = dSol;

				if (tryNum == 0)
				{
					testa0.Text = currentTesta.Text;
					board[0, 0] = Convert.ToInt32(currentTesta.Text);
					testb0.Text = currentTestb.Text;
					board[0, 1] = Convert.ToInt32(currentTestb.Text);
					testc0.Text = currentTestc.Text;
					board[0, 2] = Convert.ToInt32(currentTestc.Text);
					testd0.Text = currentTestd.Text;
					board[0, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[0, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[0, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[0, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[0, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[0, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[0, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[0, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[0, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk0.Text = Convert.ToString(digitFind);
					goodDigit0.Text = Convert.ToString(digitInSol);
					tryNum = 1;
				}

				else if (tryNum == 1)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa1.Text = currentTesta.Text;
					board[1, 0] = Convert.ToInt32(currentTesta.Text);
					testb1.Text = currentTestb.Text;
					board[1, 1] = Convert.ToInt32(currentTestb.Text);
					testc1.Text = currentTestc.Text;
					board[1, 2] = Convert.ToInt32(currentTestc.Text);
					testd1.Text = currentTestd.Text;
					board[1, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[1, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[1, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[1, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[1, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[1, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[1, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[1, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[1, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk1.Text = Convert.ToString(digitFind);
					goodDigit1.Text = Convert.ToString(digitInSol);
					tryNum = 2;
				}

				else if (tryNum == 2)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa2.Text = currentTesta.Text;
					board[2, 0] = Convert.ToInt32(currentTesta.Text);
					testb2.Text = currentTestb.Text;
					board[2, 1] = Convert.ToInt32(currentTestb.Text);
					testc2.Text = currentTestc.Text;
					board[2, 2] = Convert.ToInt32(currentTestc.Text);
					testd2.Text = currentTestd.Text;
					board[2, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[2, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[2, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[2, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[2, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[2, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[2, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[2, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[2, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk2.Text = Convert.ToString(digitFind);
					goodDigit2.Text = Convert.ToString(digitInSol);
					tryNum = 3;
				}

				else if (tryNum == 3)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa3.Text = currentTesta.Text;
					board[3, 0] = Convert.ToInt32(currentTesta.Text);
					testb3.Text = currentTestb.Text;
					board[3, 1] = Convert.ToInt32(currentTestb.Text);
					testc3.Text = currentTestc.Text;
					board[3, 2] = Convert.ToInt32(currentTestc.Text);
					testd3.Text = currentTestd.Text;
					board[3, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[3, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[3, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[3, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[3, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[3, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[3, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[3, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[3, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk3.Text = Convert.ToString(digitFind);
					goodDigit3.Text = Convert.ToString(digitInSol);
					tryNum = 4;
				}

				else if (tryNum == 4)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa4.Text = currentTesta.Text;
					board[4, 0] = Convert.ToInt32(currentTesta.Text);
					testb4.Text = currentTestb.Text;
					board[4, 1] = Convert.ToInt32(currentTestb.Text);
					testc4.Text = currentTestc.Text;
					board[4, 2] = Convert.ToInt32(currentTestc.Text);
					testd4.Text = currentTestd.Text;
					board[4, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[4, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[4, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[4, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[4, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[4, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[4, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[4, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[4, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk4.Text = Convert.ToString(digitFind);
					goodDigit4.Text = Convert.ToString(digitInSol);
					tryNum = 5;
				}

				else if (tryNum == 5)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa5.Text = currentTesta.Text;
					board[5, 0] = Convert.ToInt32(currentTesta.Text);
					testb5.Text = currentTestb.Text;
					board[5, 1] = Convert.ToInt32(currentTestb.Text);
					testc5.Text = currentTestc.Text;
					board[5, 2] = Convert.ToInt32(currentTestc.Text);
					testd5.Text = currentTestd.Text;
					board[5, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[5, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[5, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[5, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[5, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[5, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[5, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[5, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[5, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk5.Text = Convert.ToString(digitFind);
					goodDigit5.Text = Convert.ToString(digitInSol);
					tryNum = 6;
				}

				else if (tryNum == 6)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa6.Text = currentTesta.Text;
					board[6, 0] = Convert.ToInt32(currentTesta.Text);
					testb6.Text = currentTestb.Text;
					board[6, 1] = Convert.ToInt32(currentTestb.Text);
					testc6.Text = currentTestc.Text;
					board[6, 2] = Convert.ToInt32(currentTestc.Text);
					testd6.Text = currentTestd.Text;
					board[6, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[6, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[6, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[6, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[6, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[6, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[6, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[6, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[6, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk6.Text = Convert.ToString(digitFind);
					goodDigit6.Text = Convert.ToString(digitInSol);
					tryNum = 7;
				}

				else if (tryNum == 7)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa7.Text = currentTesta.Text;
					board[7, 0] = Convert.ToInt32(currentTesta.Text);
					testb7.Text = currentTestb.Text;
					board[7, 1] = Convert.ToInt32(currentTestb.Text);
					testc7.Text = currentTestc.Text;
					board[7, 2] = Convert.ToInt32(currentTestc.Text);
					testd7.Text = currentTestd.Text;
					board[7, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[7, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[7, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[7, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[7, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[7, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[7, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[7, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[7, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk7.Text = Convert.ToString(digitFind);
					goodDigit7.Text = Convert.ToString(digitInSol);
					tryNum = 8;
				}

				else if (tryNum == 8)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa8.Text = currentTesta.Text;
					board[8, 0] = Convert.ToInt32(currentTesta.Text);
					testb8.Text = currentTestb.Text;
					board[8, 1] = Convert.ToInt32(currentTestb.Text);
					testc8.Text = currentTestc.Text;
					board[8, 2] = Convert.ToInt32(currentTestc.Text);
					testd8.Text = currentTestd.Text;
					board[8, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[8, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[8, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[8, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[8, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[8, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[8, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[8, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[8, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk8.Text = Convert.ToString(digitFind);
					goodDigit8.Text = Convert.ToString(digitInSol);
					tryNum = 9;
				}

				else if (tryNum == 9)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa9.Text = currentTesta.Text;
					board[9, 0] = Convert.ToInt32(currentTesta.Text);
					testb9.Text = currentTestb.Text;
					board[9, 1] = Convert.ToInt32(currentTestb.Text);
					testc9.Text = currentTestc.Text;
					board[9, 2] = Convert.ToInt32(currentTestc.Text);
					testd9.Text = currentTestd.Text;
					board[9, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[9, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[9, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[9, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[9, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[9, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[9, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[9, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[9, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk9.Text = Convert.ToString(digitFind);
					goodDigit9.Text = Convert.ToString(digitInSol);
					tryNum = 10;
				}

				else if (tryNum == 10)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa10.Text = currentTesta.Text;
					board[10, 0] = Convert.ToInt32(currentTesta.Text);
					testb10.Text = currentTestb.Text;
					board[10, 1] = Convert.ToInt32(currentTestb.Text);
					testc10.Text = currentTestc.Text;
					board[10, 2] = Convert.ToInt32(currentTestc.Text);
					testd10.Text = currentTestd.Text;
					board[10, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[10, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[10, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[10, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[10, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[10, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[10, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[10, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[10, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk10.Text = Convert.ToString(digitFind);
					goodDigit10.Text = Convert.ToString(digitInSol);
					tryNum = 11;
				}

				else if (tryNum == 11)
				{
					digitFind = 0;
					digitInSola = 0;
					digitInSolb = 0;
					digitInSolc = 0;
					digitInSold = 0;
					digitInSol = 0;

					testa11.Text = currentTesta.Text;
					board[11, 0] = Convert.ToInt32(currentTesta.Text);
					testb11.Text = currentTestb.Text;
					board[11, 1] = Convert.ToInt32(currentTestb.Text);
					testc11.Text = currentTestc.Text;
					board[11, 2] = Convert.ToInt32(currentTestc.Text);
					testd11.Text = currentTestd.Text;
					board[11, 3] = Convert.ToInt32(currentTestd.Text);

					if (board[11, 0] == aSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[11, 1] == bSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[11, 2] == cSol)
					{
						digitFind = digitFind + 1;
					}
					if (board[11, 3] == dSol)
					{
						digitFind = digitFind + 1;
					}

					for (colSolution = 0; colSolution < 4; colSolution++)
					{
						if (board[11, 0] == solution[0, colSolution] && (digitInSola < 1))
						{
							digitInSola = digitInSola + 1;
							solution[0, colSolution] = -1; // EVITER DE RECOMPTABILISER UN CHIFFRE DEJA TROUVE
						}

						if ((board[11, 1] == solution[0, colSolution]) && (digitInSolb < 1))
						{
							digitInSolb = digitInSolb + 1;
							solution[0, colSolution] = -1;
						}

						if (board[11, 2] == solution[0, colSolution] && (digitInSolc < 1))
						{
							digitInSolc = digitInSolc + 1;
							solution[0, colSolution] = -1;
						}

						if (board[11, 3] == solution[0, colSolution] && (digitInSold < 1))
						{
							digitInSold = digitInSold + 1;
							solution[0, colSolution] = -1;
						}
					}

					digitInSol = digitInSola + digitInSolb + digitInSolc + digitInSold;

					digitAllOk11.Text = Convert.ToString(digitFind);
					goodDigit11.Text = Convert.ToString(digitInSol);
					tryNum = 12;
				}
				currentTesta.Clear();
				currentTestb.Clear();
				currentTestc.Clear();
				currentTestd.Clear();

				if (digitFind == 4)
				{
					MessageBox.Show("Bravo ! Vous avez trouvez le nombre secret " + sola.Text + solb.Text + solc.Text + sold.Text);
				}

				if (tryNum == 12)
				{
					MessageBox.Show("Perdu ! Vous n'avez plus d'essais, vous êtes nul. Le nombre secret était " + sola.Text + solb.Text + solc.Text + sold.Text);
				}
			}
			
			

			

		}

	}

}
