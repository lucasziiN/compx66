namespace Practical
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
            this.buttonDrawPhone = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.buttonDrawBalls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawPhone
            // 
            this.buttonDrawPhone.Location = new System.Drawing.Point(12, 11);
            this.buttonDrawPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawPhone.Name = "buttonDrawPhone";
            this.buttonDrawPhone.Size = new System.Drawing.Size(112, 30);
            this.buttonDrawPhone.TabIndex = 3;
            this.buttonDrawPhone.Text = "Draw Phone";
            this.buttonDrawPhone.UseVisualStyleBackColor = true;
            this.buttonDrawPhone.Click += new System.EventHandler(this.buttonDrawPhone_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(214, 11);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(400, 730);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // buttonDrawBalls
            // 
            this.buttonDrawBalls.Location = new System.Drawing.Point(12, 125);
            this.buttonDrawBalls.Name = "buttonDrawBalls";
            this.buttonDrawBalls.Size = new System.Drawing.Size(112, 29);
            this.buttonDrawBalls.TabIndex = 5;
            this.buttonDrawBalls.Text = "Draw Balls";
            this.buttonDrawBalls.UseVisualStyleBackColor = true;
            this.buttonDrawBalls.Click += new System.EventHandler(this.buttonDrawBalls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num Balls in Row";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 179);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 27);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 611);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 26);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 751);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDrawBalls);
            this.Controls.Add(this.buttonDrawPhone);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawPhone;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonDrawBalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

