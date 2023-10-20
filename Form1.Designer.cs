namespace Práctica__7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("RomanT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 282);
            button1.Name = "button1";
            button1.Size = new Size(236, 48);
            button1.TabIndex = 0;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(188, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 38);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 36);
            label1.TabIndex = 2;
            label1.Text = "Datos";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("RomanT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(330, 282);
            button2.Name = "button2";
            button2.Size = new Size(238, 48);
            button2.TabIndex = 3;
            button2.Text = "Centígrados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("RomanT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(188, 355);
            button3.Name = "button3";
            button3.Size = new Size(236, 48);
            button3.TabIndex = 4;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(39, 200);
            label2.Name = "label2";
            label2.Size = new Size(236, 36);
            label2.TabIndex = 5;
            label2.Text = "Opciones de conversión";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(39, 425);
            label3.Name = "label3";
            label3.Size = new Size(204, 36);
            label3.TabIndex = 6;
            label3.Text = "Resultado en grados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(197, 481);
            label4.Name = "label4";
            label4.Size = new Size(194, 33);
            label4.TabIndex = 7;
            label4.Text = "Equivalente en grados";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(39, 97);
            label6.Name = "label6";
            label6.Size = new Size(130, 33);
            label6.TabIndex = 9;
            label6.Text = "Ingresa Valor:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(238, 531);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 38);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(625, 628);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBox2;
    }
}