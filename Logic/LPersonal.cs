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
    public class LPersonal
    {
        //Método Insertar que llama al método Insertar de la clase DCategoría
        //de la CapaDatos
        public static string Insert(string name, string second_name, string document_type, string number_document, string user, string password,byte[] photo, string position)
        {
            DPersonal Obj = new DPersonal();
            Obj.Name = name;
            Obj.SecondName = second_name;
            Obj.DocumentType = document_type;
            Obj.NumberDocument = number_document;
            Obj.User = user;
            Obj.Password = password;
            Obj.Position = position;
            Obj.Photo = photo;
            return Obj.Insert(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCategoría
        //de la CapaDatos
        public static string Edit(int idworker, string name, string second_name, string document_type, string number_document, string user, string password, byte[] photo, string position)
        {
            DPersonal Obj = new DPersonal();
            Obj.IdWorker = idworker;
            Obj.Name = name;
            Obj.SecondName = second_name;
            Obj.DocumentType = document_type;
            Obj.NumberDocument = number_document;
            Obj.User = user;
            Obj.Password = password;
            Obj.Position = position;
            Obj.Photo = photo;
            return Obj.Edit(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoría
        //de la CapaDatos
        public static string Delete(int idworker)
        {
            DPersonal Obj = new DPersonal();
            Obj.IdWorker = idworker;
            return Obj.Delete(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCategoría
        //de la CapaDatos
        public static DataTable Show()
        {
            return new DPersonal().Show();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DCategoría de la CapaDatos

        public static DataTable Search(string textsearch)
        {
            DPersonal Obj = new DPersonal();
            Obj.TextSearch = textsearch;
            return Obj.Search(Obj);
        }
    }
}
