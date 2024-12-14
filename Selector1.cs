using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBD
{
    public partial class Selector1 : Form
    {
        public string seleccion;

        public Selector1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                seleccion = "Relacional";
            }
            else
            {
                seleccion = "Orientada a Objetos";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}