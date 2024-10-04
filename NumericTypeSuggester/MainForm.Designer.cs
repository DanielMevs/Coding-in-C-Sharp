namespace NumericTypeSuggester
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuggestedTypeLabel = new Label();
            IntegralOnlyCheckBox = new CheckBox();
            MustBePreciseCheckbox = new CheckBox();
            MinValueTextBox = new TextBox();
            MaxValueTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(205, 54);
            label1.TabIndex = 0;
            label1.Text = "Min value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(210, 54);
            label2.TabIndex = 1;
            label2.Text = "Max value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(30, 340);
            label3.Name = "label3";
            label3.Size = new Size(329, 54);
            label3.TabIndex = 2;
            label3.Text = "Suggested type:";
            // 
            // SuggestedTypeLabel
            // 
            SuggestedTypeLabel.AutoSize = true;
            SuggestedTypeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SuggestedTypeLabel.Location = new Point(356, 340);
            SuggestedTypeLabel.Name = "SuggestedTypeLabel";
            SuggestedTypeLabel.Size = new Size(337, 54);
            SuggestedTypeLabel.TabIndex = 3;
            SuggestedTypeLabel.Text = "not enough data";
            // 
            // IntegralOnlyCheckBox
            // 
            IntegralOnlyCheckBox.AutoSize = true;
            IntegralOnlyCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            IntegralOnlyCheckBox.Checked = true;
            IntegralOnlyCheckBox.CheckState = CheckState.Checked;
            IntegralOnlyCheckBox.Font = new Font("Segoe UI", 20F);
            IntegralOnlyCheckBox.Location = new Point(12, 188);
            IntegralOnlyCheckBox.Name = "IntegralOnlyCheckBox";
            IntegralOnlyCheckBox.Size = new Size(290, 58);
            IntegralOnlyCheckBox.TabIndex = 4;
            IntegralOnlyCheckBox.Text = "Integral only?";
            IntegralOnlyCheckBox.UseVisualStyleBackColor = true;
            IntegralOnlyCheckBox.CheckedChanged += IntegralOnlyCheckBox_CheckedChanged;
            // 
            // MustBePreciseCheckbox
            // 
            MustBePreciseCheckbox.AutoSize = true;
            MustBePreciseCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            MustBePreciseCheckbox.Font = new Font("Segoe UI", 20F);
            MustBePreciseCheckbox.Location = new Point(12, 252);
            MustBePreciseCheckbox.Name = "MustBePreciseCheckbox";
            MustBePreciseCheckbox.Size = new Size(349, 58);
            MustBePreciseCheckbox.TabIndex = 5;
            MustBePreciseCheckbox.Text = "Must be precise?";
            MustBePreciseCheckbox.UseVisualStyleBackColor = true;
            MustBePreciseCheckbox.Visible = false;
            MustBePreciseCheckbox.CheckedChanged += MustBePreciseCheckbox_CheckedChanged;
            // 
            // MinValueTextBox
            // 
            MinValueTextBox.Font = new Font("Segoe UI", 20F);
            MinValueTextBox.Location = new Point(214, 23);
            MinValueTextBox.Name = "MinValueTextBox";
            MinValueTextBox.Size = new Size(1008, 61);
            MinValueTextBox.TabIndex = 6;
            MinValueTextBox.TextChanged += TextBox_TextChanged;
            MinValueTextBox.KeyPress += TextBox_KeyPress;
            // 
            // MaxValueTextBox
            // 
            MaxValueTextBox.Font = new Font("Segoe UI", 20F);
            MaxValueTextBox.Location = new Point(214, 98);
            MaxValueTextBox.Name = "MaxValueTextBox";
            MaxValueTextBox.Size = new Size(1008, 61);
            MaxValueTextBox.TabIndex = 7;
            MaxValueTextBox.TextChanged += TextBox_TextChanged;
            MaxValueTextBox.KeyPress += TextBox_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1266, 450);
            Controls.Add(MaxValueTextBox);
            Controls.Add(MinValueTextBox);
            Controls.Add(MustBePreciseCheckbox);
            Controls.Add(IntegralOnlyCheckBox);
            Controls.Add(SuggestedTypeLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "C# Numeric types";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label SuggestedTypeLabel;
        private CheckBox IntegralOnlyCheckBox;
        private CheckBox MustBePreciseCheckbox;
        private TextBox MinValueTextBox;
        private TextBox MaxValueTextBox;
    }
}
