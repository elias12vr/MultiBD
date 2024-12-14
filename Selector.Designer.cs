namespace MultiBD
{
    partial class Selector
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 61);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(217, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "México (Relacional)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 101);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(298, 34);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Japón (Orientada a Objetos)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(110, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 182);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elige la BD:";
            // 
            // button1
            // 
            button1.Location = new Point(313, 291);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 3;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Selector
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 373);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Selector";
            Text = "Selector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Button button1;
    }
}