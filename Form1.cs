using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o.NativeQueries;
using Db4objects.Db4o.Query;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic;

namespace MultiBD
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader lector;
        DataTable tabla;
        IObjectContainer bd;
        IObjectSet res;
        public Form1()
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
                    com.CommandText = "insert into Catalogo values (" +
                        Convert.ToInt32(textBox1.Text) + ", '" +
                        textBox2.Text + "', '" + textBox3.Text + "', '" +
                        textBox4.Text + "', " + Convert.ToInt32(
                        textBox5.Text) + ", " + Convert.ToDecimal(
                        textBox6.Text) + ")";
                    com.Connection = con;
                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Registro exitoso!");
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    bd = Db4oEmbedded.OpenFile("Pizzas.txt");
                    Pizzas p = new Pizzas();
                    p.Alta(Convert.ToInt32(textBox1.Text), textBox2.Text,
                            textBox3.Text, textBox4.Text, Convert.ToInt32(
                            textBox5.Text), Convert.ToDouble(textBox6.Text));
                    bd.Store(p);
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
            com.CommandText = "select * from Catalogo where codigo=" +
                Convert.ToInt32(textBox1.Text);
            com.Connection = con;
            int cod = Convert.ToInt32(textBox1.Text);
            limpiar();
            try
            {
                lector = com.ExecuteReader();
                while (lector.Read())
                {
                    textBox1.Text = lector.GetInt32(0).ToString();
                    textBox2.Text = lector.GetString(1);
                    textBox3.Text = lector.GetString(2);
                    textBox4.Text = lector.GetString(3);
                    textBox5.Text = lector.GetInt32(4).ToString();
                    textBox6.Text = lector.GetDecimal(5).ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
            bd = Db4oEmbedded.OpenFile("Pizzas.txt");
            cod = Convert.ToInt32(textBox1.Text);
            Pizzas bus = new Pizzas(cod);
            IObjectSet<Pizzas> res = bd.QueryByExample(bus);

            foreach (Pizzas item in res)
            {
                textBox1.Text = item.VerCodigo().ToString();
                textBox2.Text = item.VerTipo();
                textBox3.Text = item.VerIngredientes();
                textBox4.Text = item.VerTamano();
                textBox5.Text = item.VerRebanadas().ToString();
                textBox6.Text = item.VerPrecio().ToString();
            }
            bd.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Catalogo set tipo = '" + textBox2.Text +
                "', ingredientes ='" + textBox3.Text + "', tamano = '" +
                textBox4.Text + "', rebanadas = " + Convert.ToInt32(textBox5.Text) +
                ", precio = " + Convert.ToInt32(textBox6.Text);
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
            int cod;
            bd = Db4oEmbedded.OpenFile("Pizzas.txt");
            cod = Convert.ToInt32(textBox1.Text);
            Pizzas bus = new Pizzas(cod);
            IObjectSet<Pizzas> res = bd.QueryByExample(bus);

            foreach (Pizzas item in res)
            {
                item.Editar(textBox2.Text, textBox3.Text, textBox4.Text,
                    Convert.ToInt32(textBox5.Text), Convert.ToDouble(
                        textBox6.Text));
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
            com.CommandText = "delete from Catalogo where codigo = " +
                Convert.ToInt32(textBox1.Text);
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
            bd = Db4oEmbedded.OpenFile("Pizzas.txt");
            IObjectSet<Pizzas> res = bd.QueryByExample(new Pizzas (
                Convert.ToInt32(textBox1.Text)));
            try
            {
                Pizzas item = (Pizzas)res.Next();
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