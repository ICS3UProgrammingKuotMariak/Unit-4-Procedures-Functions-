namespace RoundDecimal_KuotM_
{
    partial class frmRoundDecimal
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
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.lblDecimalPlaces = new System.Windows.Forms.Label();
            this.mnuRoundDecimal = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.mnuRoundDecimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(263, 125);
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(161, 20);
            this.nudDecimal.TabIndex = 0;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(163, 169);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(130, 51);
            this.btnRound.TabIndex = 1;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNum.Location = new System.Drawing.Point(12, 39);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(222, 25);
            this.lblEnterNum.TabIndex = 2;
            this.lblEnterNum.Text = "Enter a decimal number:";
            // 
            // txtUserNum
            // 
            this.txtUserNum.Location = new System.Drawing.Point(263, 44);
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.Size = new System.Drawing.Size(161, 20);
            this.txtUserNum.TabIndex = 3;
            // 
            // lblDecimalPlaces
            // 
            this.lblDecimalPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalPlaces.Location = new System.Drawing.Point(12, 93);
            this.lblDecimalPlaces.Name = "lblDecimalPlaces";
            this.lblDecimalPlaces.Size = new System.Drawing.Size(235, 52);
            this.lblDecimalPlaces.TabIndex = 4;
            this.lblDecimalPlaces.Text = "Number of decimal places to round to:";
            this.lblDecimalPlaces.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mnuRoundDecimal
            // 
            this.mnuRoundDecimal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuRoundDecimal.Location = new System.Drawing.Point(0, 0);
            this.mnuRoundDecimal.Name = "mnuRoundDecimal";
            this.mnuRoundDecimal.Size = new System.Drawing.Size(450, 24);
            this.mnuRoundDecimal.TabIndex = 5;
            this.mnuRoundDecimal.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmRoundDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 251);
            this.Controls.Add(this.lblDecimalPlaces);
            this.Controls.Add(this.txtUserNum);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.mnuRoundDecimal);
            this.MainMenuStrip = this.mnuRoundDecimal;
            this.Name = "frmRoundDecimal";
            this.Text = "Round Decimal";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            this.mnuRoundDecimal.ResumeLayout(false);
            this.mnuRoundDecimal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.Label lblDecimalPlaces;
        private System.Windows.Forms.MenuStrip mnuRoundDecimal;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

