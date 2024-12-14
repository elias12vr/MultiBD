namespace MultiBD
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 35);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 93);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 120);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "CORREO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 151);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 180);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 5;
            label6.Text = "DIRECCION";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(141, 143);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(141, 172);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(170, 23);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(364, 26);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 12;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(364, 69);
            button2.Name = "button2";
            button2.Size = new Size(126, 37);
            button2.TabIndex = 13;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(364, 113);
            button3.Name = "button3";
            button3.Size = new Size(126, 36);
            button3.TabIndex = 14;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(364, 155);
            button4.Name = "button4";
            button4.Size = new Size(126, 40);
            button4.TabIndex = 15;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 244);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}