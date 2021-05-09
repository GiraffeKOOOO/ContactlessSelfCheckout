namespace ContactlessSelfCheckout
{
    partial class FormCallibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCallibration));
            this.lblScreenTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.pnlErrorBackground = new System.Windows.Forms.Panel();
            this.lblErrorMessage2 = new System.Windows.Forms.Label();
            this.lblErrorMessage1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.imgCameraDisplay = new System.Windows.Forms.PictureBox();
            this.lblKinectFeed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlErrorBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.AutoSize = true;
            this.lblScreenTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenTitle.ForeColor = System.Drawing.Color.Black;
            this.lblScreenTitle.Location = new System.Drawing.Point(415, 9);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(178, 73);
            this.lblScreenTitle.TabIndex = 1;
            this.lblScreenTitle.Text = "Hello";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction.Location = new System.Drawing.Point(62, 95);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(884, 31);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Please stand in the outlined area and wave until the cursor starts moving";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction2.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction2.Location = new System.Drawing.Point(177, 138);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(655, 31);
            this.lblInstruction2.TabIndex = 8;
            this.lblInstruction2.Text = "When you\'re ready click the start button to get started";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblErrorTitle);
            this.panel1.Controls.Add(this.pnlErrorBackground);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 192);
            this.panel1.TabIndex = 10;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.BackColor = System.Drawing.Color.Black;
            this.lblErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(419, 5);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(174, 73);
            this.lblErrorTitle.TabIndex = 11;
            this.lblErrorTitle.Text = "Error";
            this.lblErrorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorTitle.Visible = false;
            // 
            // pnlErrorBackground
            // 
            this.pnlErrorBackground.BackColor = System.Drawing.Color.Black;
            this.pnlErrorBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlErrorBackground.Controls.Add(this.lblErrorMessage2);
            this.pnlErrorBackground.Controls.Add(this.lblErrorMessage1);
            this.pnlErrorBackground.Location = new System.Drawing.Point(50, 5);
            this.pnlErrorBackground.Name = "pnlErrorBackground";
            this.pnlErrorBackground.Size = new System.Drawing.Size(910, 182);
            this.pnlErrorBackground.TabIndex = 14;
            this.pnlErrorBackground.Visible = false;
            // 
            // lblErrorMessage2
            // 
            this.lblErrorMessage2.AutoSize = true;
            this.lblErrorMessage2.BackColor = System.Drawing.Color.Black;
            this.lblErrorMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblErrorMessage2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage2.Location = new System.Drawing.Point(15, 113);
            this.lblErrorMessage2.Name = "lblErrorMessage2";
            this.lblErrorMessage2.Size = new System.Drawing.Size(885, 31);
            this.lblErrorMessage2.TabIndex = 13;
            this.lblErrorMessage2.Text = "Control Software is installed on the machine, then restart the application.";
            this.lblErrorMessage2.Visible = false;
            // 
            // lblErrorMessage1
            // 
            this.lblErrorMessage1.AutoSize = true;
            this.lblErrorMessage1.BackColor = System.Drawing.Color.Black;
            this.lblErrorMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblErrorMessage1.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage1.Location = new System.Drawing.Point(3, 72);
            this.lblErrorMessage1.Name = "lblErrorMessage1";
            this.lblErrorMessage1.Size = new System.Drawing.Size(910, 31);
            this.lblErrorMessage1.TabIndex = 12;
            this.lblErrorMessage1.Text = "Kinect Mouse Control Software not found. Please make sure Kinect Mouse";
            this.lblErrorMessage1.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::ContactlessSelfCheckout.Properties.Resources.start_button;
            this.btnStart.Location = new System.Drawing.Point(307, 636);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(395, 81);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 9;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 7;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // imgCameraDisplay
            // 
            this.imgCameraDisplay.BackColor = System.Drawing.Color.White;
            this.imgCameraDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCameraDisplay.Location = new System.Drawing.Point(199, 217);
            this.imgCameraDisplay.Name = "imgCameraDisplay";
            this.imgCameraDisplay.Size = new System.Drawing.Size(610, 405);
            this.imgCameraDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCameraDisplay.TabIndex = 6;
            this.imgCameraDisplay.TabStop = false;
            // 
            // lblKinectFeed
            // 
            this.lblKinectFeed.AutoSize = true;
            this.lblKinectFeed.Location = new System.Drawing.Point(196, 200);
            this.lblKinectFeed.Name = "lblKinectFeed";
            this.lblKinectFeed.Size = new System.Drawing.Size(64, 13);
            this.lblKinectFeed.TabIndex = 11;
            this.lblKinectFeed.Text = "Kinect Feed";
            // 
            // FormCallibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblKinectFeed);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.imgCameraDisplay);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblScreenTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCallibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCallibration_FormClosed);
            this.Load += new System.EventHandler(this.FormCallibration_Load);
            this.Click += new System.EventHandler(this.FormCallibration_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlErrorBackground.ResumeLayout(false);
            this.pnlErrorBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox imgCameraDisplay;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Panel pnlErrorBackground;
        private System.Windows.Forms.Label lblErrorMessage2;
        private System.Windows.Forms.Label lblErrorMessage1;
        private System.Windows.Forms.Label lblKinectFeed;
    }
}