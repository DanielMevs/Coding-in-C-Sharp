namespace MyWinFormApp
{
    partial class MainForm
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
            IncreaseCounterButton = new Button();
            CounterLabel = new Label();
            HideButtonCheckbox = new CheckBox();
            YearOfBirthTextBox = new TextBox();
            SuspendLayout();
            // 
            // IncreaseCounterButton
            // 
            IncreaseCounterButton.Font = new Font("Segoe UI", 20F);
            IncreaseCounterButton.Location = new Point(219, 87);
            IncreaseCounterButton.Name = "IncreaseCounterButton";
            IncreaseCounterButton.Size = new Size(193, 88);
            IncreaseCounterButton.TabIndex = 0;
            IncreaseCounterButton.Text = "Click me";
            IncreaseCounterButton.UseVisualStyleBackColor = true;
            IncreaseCounterButton.Click += IncreaseCounterButton_Click;
            // 
            // CounterLabel
            // 
            CounterLabel.AutoSize = true;
            CounterLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            CounterLabel.Location = new Point(50, 87);
            CounterLabel.Name = "CounterLabel";
            CounterLabel.Size = new Size(46, 54);
            CounterLabel.TabIndex = 1;
            CounterLabel.Text = "0";
            // 
            // HideButtonCheckbox
            // 
            HideButtonCheckbox.AutoSize = true;
            HideButtonCheckbox.Font = new Font("Segoe UI", 20F);
            HideButtonCheckbox.Location = new Point(79, 211);
            HideButtonCheckbox.Name = "HideButtonCheckbox";
            HideButtonCheckbox.Size = new Size(264, 58);
            HideButtonCheckbox.TabIndex = 2;
            HideButtonCheckbox.Text = "Hide button";
            HideButtonCheckbox.UseVisualStyleBackColor = true;
            HideButtonCheckbox.CheckedChanged += HideButtonCheckbox_CheckedChanged;
            // 
            // YearOfBirthTextBox
            // 
            YearOfBirthTextBox.Font = new Font("Segoe UI", 20F);
            YearOfBirthTextBox.Location = new Point(98, 323);
            YearOfBirthTextBox.Name = "YearOfBirthTextBox";
            YearOfBirthTextBox.Size = new Size(232, 61);
            YearOfBirthTextBox.TabIndex = 3;
            YearOfBirthTextBox.KeyPress += YearOfBirthTextBox_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(YearOfBirthTextBox);
            Controls.Add(HideButtonCheckbox);
            Controls.Add(CounterLabel);
            Controls.Add(IncreaseCounterButton);
            Name = "MainForm";
            Text = "Our first app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IncreaseCounterButton;
        private Label CounterLabel;
        private CheckBox HideButtonCheckbox;
        private TextBox YearOfBirthTextBox;
    }
}
