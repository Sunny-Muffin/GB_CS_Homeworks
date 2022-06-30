namespace Lesson7._2
{
    partial class Guesser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRules = new System.Windows.Forms.Label();
            this.textBoxUserNumber = new System.Windows.Forms.TextBox();
            this.labelMoreLess = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRules.Location = new System.Drawing.Point(93, 85);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(391, 24);
            this.labelRules.TabIndex = 0;
            this.labelRules.Text = "Guess what number am I thinking of? (1...100)";
            this.labelRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserNumber
            // 
            this.textBoxUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUserNumber.Location = new System.Drawing.Point(145, 163);
            this.textBoxUserNumber.Name = "textBoxUserNumber";
            this.textBoxUserNumber.Size = new System.Drawing.Size(113, 29);
            this.textBoxUserNumber.TabIndex = 1;
            // 
            // labelMoreLess
            // 
            this.labelMoreLess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMoreLess.AutoSize = true;
            this.labelMoreLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMoreLess.Location = new System.Drawing.Point(155, 195);
            this.labelMoreLess.Name = "labelMoreLess";
            this.labelMoreLess.Size = new System.Drawing.Size(93, 24);
            this.labelMoreLess.TabIndex = 2;
            this.labelMoreLess.Text = "MoreLess";
            this.labelMoreLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGuess.Location = new System.Drawing.Point(314, 163);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(113, 36);
            this.buttonGuess.TabIndex = 3;
            this.buttonGuess.Text = "GUESS";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonNewGame.Location = new System.Drawing.Point(145, 244);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(113, 36);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonQuit.Location = new System.Drawing.Point(314, 244);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(113, 36);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameSurname.Location = new System.Drawing.Point(417, 335);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(155, 17);
            this.labelNameSurname.TabIndex = 6;
            this.labelNameSurname.Text = "Made by Afanasev Ivan";
            this.labelNameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Guesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.labelMoreLess);
            this.Controls.Add(this.textBoxUserNumber);
            this.Controls.Add(this.labelRules);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guesser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumberGuesser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.TextBox textBoxUserNumber;
        private System.Windows.Forms.Label labelMoreLess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelNameSurname;
    }
}

