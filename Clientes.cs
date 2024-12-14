using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBD
{
    internal class Clientes
    {
        string id_cliente;
        string nombre;
        string apellido;
        string correo;
        string telefono;
        string direccion;

        // Constructor por defecto
        public Clientes()
        {
            id_cliente = "1";
            nombre = "Elias";
            apellido = "Valdez";
            correo = "eliasvaldez567@gmail.com";
            telefono = "6761009851";
            direccion = "AntonioAmaro";
        }

        // Constructor con ID
        public Clientes(string id)
        {
            id_cliente = id;
        }

        // Método para alta de cliente
        public void Alta(string id, string nom, string ape, string mail, string tel, string dir)
        {
            id_cliente = id;
            nombre = nom;
            apellido = ape;
            correo = mail;
            telefono = tel;
            direccion = dir;
        }

        // Método para editar información del cliente
        public void Editar(string nom, string ape, string mail, string tel, string dir)
        {
            nombre = nom;
            apellido = ape;
            correo = mail;
            telefono = tel;
            direccion = dir;
        }

        // Método para eliminar la información del cliente
        public void Baja()
        {
            id_cliente = "";
            nombre = "";
            apellido = "";
            correo = "";
            telefono = "";
            direccion = "";
        }

        // Métodos para obtener la información
        public string VerIdCliente()
        {
            return id_cliente;
        }

        public string VerNombre()
        {
            return nombre;
        }

        public string VerApellido()
        {
            return apellido;
        }

        public string VerCorreo()
        {
            return correo;
        }

        public string VerTelefono()
        {
            return telefono;
        }

        public string VerDireccion()
        {
            return direccion;
        }
    }
}