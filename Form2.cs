using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o.NativeQueries;
using Db4objects.Db4o.Query;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace MultiBD
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader lector;
        DataTable tabla;
        IObjectContainer bd;
        IObjectSet res;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Data source = localhost; Initial catalog = Pizzas; Integrated security = True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selector sel = new Selector();
            if (sel.ShowDialog() == DialogResult.OK)
            {
                string seleccion = sel.seleccion;
                if (seleccion == "Relacional")
                {
                    con.Open();
                    com = new SqlCommand();
                    com.CommandType = CommandType.Text;
                    com.CommandText = "insert into Clientes values ('" +
                        textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
                    com.Connection = con;
                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Registro exitoso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    bd = Db4oEmbedded.OpenFile("Clientes.txt");
                    Clientes c = new Clientes();
                    c.Alta(textBox1.Text, textBox2.Text,
                            textBox3.Text, textBox4.Text,
                            textBox5.Text, textBox6.Text);
                    bd.Store(c);
                    bd.Commit();
                    MessageBox.Show("Registro exitoso!");
                    bd.Close();
                }
            }
            limpiar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Clientes where id_cliente=" + textBox1.Text;
            com.Connection = con;
            limpiar();
            try
            {
                lector = com.ExecuteReader();
                while (lector.Read())
                {
                    textBox1.Text = lector.GetString(0);
                    textBox2.Text = lector.GetString(1);
                    textBox3.Text = lector.GetString(2);
                    textBox4.Text = lector.GetString(3);
                    textBox5.Text = lector.GetString(4);
                    textBox6.Text = lector.GetString(5);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            bd = Db4oEmbedded.OpenFile("Clientes.txt");
            Clientes bus = new Clientes(textBox1.Text);
            IObjectSet<Clientes> res = bd.QueryByExample(bus);

            foreach (Clientes item in res)
            {
                textBox1.Text = item.VerIdCliente();
                textBox2.Text = item.VerNombre();
                textBox3.Text = item.VerApellido();
                textBox4.Text = item.VerCorreo();
                textBox5.Text = item.VerTelefono();
                textBox6.Text = item.VerDireccion();
            }
            bd.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "UPDATE Clientes SET nombre = '" + textBox2.Text + "', apellido = '" + textBox3.Text + "', correo = '" + textBox4.Text + "', telefono = '" + textBox5.Text + "', direccion = '" + textBox6.Text + "';";

            com.Connection = con;
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Dato actualizados...");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            bd = Db4oEmbedded.OpenFile("Clientes.txt");
            Clientes bus = new Clientes(textBox1.Text);
            IObjectSet<Clientes> res = bd.QueryByExample(bus);

            foreach (Clientes item in res)
            {
                item.Editar(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                bd.Store(item);
                MessageBox.Show("Datos actualizados...");
            }
            bd.Commit();
            bd.Close();
            limpiar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "DELETE FROM Clientes WHERE id_cliente = '" + textBox1.Text + "';";
            com.Connection = con;
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Datos eliminados...");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            bd = Db4oEmbedded.OpenFile("Clientes.txt");
            IObjectSet<Clientes> res = bd.QueryByExample(new Clientes(textBox1.Text));
            try
            {
                Clientes item = (Clientes)res.Next();
                bd.Delete(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.Close();
            }

        }

        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

    }
}
