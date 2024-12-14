using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiBD
{
    internal class Pizzas
    {
        int codigo;
        string tipo;
        string ingredientes;
        string tamano;
        int rebanadas;
        double precio;

        public Pizzas()
        {
            codigo = 0;
            tipo = "Napolitana";
            ingredientes = "Tomate, albahaca, mozzarella, aceite de oliva";
            tamano = "Grande";
            rebanadas = 12;
            precio = 250.00;
        }

        public Pizzas(int cod)
        {
            codigo = cod;
        }

        public void Alta(int cod, string tip, string ing, string tam, int reb, double pre)
        {
            codigo = cod;
            tipo = tip;
            ingredientes = ing;
            tamano = tam;
            rebanadas = reb;
            precio = pre;
        }

        public void Editar(string tip, string ing, string tam, int reb, double pre)
        {
            tipo = tip;
            ingredientes = ing;
            tamano = tam;
            rebanadas = reb;
            precio = pre;
        }

        public void Baja()
        {
            codigo = 0;
            tipo = "";
            ingredientes = "";
            tamano = "";
            rebanadas = 0;
            precio = 0.00;
        }

        public int VerCodigo()
        {
            return codigo;
        }

        public string VerTipo()
        {
            return tipo;
        }

        public string VerIngredientes()
        { 
            return ingredientes;
        }

        public string VerTamano()
        { 
            return tamano; 
        }

        public int VerRebanadas()
        {
            return rebanadas;
        }

        public double VerPrecio() 
        {
            return precio;
        }

        internal void Alta(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            throw new NotImplementedException();
        }
    }
}
