using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7._2
{
    public partial class Guesser : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;

        public Guesser()
        {
            InitializeComponent();
            StartGame(random.Next(1, 100));
        }

        private void StartGame(int computerNumber)
        {
            this.computerNumber = computerNumber;
            userNumber = 0;
            labelMoreLess.Text = "";
            textBoxUserNumber.Text = "";
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartGame(random.Next(1, 100));
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxUserNumber.Text, out userNumber))
            {
                if(userNumber < computerNumber)
                {
                    labelMoreLess.Text = "More!";
                }
                else if (userNumber > computerNumber)
                {
                    labelMoreLess.Text = "Less!";
                }
                else
                {
                    labelMoreLess.Text = "Nice!";
                    DialogResult result = MessageBox.Show("Congradulations! You guessed right!\nLet's play again!", "Guesser", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                        StartGame(random.Next(1, 100));
                    else
                        Close();
                }
            }
        }
    }
}
