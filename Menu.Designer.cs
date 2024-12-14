namespace MultiBD
{
    partial class Menu
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
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(12, 98);
            button2.Name = "button2";
            button2.Size = new Size(241, 70);
            button2.TabIndex = 3;
            button2.Text = "Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(241, 67);
            button1.TabIndex = 2;
            button1.Text = "Pizzeria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 183);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
    }
}