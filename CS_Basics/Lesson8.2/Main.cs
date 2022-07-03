using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8._2
{
    public partial class Main : Form
    {
        TrueFalseDatabase database;
        
        public Main()
        {
            InitializeComponent();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(dlg.FileName);
                database.Add("Earth is flat?", false);
                database.Save();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = 1;
                numericUpDownNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(dlg.FileName);
                database.Load();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = database.Count;
                numericUpDownNumber.Value = 1;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (database != null)
                database.Save();
            else
                MessageBox.Show("Error!No database!\nPlease create database (File->New)\nOr open existing database (File->Open)", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                textBoxQuestion.Text = database[(int)numericUpDownNumber.Value - 1].Text;
                checkBoxTrue.Checked = database[(int)numericUpDownNumber.Value - 1].TrueFalse;
            }
            else
                MessageBox.Show("Error!No database!\nPlease create database (File->New)\nOr open existing database (File->Open)", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Add($"#{database.Count + 1}", true);
                numericUpDownNumber.Maximum = database.Count;
                numericUpDownNumber.Value = database.Count;
            }
            else
                MessageBox.Show("Error!No database!\nPlease create database (File->New)\nOr open existing database (File->Open)", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (numericUpDownNumber.Maximum == 1)
            {
                MessageBox.Show("Error! At least ONE question should exist!", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
            if (database != null)
            {
                database.Remove((int)numericUpDownNumber.Value - 1);
                numericUpDownNumber.Maximum--;
                //MessageBox.Show($"numericUpDownNumber.Value = {numericUpDownNumber.Value}", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(numericUpDownNumber.Value <= numericUpDownNumber.Maximum)
                {
                    numericUpDownNumber.Value = numericUpDownNumber.Value;
                    textBoxQuestion.Text = database[(int)numericUpDownNumber.Value - 1].Text;
                    checkBoxTrue.Checked = database[(int)numericUpDownNumber.Value - 1].TrueFalse;
                }
            }
            else
                MessageBox.Show("Error!No database!\nPlease create database (File->New)\nOr open existing database (File->Open)", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)numericUpDownNumber.Value - 1].Text = textBoxQuestion.Text;
                database[(int)numericUpDownNumber.Value - 1].TrueFalse = checkBoxTrue.Checked;
            }
            else
                MessageBox.Show("Error!No database!\nPlease create database (File->New)\nOr open existing database (File->Open)", "TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Afanasev Ivan\nVersion 1.0\nCopyright by Afanasev Ivan", "About TrueFalseEditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            // сначала создадим базу данных, если её нет
            if (database == null)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    database = new TrueFalseDatabase(dlg.FileName);
                    database.Add("Earth is flat?", false);
                    database.Save();
                    numericUpDownNumber.Minimum = 1;
                    numericUpDownNumber.Maximum = 1;
                    numericUpDownNumber.Value = 1;
                }
            }
            // если база уже есть, то сохраним как новый файл
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    database.fileName = dlg.FileName;
                    database.Save();
                }
            }
        }
    }
}
