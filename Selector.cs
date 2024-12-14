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
    public partial class Selector : Form
    {
        public string seleccion;
        public Selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
