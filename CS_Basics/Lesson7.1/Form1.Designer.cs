namespace Lesson7._1
{
    partial class Form1
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelUserNumber = new System.Windows.Forms.Label();
            this.labelMinActions = new System.Windows.Forms.Label();
            this.labelActionsCount = new System.Windows.Forms.Label();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRules = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReset.Location = new System.Drawing.Point(337, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "New Game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPlus.Location = new System.Drawing.Point(337, 102);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(141, 40);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDouble.Location = new System.Drawing.Point(337, 164);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(141, 40);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "x2";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelComputerNumber.Location = new System.Drawing.Point(49, 79);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(140, 24);
            this.labelComputerNumber.TabIndex = 3;
            this.labelComputerNumber.Text = "Target number:";
            // 
            // labelUserNumber
            // 
            this.labelUserNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserNumber.AutoSize = true;
            this.labelUserNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUserNumber.Location = new System.Drawing.Point(49, 141);
            this.labelUserNumber.Name = "labelUserNumber";
            this.labelUserNumber.Size = new System.Drawing.Size(148, 24);
            this.labelUserNumber.TabIndex = 4;
            this.labelUserNumber.Text = "Current number:";
            // 
            // labelMinActions
            // 
            this.labelMinActions.AutoSize = true;
            this.labelMinActions.BackColor = System.Drawing.Color.Transparent;
            this.labelMinActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMinActions.Location = new System.Drawing.Point(49, 228);
            this.labelMinActions.Name = "labelMinActions";
            this.labelMinActions.Size = new System.Drawing.Size(157, 24);
            this.labelMinActions.TabIndex = 5;
            this.labelMinActions.Text = "Minimum actions:";
            // 
            // labelActionsCount
            // 
            this.labelActionsCount.AutoSize = true;
            this.labelActionsCount.BackColor = System.Drawing.Color.Transparent;
            this.labelActionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelActionsCount.Location = new System.Drawing.Point(332, 228);
            this.labelActionsCount.Name = "labelActionsCount";
            this.labelActionsCount.Size = new System.Drawing.Size(129, 24);
            this.labelActionsCount.TabIndex = 6;
            this.labelActionsCount.Text = "Actions count:";
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.BackColor = System.Drawing.Color.Transparent;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNameSurname.Location = new System.Drawing.Point(356, 294);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(155, 17);
            this.labelNameSurname.TabIndex = 7;
            this.labelNameSurname.Text = "Made by Afanasev Ivan";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonQuit);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.labelRules);
            this.panelMenu.Controls.Add(this.labelGameName);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(500, 299);
            this.panelMenu.TabIndex = 8;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonQuit.Location = new System.Drawing.Point(268, 90);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(157, 40);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "QUIT GAME";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonStart.Location = new System.Drawing.Point(65, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(157, 40);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START GAME";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Try to take as little actions as possible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "or multiplying by 2";
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRules.Location = new System.Drawing.Point(61, 168);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(374, 24);
            this.labelRules.TabIndex = 1;
            this.labelRules.Text = "You need to get target number by adding 1 ";
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelGameName.Location = new System.Drawing.Point(185, 30);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(126, 26);
            this.labelGameName.TabIndex = 0;
            this.labelGameName.Text = "DOUBLER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(524, 321);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.labelActionsCount);
            this.Controls.Add(this.labelMinActions);
            this.Controls.Add(this.labelUserNumber);
            this.Controls.Add(this.labelComputerNumber);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnReset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelUserNumber;
        private System.Windows.Forms.Label labelMinActions;
        private System.Windows.Forms.Label labelActionsCount;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

