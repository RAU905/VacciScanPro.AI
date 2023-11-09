namespace webcam2
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
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic1
            // 
            this.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic1.Location = new System.Drawing.Point(12, 21);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(429, 388);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic2.Location = new System.Drawing.Point(481, 21);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(422, 388);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 1;
            this.Pic2.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(30, 434);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(96, 33);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Location = new System.Drawing.Point(181, 434);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(96, 33);
            this.BtnCapture.TabIndex = 3;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Name";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(541, 441);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(265, 26);
            this.tbFileName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 526);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileName;
    }
}

