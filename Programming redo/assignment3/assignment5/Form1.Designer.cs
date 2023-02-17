namespace assignment5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fivekmradioButton = new System.Windows.Forms.RadioButton();
            this.TenKmradioButton = new System.Windows.Forms.RadioButton();
            this.TwentyOneKmRadioButton = new System.Windows.Forms.RadioButton();
            this.speedLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.outPutLabel = new System.Windows.Forms.Label();
            this.MinutestextBox = new System.Windows.Forms.TextBox();
            this.SecondstextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fivekmradioButton
            // 
            this.fivekmradioButton.AutoSize = true;
            this.fivekmradioButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fivekmradioButton.Location = new System.Drawing.Point(142, 125);
            this.fivekmradioButton.Name = "fivekmradioButton";
            this.fivekmradioButton.Size = new System.Drawing.Size(114, 45);
            this.fivekmradioButton.TabIndex = 0;
            this.fivekmradioButton.TabStop = true;
            this.fivekmradioButton.Text = "5 km";
            this.fivekmradioButton.UseVisualStyleBackColor = true;
            // 
            // TenKmradioButton
            // 
            this.TenKmradioButton.AutoSize = true;
            this.TenKmradioButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenKmradioButton.Location = new System.Drawing.Point(571, 125);
            this.TenKmradioButton.Name = "TenKmradioButton";
            this.TenKmradioButton.Size = new System.Drawing.Size(130, 45);
            this.TenKmradioButton.TabIndex = 1;
            this.TenKmradioButton.TabStop = true;
            this.TenKmradioButton.Text = "10 km";
            this.TenKmradioButton.UseVisualStyleBackColor = true;
            // 
            // TwentyOneKmRadioButton
            // 
            this.TwentyOneKmRadioButton.AutoSize = true;
            this.TwentyOneKmRadioButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwentyOneKmRadioButton.Location = new System.Drawing.Point(1018, 125);
            this.TwentyOneKmRadioButton.Name = "TwentyOneKmRadioButton";
            this.TwentyOneKmRadioButton.Size = new System.Drawing.Size(130, 45);
            this.TwentyOneKmRadioButton.TabIndex = 2;
            this.TwentyOneKmRadioButton.TabStop = true;
            this.TwentyOneKmRadioButton.Text = "21 km";
            this.TwentyOneKmRadioButton.UseVisualStyleBackColor = true;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedLabel.Location = new System.Drawing.Point(158, 700);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(200, 41);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed(km/hr)";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(158, 280);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(144, 41);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "hh:mm:ss";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(926, 273);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(65, 39);
            this.HoursTextBox.TabIndex = 5;
            // 
            // outPutLabel
            // 
            this.outPutLabel.AutoSize = true;
            this.outPutLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outPutLabel.Location = new System.Drawing.Point(1124, 700);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(39, 41);
            this.outPutLabel.TabIndex = 6;
            this.outPutLabel.Text = "...";
            // 
            // MinutestextBox
            // 
            this.MinutestextBox.Location = new System.Drawing.Point(1034, 273);
            this.MinutestextBox.Name = "MinutestextBox";
            this.MinutestextBox.Size = new System.Drawing.Size(65, 39);
            this.MinutestextBox.TabIndex = 7;
            // 
            // SecondstextBox
            // 
            this.SecondstextBox.Location = new System.Drawing.Point(1142, 273);
            this.SecondstextBox.Name = "SecondstextBox";
            this.SecondstextBox.Size = new System.Drawing.Size(60, 39);
            this.SecondstextBox.TabIndex = 8;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(571, 534);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(324, 67);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 982);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SecondstextBox);
            this.Controls.Add(this.MinutestextBox);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.TwentyOneKmRadioButton);
            this.Controls.Add(this.TenKmradioButton);
            this.Controls.Add(this.fivekmradioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton fivekmradioButton;
        private RadioButton TenKmradioButton;
        private RadioButton TwentyOneKmRadioButton;
        private Label speedLabel;
        private Label timeLabel;
        private TextBox HoursTextBox;
        private Label outPutLabel;
        private TextBox MinutestextBox;
        private TextBox SecondstextBox;
        private Button CalculateButton;
    }
}