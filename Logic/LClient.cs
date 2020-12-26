using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Logic
{
    public class LClient
    {
        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DCliente
        //de la CapaDatos
        public static string Insertar(string nombreya,string tipo_documento, string num_documento,
            string direccion, string telefono)
        {
            DClient Obj = new DClient();
            Obj.Nombreya = nombreya;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCliente
        //de la CapaDatos
        public static string Editar(int idcliente, string nombreya, string tipo_documento, string num_documento,
            string direccion, string telefono)
        {
            DClient Obj = new DClient();
            Obj.Idcliente = idcliente;
            Obj.Nombreya = nombreya;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCliente
        //de la CapaDatos
        public static string Eliminar(int idcliente)
        {
            DClient Obj = new DClient();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCliente
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DClient().Mostrar();
        }

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DClient Obj = new DClient();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
