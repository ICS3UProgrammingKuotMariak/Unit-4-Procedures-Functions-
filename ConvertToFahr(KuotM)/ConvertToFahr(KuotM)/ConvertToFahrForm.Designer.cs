namespace ConvertToFahr_KuotM_
{
    partial class frmConvertToFahr
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
            this.lblEnterCelsius = new System.Windows.Forms.Label();
            this.mnuTempConverter = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.mnuTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterCelsius
            // 
            this.lblEnterCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCelsius.Location = new System.Drawing.Point(12, 61);
            this.lblEnterCelsius.Name = "lblEnterCelsius";
            this.lblEnterCelsius.Size = new System.Drawing.Size(149, 56);
            this.lblEnterCelsius.TabIndex = 0;
            this.lblEnterCelsius.Text = "Enter the Celsius(°C):";
            // 
            // mnuTempConverter
            // 
            this.mnuTempConverter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuTempConverter.Location = new System.Drawing.Point(0, 0);
            this.mnuTempConverter.Name = "mnuTempConverter";
            this.mnuTempConverter.Size = new System.Drawing.Size(368, 24);
            this.mnuTempConverter.TabIndex = 1;
            this.mnuTempConverter.Text = "menuStrip1";
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
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(167, 97);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(169, 20);
            this.txtCelsius.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(103, 144);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(146, 58);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmConvertToFahr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 242);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblEnterCelsius);
            this.Controls.Add(this.mnuTempConverter);
            this.MainMenuStrip = this.mnuTempConverter;
            this.Name = "frmConvertToFahr";
            this.Text = "Temperature Converter";
            this.mnuTempConverter.ResumeLayout(false);
            this.mnuTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterCelsius;
        private System.Windows.Forms.MenuStrip mnuTempConverter;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvert;
    }
}

