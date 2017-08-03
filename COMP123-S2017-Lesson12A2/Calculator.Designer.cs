namespace COMP123_S2017_Lesson12A2
{
    partial class Calculator
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
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.ColumnCount = 4;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.Controls.Add(this.EqualButton, 3, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.button19, 2, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.PlusMinusButton, 0, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.SubtractButton, 3, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.BackspaceButton, 2, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.ClearButton, 0, 0);
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(1, 130);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 5;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(299, 300);
            this.ButtonTableLayoutPanel.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(4, 93);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(288, 31);
            this.ResultTextBox.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ButtonTableLayoutPanel.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 54);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Location = new System.Drawing.Point(151, 3);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(68, 54);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "←";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(225, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(68, 54);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SevenButton.Location = new System.Drawing.Point(3, 63);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 54);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EightButton.Location = new System.Drawing.Point(77, 63);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(68, 54);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NineButton.Location = new System.Drawing.Point(151, 63);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(68, 54);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(225, 63);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(68, 54);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FourButton.Location = new System.Drawing.Point(3, 123);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(68, 54);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FiveButton.Location = new System.Drawing.Point(77, 123);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(68, 54);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SixButton.Location = new System.Drawing.Point(151, 123);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(68, 54);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(225, 123);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(68, 54);
            this.SubtractButton.TabIndex = 11;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OneButton.Location = new System.Drawing.Point(3, 183);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(68, 54);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TwoButton.Location = new System.Drawing.Point(77, 183);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(68, 54);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ThreeButton.Location = new System.Drawing.Point(151, 183);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(68, 54);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(225, 183);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(68, 54);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 243);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(68, 54);
            this.PlusMinusButton.TabIndex = 16;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ZeroButton.Location = new System.Drawing.Point(77, 243);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(68, 54);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button19.Location = new System.Drawing.Point(151, 243);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(68, 54);
            this.button19.TabIndex = 18;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(225, 243);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(68, 54);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ButtonTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

