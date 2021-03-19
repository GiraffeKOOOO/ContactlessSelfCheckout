namespace ContactlessSelfCheckout
{
    partial class CallibrationForm
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
            this.screenTitle = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.cameraDisplayBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // screenTitle
            // 
            this.screenTitle.AutoSize = true;
            this.screenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenTitle.Location = new System.Drawing.Point(415, 28);
            this.screenTitle.Name = "screenTitle";
            this.screenTitle.Size = new System.Drawing.Size(178, 73);
            this.screenTitle.TabIndex = 1;
            this.screenTitle.Text = "Hello";
            this.screenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.instructionLabel.Location = new System.Drawing.Point(135, 139);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(738, 31);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Please stand in the outlined area to start callibration process";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Silver;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.helpButton.Location = new System.Drawing.Point(12, 627);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(118, 90);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // cameraDisplayBox
            // 
            this.cameraDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraDisplayBox.Location = new System.Drawing.Point(222, 209);
            this.cameraDisplayBox.Name = "cameraDisplayBox";
            this.cameraDisplayBox.Size = new System.Drawing.Size(565, 471);
            this.cameraDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cameraDisplayBox.TabIndex = 6;
            this.cameraDisplayBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(842, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CallibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cameraDisplayBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.screenTitle);
            this.Name = "CallibrationForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CallibrationForm_FormClosing);
            this.Load += new System.EventHandler(this.CallibrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label screenTitle;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.PictureBox cameraDisplayBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}