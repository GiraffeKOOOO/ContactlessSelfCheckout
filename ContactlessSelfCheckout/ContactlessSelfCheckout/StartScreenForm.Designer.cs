namespace ContactlessSelfCheckout
{
    partial class StartScreenForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.ownBagButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenTitle
            // 
            this.screenTitle.AutoSize = true;
            this.screenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenTitle.Location = new System.Drawing.Point(415, 60);
            this.screenTitle.Name = "screenTitle";
            this.screenTitle.Size = new System.Drawing.Size(178, 73);
            this.screenTitle.TabIndex = 0;
            this.screenTitle.Text = "Hello";
            this.screenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.instructionLabel.Location = new System.Drawing.Point(177, 176);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(654, 31);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Please scan an item or press the start button to begin";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Silver;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.startButton.Location = new System.Drawing.Point(351, 298);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(306, 90);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ownBagButton
            // 
            this.ownBagButton.BackColor = System.Drawing.Color.Silver;
            this.ownBagButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ownBagButton.Location = new System.Drawing.Point(351, 416);
            this.ownBagButton.Name = "ownBagButton";
            this.ownBagButton.Size = new System.Drawing.Size(306, 90);
            this.ownBagButton.TabIndex = 3;
            this.ownBagButton.Text = "I have my own bag";
            this.ownBagButton.UseVisualStyleBackColor = false;
            this.ownBagButton.Click += new System.EventHandler(this.ownBagButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Silver;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.helpButton.Location = new System.Drawing.Point(12, 627);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(118, 90);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // StartScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.ownBagButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.screenTitle);
            this.Name = "StartScreenForm";
            this.Text = "Contactless Self-checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label screenTitle;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button ownBagButton;
        private System.Windows.Forms.Button helpButton;
    }
}

