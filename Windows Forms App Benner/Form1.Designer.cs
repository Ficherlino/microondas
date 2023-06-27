namespace Windows_Forms_App_Benner
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
            textBox1 = new TextBox();
            button1 = new Button();
            buttonIniciar = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(345, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Tempo";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(345, 139);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(423, 245);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(69, 29);
            buttonIniciar.TabIndex = 3;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(384, 139);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 4;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(423, 139);
            button4.Name = "button4";
            button4.Size = new Size(33, 29);
            button4.TabIndex = 5;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(423, 174);
            button5.Name = "button5";
            button5.Size = new Size(33, 29);
            button5.TabIndex = 8;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(384, 174);
            button6.Name = "button6";
            button6.Size = new Size(33, 29);
            button6.TabIndex = 7;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(345, 174);
            button7.Name = "button7";
            button7.Size = new Size(33, 29);
            button7.TabIndex = 6;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button4_Click;
            // 
            // button8
            // 
            button8.Location = new Point(423, 209);
            button8.Name = "button8";
            button8.Size = new Size(33, 29);
            button8.TabIndex = 11;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button9_Click;
            // 
            // button9
            // 
            button9.Location = new Point(384, 209);
            button9.Name = "button9";
            button9.Size = new Size(33, 29);
            button9.TabIndex = 10;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button8_Click;
            // 
            // button10
            // 
            button10.Location = new Point(345, 209);
            button10.Name = "button10";
            button10.Size = new Size(33, 29);
            button10.TabIndex = 9;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button7_Click;
            // 
            // button11
            // 
            button11.Location = new Point(384, 245);
            button11.Name = "button11";
            button11.Size = new Size(33, 29);
            button11.TabIndex = 12;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button0_Click;
            // 
            // button2
            // 
            button2.Location = new Point(309, 245);
            button2.Name = "button2";
            button2.Size = new Size(69, 29);
            button2.TabIndex = 13;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += botaoClear;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(815, 389);
            Controls.Add(button2);
            Controls.Add(button11);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonIniciar);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button buttonIniciar;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button2;
    }
}