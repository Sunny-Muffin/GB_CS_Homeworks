using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7._1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int actionCount;
        private int idealActions;

        public Form1()
        {
            InitializeComponent();
            UpdateState(userNumber, random.Next(30));
        }

        private void UpdateState(int userNumber)
        {
            labelUserNumber.Text = $"Current number: {userNumber}";
        }

        private void UpdateState(int userNumber, int computerNumber)
        {
            UpdateState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Target number: {computerNumber}";
            int tempNumber = computerNumber;
            while (tempNumber > 0)
            {
                if (tempNumber % 2 == 0)
                {
                    tempNumber /= 2;
                    idealActions++;
                }
                else
                {
                    tempNumber--;
                    idealActions++;
                }
            }
            labelMinActions.Text = $"MinimumActions: {idealActions}";
        }

        private void ActionCount(int actions)
        {
            labelActionsCount.Text = $"Actions count: {actions}";
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show("Congradulations! You WIN!", "Doubler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Try again?", "Doubler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Close();
                }
            }
            else if (userNumber > computerNumber)
            {
                MessageBox.Show("Wasted! You LOOSE!", "Doubler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Try again?", "Doubler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Close();
                }
            }
        }

        private void ResetGame()
        {
            userNumber = 0;
            actionCount = 0;
            idealActions = 0;
            UpdateState(userNumber, random.Next(30));
            ActionCount(actionCount);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            UpdateState(++userNumber);
            ActionCount(++actionCount);
            CheckWin();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            UpdateState(userNumber *= 2);
            ActionCount(++actionCount);
            CheckWin();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
