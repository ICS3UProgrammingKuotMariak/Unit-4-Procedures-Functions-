namespace Percentage_KuotM_
{
    partial class frmPercentage
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
            this.lblEnterGrade = new System.Windows.Forms.Label();
            this.mnuPercentage = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.mnuPercentage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterGrade
            // 
            this.lblEnterGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGrade.Location = new System.Drawing.Point(25, 24);
            this.lblEnterGrade.Name = "lblEnterGrade";
            this.lblEnterGrade.Size = new System.Drawing.Size(260, 43);
            this.lblEnterGrade.TabIndex = 0;
            this.lblEnterGrade.Text = "Enter Grade level(Ex: 4-):";
            this.lblEnterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuPercentage
            // 
            this.mnuPercentage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuPercentage.Location = new System.Drawing.Point(0, 0);
            this.mnuPercentage.Name = "mnuPercentage";
            this.mnuPercentage.Size = new System.Drawing.Size(299, 24);
            this.mnuPercentage.TabIndex = 1;
            this.mnuPercentage.Text = "menuStrip1";
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
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(54, 70);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(195, 20);
            this.txtGrade.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(88, 115);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 58);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmPercentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 192);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblEnterGrade);
            this.Controls.Add(this.mnuPercentage);
            this.MainMenuStrip = this.mnuPercentage;
            this.Name = "frmPercentage";
            this.Text = "Percentage Program";
            this.mnuPercentage.ResumeLayout(false);
            this.mnuPercentage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterGrade;
        private System.Windows.Forms.MenuStrip mnuPercentage;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnEnter;
    }
}

