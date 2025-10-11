namespace Software_Lab4_Task1
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
            LabelX = new Label();
            LabelY = new Label();
            LabelN = new Label();
            LabelW = new Label();
            LabelT = new Label();
            TextBoxY = new TextBox();
            TextBoxX = new TextBox();
            TextBoxN = new TextBox();
            ComboBoxW = new ComboBox();
            ListBoxT = new ListBox();
            RadioButton1 = new RadioButton();
            RadioButton2 = new RadioButton();
            ButtonCalculate = new Button();
            LabelZoo = new Label();
            TextBoxZoo = new TextBox();
            SuspendLayout();
            // 
            // LabelX
            // 
            LabelX.AutoSize = true;
            LabelX.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelX.Location = new Point(12, 19);
            LabelX.Name = "LabelX";
            LabelX.Size = new Size(34, 37);
            LabelX.TabIndex = 0;
            LabelX.Text = "X";
            // 
            // LabelY
            // 
            LabelY.AutoSize = true;
            LabelY.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelY.Location = new Point(12, 77);
            LabelY.Name = "LabelY";
            LabelY.Size = new Size(33, 37);
            LabelY.TabIndex = 1;
            LabelY.Text = "Y";
            // 
            // LabelN
            // 
            LabelN.AutoSize = true;
            LabelN.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelN.Location = new Point(12, 134);
            LabelN.Name = "LabelN";
            LabelN.Size = new Size(37, 37);
            LabelN.TabIndex = 2;
            LabelN.Text = "N";
            // 
            // LabelW
            // 
            LabelW.AutoSize = true;
            LabelW.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelW.Location = new Point(262, 19);
            LabelW.Name = "LabelW";
            LabelW.Size = new Size(44, 37);
            LabelW.TabIndex = 3;
            LabelW.Text = "W";
            // 
            // LabelT
            // 
            LabelT.AutoSize = true;
            LabelT.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelT.Location = new Point(267, 77);
            LabelT.Name = "LabelT";
            LabelT.Size = new Size(32, 37);
            LabelT.TabIndex = 4;
            LabelT.Text = "T";
            // 
            // TextBoxY
            // 
            TextBoxY.BorderStyle = BorderStyle.None;
            TextBoxY.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextBoxY.Location = new Point(51, 77);
            TextBoxY.Name = "TextBoxY";
            TextBoxY.Size = new Size(125, 37);
            TextBoxY.TabIndex = 5;
            // 
            // TextBoxX
            // 
            TextBoxX.BorderStyle = BorderStyle.None;
            TextBoxX.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextBoxX.Location = new Point(52, 19);
            TextBoxX.Name = "TextBoxX";
            TextBoxX.Size = new Size(125, 37);
            TextBoxX.TabIndex = 6;
            // 
            // TextBoxN
            // 
            TextBoxN.BorderStyle = BorderStyle.None;
            TextBoxN.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextBoxN.Location = new Point(52, 134);
            TextBoxN.Name = "TextBoxN";
            TextBoxN.Size = new Size(125, 37);
            TextBoxN.TabIndex = 7;
            // 
            // ComboBoxW
            // 
            ComboBoxW.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ComboBoxW.FormattingEnabled = true;
            ComboBoxW.Items.AddRange(new object[] { "0,005", "0,5", "50", "500", "5000", "50000" });
            ComboBoxW.Location = new Point(312, 16);
            ComboBoxW.Name = "ComboBoxW";
            ComboBoxW.Size = new Size(151, 45);
            ComboBoxW.TabIndex = 8;
            // 
            // ListBoxT
            // 
            ListBoxT.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ListBoxT.FormattingEnabled = true;
            ListBoxT.Items.AddRange(new object[] { "0,001", "0,1", "10", "100", "1000", "10000" });
            ListBoxT.Location = new Point(312, 77);
            ListBoxT.Name = "ListBoxT";
            ListBoxT.Size = new Size(151, 226);
            ListBoxT.TabIndex = 9;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Checked = true;
            RadioButton1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RadioButton1.Location = new Point(540, 57);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(213, 41);
            RadioButton1.TabIndex = 10;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "УРАВНЕНИЕ 1";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RadioButton2.Location = new Point(540, 104);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(213, 41);
            RadioButton2.TabIndex = 11;
            RadioButton2.Text = "УРАВНЕНИЕ 2";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonCalculate.Location = new Point(28, 317);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(254, 89);
            ButtonCalculate.TabIndex = 12;
            ButtonCalculate.Text = "CALCULATE";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // LabelZoo
            // 
            LabelZoo.AutoSize = true;
            LabelZoo.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelZoo.Location = new Point(352, 343);
            LabelZoo.Name = "LabelZoo";
            LabelZoo.Size = new Size(63, 37);
            LabelZoo.TabIndex = 13;
            LabelZoo.Text = "Zoo";
            // 
            // TextBoxZoo
            // 
            TextBoxZoo.BorderStyle = BorderStyle.None;
            TextBoxZoo.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextBoxZoo.Location = new Point(421, 343);
            TextBoxZoo.Name = "TextBoxZoo";
            TextBoxZoo.Size = new Size(332, 37);
            TextBoxZoo.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxZoo);
            Controls.Add(LabelZoo);
            Controls.Add(ButtonCalculate);
            Controls.Add(RadioButton2);
            Controls.Add(RadioButton1);
            Controls.Add(ListBoxT);
            Controls.Add(ComboBoxW);
            Controls.Add(TextBoxN);
            Controls.Add(TextBoxX);
            Controls.Add(TextBoxY);
            Controls.Add(LabelT);
            Controls.Add(LabelW);
            Controls.Add(LabelN);
            Controls.Add(LabelY);
            Controls.Add(LabelX);
            Name = "Form1";
            Text = "Задание №1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelX;
        private Label LabelY;
        private Label LabelN;
        private Label LabelW;
        private Label LabelT;
        private TextBox TextBoxY;
        private TextBox TextBoxX;
        private TextBox TextBoxN;
        private ComboBox ComboBoxW;
        private ListBox ListBoxT;
        private RadioButton RadioButton1;
        private RadioButton RadioButton2;
        private Button ButtonCalculate;
        private Label LabelZoo;
        private TextBox TextBoxZoo;
    }
}
