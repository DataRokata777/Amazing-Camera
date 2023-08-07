namespace Amazing_Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vccbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectvideocapturedevice = new System.Windows.Forms.ComboBox();
            this.startvcc = new System.Windows.Forms.Button();
            this.stopvcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vccbox)).BeginInit();
            this.SuspendLayout();
            // 
            // vccbox
            // 
            this.vccbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vccbox.BackgroundImage = global::Amazing_Camera.Properties.Resources.ClickStartScreen;
            this.vccbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vccbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vccbox.ImageLocation = "C:\\Users\\hp8460-ssd\\Documents\\EventScreens\\ClickStartScreen.png";
            this.vccbox.InitialImage = global::Amazing_Camera.Properties.Resources.ClickStartScreen;
            this.vccbox.Location = new System.Drawing.Point(12, 12);
            this.vccbox.Name = "vccbox";
            this.vccbox.Size = new System.Drawing.Size(862, 411);
            this.vccbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vccbox.TabIndex = 0;
            this.vccbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capture Card OR Webcam:";
            // 
            // selectvideocapturedevice
            // 
            this.selectvideocapturedevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectvideocapturedevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectvideocapturedevice.FormattingEnabled = true;
            this.selectvideocapturedevice.Location = new System.Drawing.Point(147, 431);
            this.selectvideocapturedevice.Name = "selectvideocapturedevice";
            this.selectvideocapturedevice.Size = new System.Drawing.Size(565, 21);
            this.selectvideocapturedevice.TabIndex = 2;
            // 
            // startvcc
            // 
            this.startvcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startvcc.Location = new System.Drawing.Point(799, 430);
            this.startvcc.Name = "startvcc";
            this.startvcc.Size = new System.Drawing.Size(75, 23);
            this.startvcc.TabIndex = 3;
            this.startvcc.Text = "Start";
            this.startvcc.UseVisualStyleBackColor = false;
            this.startvcc.Click += new System.EventHandler(this.startvcc_Click);
            // 
            // stopvcc
            // 
            this.stopvcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopvcc.Location = new System.Drawing.Point(718, 430);
            this.stopvcc.Name = "stopvcc";
            this.stopvcc.Size = new System.Drawing.Size(75, 23);
            this.stopvcc.TabIndex = 4;
            this.stopvcc.Text = "Stop";
            this.stopvcc.UseVisualStyleBackColor = false;
            this.stopvcc.Click += new System.EventHandler(this.stopvcc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(886, 463);
            this.Controls.Add(this.stopvcc);
            this.Controls.Add(this.startvcc);
            this.Controls.Add(this.selectvideocapturedevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vccbox);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Amazing Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vccbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vccbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectvideocapturedevice;
        private System.Windows.Forms.Button startvcc;
        private System.Windows.Forms.Button stopvcc;
    }
}

