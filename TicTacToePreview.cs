using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToePreview : Form
    {
        private int buttonsClickCounter = 0;
        private bool isWon = false;

        private void IsWonIndicator()
        {
            isWon = true;
        }
        private void ButtonsClickIncrementor()
        {
            buttonsClickCounter++;
        }

        private void ColorTheWin(Button btnOne,Button btnTwo,Button btnThree)
        {
            btnOne.BackColor = Color.AliceBlue;
            btnTwo.BackColor = Color.AliceBlue;
            btnThree.BackColor = Color.AliceBlue;
        }

        private void WinImageApply()
        {
            Label imageHolder = new Label();

            imageHolder.Image = Properties.Resources.laster;
            imageHolder.Size = new Size(60, 60);
            imageHolder.BackColor = Color.Transparent;
            imageHolder.Location = new Point(290,335);
            this.Controls.Add(imageHolder);

        }

        private void LoseImageApply()
        {
            Label imageHolder = new Label();

            imageHolder.Image = Properties.Resources.rsz_loseimage;
            imageHolder.Size = new Size(60, 60);
            imageHolder.BackColor = Color.Transparent;
            imageHolder.Location = new Point(290, 335);
            this.Controls.Add(imageHolder);
        }

        private void UnavailableControls()
        {

            List<Button> buttons = new List<Button>() { btnOne, btnTwo, btnThree, btnFour, btnFive, btnSix, btnSeven, btnEight, btnNine };

            firstPlayerName.Enabled = false;
            secondPlayerName.Enabled = false;

            foreach (var button in buttons)
            {
                button.Enabled = false;
            }

        }

        private void WinnerOutput(string playerName)
        {
            gameInfo.Text = string.Format("The Winner is: {0}", playerName);
        }

        private void FoundWinner(string firstPlayer, string secondPlayer)
        {

            //First player horizontal win
            if (btnOne.Text == "X" && btnTwo.Text == "X" && btnThree.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnOne, btnTwo, btnThree);
                IsWonIndicator();
            }
            else if (btnFour.Text == "X" && btnFive.Text == "X" && btnSix.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnFour, btnFive, btnSix);
                IsWonIndicator();
            }
            else if (btnSeven.Text == "X" && btnEight.Text == "X" && btnNine.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnSeven, btnEight, btnNine);
                isWon = true;
            }

            //First player vertical win
            else if (btnOne.Text == "X" && btnFour.Text == "X" && btnSeven.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                ColorTheWin(btnOne, btnFour, btnSeven);
                WinImageApply();
                IsWonIndicator();
            }
            else if (btnTwo.Text == "X" && btnFive.Text == "X" && btnEight.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnTwo, btnFive, btnEight);
                IsWonIndicator();
            }
            else if (btnThree.Text == "X" && btnSix.Text == "X" && btnNine.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnThree, btnSix, btnNine);
                IsWonIndicator();
            }

            //First player diagonal win
            else if (btnOne.Text == "X" && btnFive.Text == "X" && btnNine.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnOne, btnFive, btnNine);
                IsWonIndicator();
            }
            else if (btnThree.Text == "X" && btnFive.Text == "X" && btnSeven.Text == "X")
            {
                WinnerOutput(firstPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnThree, btnFive, btnSeven);
                IsWonIndicator();
            }

            //Second player horizontal win
            if (btnOne.Text == "O" && btnTwo.Text == "O" && btnThree.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnOne, btnTwo, btnThree);
                IsWonIndicator();
            }
            else if (btnFour.Text == "O" && btnFive.Text == "O" && btnSix.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnFour, btnFive, btnSix);
                IsWonIndicator();
            }
            else if (btnSeven.Text == "O" && btnEight.Text == "O" && btnNine.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnSeven, btnEight, btnNine);
                IsWonIndicator();
            }

            //Second player vertical win
            else if (btnOne.Text == "O" && btnFour.Text == "O" && btnSeven.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnOne, btnFour, btnSeven);
                IsWonIndicator();
            }
            else if (btnTwo.Text == "O" && btnFive.Text == "O" && btnEight.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnTwo, btnFive, btnEight);
                IsWonIndicator();
            }
            else if (btnThree.Text == "O" && btnSix.Text == "O" && btnNine.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnThree, btnSix, btnNine);
                IsWonIndicator();
            }

            //Second player diagonal win
            else if (btnOne.Text == "O" && btnFive.Text == "O" && btnNine.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnOne, btnFive, btnNine);
                IsWonIndicator();
            }
            else if (btnThree.Text == "O" && btnFive.Text == "O" && btnSeven.Text == "O")
            {
                WinnerOutput(secondPlayer);
                UnavailableControls();
                WinImageApply();
                ColorTheWin(btnThree, btnFive, btnSeven);
                IsWonIndicator();            
            }

        }

        private void buttonClicked(Button btn)
        {
            btn.Enabled = false;
        }

        private void overflowTurns(int counter)
        {
            if (counter == 9 && isWon == false)
            {
                gameInfo.Text = "No winner!";
                LoseImageApply();
                UnavailableControls();
            }
        }

        private void GameStyleWriter(int counter,Button button,string firstName,string secondName)
        {
            if (counter % 2 == 0)
            {
                button.Text = "O";
                gameInfo.Text = string.Format("{0} did his/her turn.",secondName);
            }
            else
            {
                button.Text = "X";
                gameInfo.Text = string.Format("{0} did his/her turn.", firstName);
            }
        }

        public TicTacToePreview()
        {
            InitializeComponent();
        }

        private void firstPlayerName_TextChanged(object sender, EventArgs e)
        {
            controller1.Text = "Gamestyle: X";
        }

        private void secondPlayerName_TextChanged(object sender, EventArgs e)
        {
            controller2.Text = "Gamestyle: O";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            buttonClicked(btnOne);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnOne,firstPlayerName.Text,secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            buttonClicked(btnTwo);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnTwo,firstPlayerName.Text,secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            buttonClicked(btnThree);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnThree, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            buttonClicked(btnFour);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnFour, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            buttonClicked(btnFive);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnFive, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            buttonClicked(btnSix);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnSix, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            buttonClicked(btnSeven);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnSeven, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            buttonClicked(btnEight);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnEight, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            buttonClicked(btnNine);
            ButtonsClickIncrementor();
            GameStyleWriter(buttonsClickCounter, btnNine, firstPlayerName.Text, secondPlayerName.Text);
            FoundWinner(firstPlayerName.Text, secondPlayerName.Text);
            overflowTurns(buttonsClickCounter);
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
