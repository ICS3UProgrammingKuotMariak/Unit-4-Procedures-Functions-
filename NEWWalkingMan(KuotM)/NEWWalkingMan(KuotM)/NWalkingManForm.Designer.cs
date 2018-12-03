namespace NEWWalkingMan_KuotM_
{
    partial class NWalkingManForm
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
            this.btn = new System.Windows.Forms.Button();
            this.lblClickOnPic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(278, 240);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(130, 76);
            this.btn.TabIndex = 0;
            this.btn.Text = "Start";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblClickOnPic
            // 
            this.lblClickOnPic.BackColor = System.Drawing.Color.Transparent;
            this.lblClickOnPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickOnPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClickOnPic.Location = new System.Drawing.Point(143, -2);
            this.lblClickOnPic.Name = "lblClickOnPic";
            this.lblClickOnPic.Size = new System.Drawing.Size(388, 60);
            this.lblClickOnPic.TabIndex = 1;
            this.lblClickOnPic.Text = "Click on a picture to make the man walk";
            this.lblClickOnPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NWalkingManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 570);
            this.Controls.Add(this.lblClickOnPic);
            this.Controls.Add(this.btn);
            this.Name = "NWalkingManForm";
            this.Text = "NEW Walking Man";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblClickOnPic;
    }
}

