namespace TempConv
{
    partial class tempConv
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
            lbl_Input = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_Output = new Label();
            combo_In = new ComboBox();
            combo_Out = new ComboBox();
            lbl_Formula = new Label();
            btn_Invert = new Button();
            button2 = new Button();
            btn_Dot = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            btn_Delete = new Button();
            ClearBotton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(330, 24);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 0;
            label1.Text = "Temperature Converter";
            // 
            // lbl_Input
            // 
            lbl_Input.AutoSize = true;
            lbl_Input.Location = new Point(193, 131);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(141, 20);
            lbl_Input.TabIndex = 1;
            lbl_Input.Text = "Input text goes here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 191);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 267);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 3;
            label4.Text = "To:";
            // 
            // lbl_Output
            // 
            lbl_Output.AutoSize = true;
            lbl_Output.Location = new Point(193, 365);
            lbl_Output.Name = "lbl_Output";
            lbl_Output.Size = new Size(162, 20);
            lbl_Output.TabIndex = 4;
            lbl_Output.Text = "Output: Text Goes Here";
            // 
            // combo_In
            // 
            combo_In.FormattingEnabled = true;
            combo_In.Location = new Point(193, 215);
            combo_In.Margin = new Padding(3, 4, 3, 4);
            combo_In.Name = "combo_In";
            combo_In.Size = new Size(138, 28);
            combo_In.TabIndex = 5;
            combo_In.SelectedIndexChanged += selectedItemChanged;
            // 
            // combo_Out
            // 
            combo_Out.FormattingEnabled = true;
            combo_Out.Location = new Point(193, 291);
            combo_Out.Margin = new Padding(3, 4, 3, 4);
            combo_Out.Name = "combo_Out";
            combo_Out.Size = new Size(138, 28);
            combo_Out.TabIndex = 6;
            combo_Out.SelectedIndexChanged += selectedItemChanged;
            // 
            // lbl_Formula
            // 
            lbl_Formula.AutoSize = true;
            lbl_Formula.Location = new Point(193, 516);
            lbl_Formula.Name = "lbl_Formula";
            lbl_Formula.Size = new Size(312, 20);
            lbl_Formula.TabIndex = 7;
            lbl_Formula.Text = "Formula goes here (optional implementation)";
            // 
            // btn_Invert
            // 
            btn_Invert.Location = new Point(592, 416);
            btn_Invert.Margin = new Padding(3, 4, 3, 4);
            btn_Invert.Name = "btn_Invert";
            btn_Invert.Size = new Size(58, 65);
            btn_Invert.TabIndex = 8;
            btn_Invert.Text = "+ / -";
            btn_Invert.UseVisualStyleBackColor = true;
            btn_Invert.Click += button_Invert_Click;
            // 
            // button2
            // 
            button2.Location = new Point(657, 416);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(58, 65);
            button2.TabIndex = 9;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClick;
            // 
            // btn_Dot
            // 
            btn_Dot.Location = new Point(722, 416);
            btn_Dot.Margin = new Padding(3, 4, 3, 4);
            btn_Dot.Name = "btn_Dot";
            btn_Dot.Size = new Size(58, 65);
            btn_Dot.TabIndex = 11;
            btn_Dot.Text = ".";
            btn_Dot.UseVisualStyleBackColor = true;
            btn_Dot.Click += buttonClick;
            // 
            // button4
            // 
            button4.Location = new Point(722, 343);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(58, 65);
            button4.TabIndex = 14;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.Location = new Point(657, 343);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(58, 65);
            button5.TabIndex = 13;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.Location = new Point(592, 343);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(58, 65);
            button6.TabIndex = 12;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.Location = new Point(722, 269);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(58, 65);
            button7.TabIndex = 17;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.Location = new Point(657, 269);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(58, 65);
            button8.TabIndex = 16;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.Location = new Point(592, 269);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(58, 65);
            button9.TabIndex = 15;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonClick;
            // 
            // button10
            // 
            button10.Location = new Point(722, 196);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(58, 65);
            button10.TabIndex = 20;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonClick;
            // 
            // button11
            // 
            button11.Location = new Point(657, 196);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(58, 65);
            button11.TabIndex = 19;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonClick;
            // 
            // button12
            // 
            button12.Location = new Point(592, 196);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(58, 65);
            button12.TabIndex = 18;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonClick;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(592, 123);
            btn_Delete.Margin = new Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(123, 65);
            btn_Delete.TabIndex = 21;
            btn_Delete.Text = "Del";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // ClearBotton
            // 
            ClearBotton.Location = new Point(721, 123);
            ClearBotton.Name = "ClearBotton";
            ClearBotton.Size = new Size(59, 65);
            ClearBotton.TabIndex = 22;
            ClearBotton.Text = "Clear";
            ClearBotton.UseVisualStyleBackColor = true;
            ClearBotton.Click += button_clear;
            // 
            // tempConv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ClearBotton);
            Controls.Add(btn_Delete);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(btn_Dot);
            Controls.Add(button2);
            Controls.Add(btn_Invert);
            Controls.Add(lbl_Formula);
            Controls.Add(combo_Out);
            Controls.Add(combo_In);
            Controls.Add(lbl_Output);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_Input);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "tempConv";
            Text = "Form1";
            Load += tempConv_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Input;
        private Label label3;
        private Label label4;
        private Label lbl_Output;
        private ComboBox combo_In;
        private ComboBox combo_Out;
        private Label lbl_Formula;
        private Button btn_Invert;
        private Button button2;
        private Button btn_Dot;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btn_Delete;
        private Button ClearBotton;
    }
}
