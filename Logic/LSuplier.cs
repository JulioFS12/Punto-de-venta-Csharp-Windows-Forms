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
    public class LSuplier
    {
        //Método Insertar que llama al método Insertar de la clase DCategoría
        //de la CapaDatos
        public static string Insert(string registered_name, string comercial_sector, string document_type, string documentnumber, string address, string number_phone, string email, string web)
        {
            DSuplier Obj = new DSuplier();
            Obj.RegisteredName = registered_name;
            Obj.ComercialSector = comercial_sector;
            Obj.DocumentType = document_type;
            Obj.DocumentNumber = documentnumber;
            Obj.Address = address;
            Obj.NumberPhone = number_phone;
            Obj.Email = email;
            Obj.Web = web;
            return Obj.Insert(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCategoría
        //de la CapaDatos
        public static string Edit(int idsuplier, string registered_name, string comercial_sector, string document_type, string documentnumber, string address, string number_phone, string email, string web)
        {
            DSuplier Obj = new DSuplier();
            Obj.IdSuplier = idsuplier;
            Obj.RegisteredName = registered_name;
            Obj.ComercialSector = comercial_sector;
            Obj.DocumentType = document_type;
            Obj.DocumentNumber = documentnumber;
            Obj.Address = address;
            Obj.NumberPhone = number_phone;
            Obj.Email = email;
            Obj.Web = web;
            return Obj.Edit(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoría
        //de la CapaDatos
        public static string Delete(int idsuplier)
        {
            DSuplier Obj = new DSuplier();
            Obj.IdSuplier = idsuplier;
            return Obj.Delete(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCategoría
        //de la CapaDatos
        public static DataTable Show()
        {
            return new DSuplier().Show();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DCategoría de la CapaDatos

        public static DataTable Search(string textsearch)
        {
            DSuplier Obj = new DSuplier();
            Obj.TextSearch = textsearch;
            return Obj.Search(Obj);
        }
    }
}
