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
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblInstructions5 = new System.Windows.Forms.Label();
            this.lblKinectFeed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInstructions8 = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblInstructions9 = new System.Windows.Forms.Label();
            this.lblInstructions4 = new System.Windows.Forms.Label();
            this.lblInstructions3 = new System.Windows.Forms.Label();
            this.lblInstructions6 = new System.Windows.Forms.Label();
            this.lblInstructions7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInstructions10 = new System.Windows.Forms.Label();
            this.imgCameraDisplay = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.AutoSize = true;
            this.lblScreenTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenTitle.ForeColor = System.Drawing.Color.Black;
            this.lblScreenTitle.Location = new System.Drawing.Point(415, 0);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(178, 73);
            this.lblScreenTitle.TabIndex = 1;
            this.lblScreenTitle.Text = "Hello";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(-1, 55);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(322, 31);
            this.lblInstruction1.TabIndex = 2;
            this.lblInstruction1.Text = "Please wave to the kinect";
            // 
            // lblInstructions5
            // 
            this.lblInstructions5.AutoSize = true;
            this.lblInstructions5.BackColor = System.Drawing.Color.White;
            this.lblInstructions5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions5.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions5.Location = new System.Drawing.Point(710, 181);
            this.lblInstructions5.Name = "lblInstructions5";
            this.lblInstructions5.Size = new System.Drawing.Size(300, 31);
            this.lblInstructions5.TabIndex = 8;
            this.lblInstructions5.Text = "When you\'re ready click";
            // 
            // lblKinectFeed
            // 
            this.lblKinectFeed.AutoSize = true;
            this.lblKinectFeed.Location = new System.Drawing.Point(713, 285);
            this.lblKinectFeed.Name = "lblKinectFeed";
            this.lblKinectFeed.Size = new System.Drawing.Size(64, 13);
            this.lblKinectFeed.TabIndex = 11;
            this.lblKinectFeed.Text = "Kinect Feed";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblInstructions8);
            this.panel1.Controls.Add(this.lblInstructions2);
            this.panel1.Controls.Add(this.lblInstruction1);
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 463);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "sensor until the cursor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactlessSelfCheckout.Properties.Resources.hand_anim;
            this.pictureBox1.Location = new System.Drawing.Point(-30, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstructions8
            // 
            this.lblInstructions8.AutoSize = true;
            this.lblInstructions8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstructions8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions8.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions8.Location = new System.Drawing.Point(136, 13);
            this.lblInstructions8.Name = "lblInstructions8";
            this.lblInstructions8.Size = new System.Drawing.Size(29, 31);
            this.lblInstructions8.TabIndex = 4;
            this.lblInstructions8.Text = "1";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions2.Location = new System.Drawing.Point(54, 117);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(176, 31);
            this.lblInstructions2.TabIndex = 3;
            this.lblInstructions2.Text = "starts moving";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblInstructions9);
            this.panel2.Controls.Add(this.lblInstructions4);
            this.panel2.Controls.Add(this.lblInstructions3);
            this.panel2.Location = new System.Drawing.Point(361, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 463);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContactlessSelfCheckout.Properties.Resources.hand_grasp;
            this.pictureBox2.Location = new System.Drawing.Point(88, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lblInstructions9
            // 
            this.lblInstructions9.AutoSize = true;
            this.lblInstructions9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstructions9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions9.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions9.Location = new System.Drawing.Point(146, 13);
            this.lblInstructions9.Name = "lblInstructions9";
            this.lblInstructions9.Size = new System.Drawing.Size(29, 31);
            this.lblInstructions9.TabIndex = 5;
            this.lblInstructions9.Text = "2";
            // 
            // lblInstructions4
            // 
            this.lblInstructions4.AutoSize = true;
            this.lblInstructions4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstructions4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions4.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions4.Location = new System.Drawing.Point(100, 86);
            this.lblInstructions4.Name = "lblInstructions4";
            this.lblInstructions4.Size = new System.Drawing.Size(110, 31);
            this.lblInstructions4.TabIndex = 10;
            this.lblInstructions4.Text = "your fist";
            // 
            // lblInstructions3
            // 
            this.lblInstructions3.AutoSize = true;
            this.lblInstructions3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstructions3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions3.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions3.Location = new System.Drawing.Point(31, 55);
            this.lblInstructions3.Name = "lblInstructions3";
            this.lblInstructions3.Size = new System.Drawing.Size(277, 31);
            this.lblInstructions3.TabIndex = 9;
            this.lblInstructions3.Text = "To click simply clench";
            // 
            // lblInstructions6
            // 
            this.lblInstructions6.AutoSize = true;
            this.lblInstructions6.BackColor = System.Drawing.Color.White;
            this.lblInstructions6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions6.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions6.Location = new System.Drawing.Point(725, 212);
            this.lblInstructions6.Name = "lblInstructions6";
            this.lblInstructions6.Size = new System.Drawing.Size(271, 31);
            this.lblInstructions6.TabIndex = 11;
            this.lblInstructions6.Text = "the start button to get";
            // 
            // lblInstructions7
            // 
            this.lblInstructions7.AutoSize = true;
            this.lblInstructions7.BackColor = System.Drawing.Color.White;
            this.lblInstructions7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions7.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions7.Location = new System.Drawing.Point(806, 243);
            this.lblInstructions7.Name = "lblInstructions7";
            this.lblInstructions7.Size = new System.Drawing.Size(98, 31);
            this.lblInstructions7.TabIndex = 11;
            this.lblInstructions7.Text = "started";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, -18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 107);
            this.panel3.TabIndex = 16;
            // 
            // lblInstructions10
            // 
            this.lblInstructions10.AutoSize = true;
            this.lblInstructions10.BackColor = System.Drawing.Color.White;
            this.lblInstructions10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions10.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions10.Location = new System.Drawing.Point(845, 139);
            this.lblInstructions10.Name = "lblInstructions10";
            this.lblInstructions10.Size = new System.Drawing.Size(29, 31);
            this.lblInstructions10.TabIndex = 15;
            this.lblInstructions10.Text = "3";
            // 
            // imgCameraDisplay
            // 
            this.imgCameraDisplay.BackColor = System.Drawing.Color.White;
            this.imgCameraDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCameraDisplay.Location = new System.Drawing.Point(716, 312);
            this.imgCameraDisplay.Name = "imgCameraDisplay";
            this.imgCameraDisplay.Size = new System.Drawing.Size(272, 248);
            this.imgCameraDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCameraDisplay.TabIndex = 6;
            this.imgCameraDisplay.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::ContactlessSelfCheckout.Properties.Resources.start_button;
            this.btnStart.Location = new System.Drawing.Point(716, 595);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(266, 59);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 9;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.White;
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
            // FormCallibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.imgCameraDisplay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstructions10);
            this.Controls.Add(this.lblScreenTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblInstructions7);
            this.Controls.Add(this.lblInstructions6);
            this.Controls.Add(this.lblInstructions5);
            this.Controls.Add(this.lblKinectFeed);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenTitle;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.PictureBox imgCameraDisplay;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.Label lblInstructions5;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Label lblKinectFeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Label lblInstructions4;
        private System.Windows.Forms.Label lblInstructions3;
        private System.Windows.Forms.Label lblInstructions6;
        private System.Windows.Forms.Label lblInstructions7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInstructions8;
        private System.Windows.Forms.Label lblInstructions9;
        private System.Windows.Forms.Label lblInstructions10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}