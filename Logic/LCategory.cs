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
    public class LCategory
    {
        //Método Insertar que llama al método Insertar de la clase DCategoría
        //de la CapaDatos
        public static string Insert(string name, string description)
        {
            DCategory Obj = new DCategory();
            Obj.Name = name;
            Obj.Description = description;
            return Obj.Insert(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCategoría
        //de la CapaDatos
        public static string Edit(int idcategory, string name, string description)
        {
            DCategory Obj = new DCategory();
            Obj.Idcategory = idcategory;
            Obj.Name = name;
            Obj.Description = description;
            return Obj.Edit(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoría
        //de la CapaDatos
        public static string Delete(int idcategory)
        {
            DCategory Obj = new DCategory();
            Obj.Idcategory = idcategory;
            return Obj.Delete(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCategoría
        //de la CapaDatos
        public static DataTable Show()
        {
            return new DCategory().Show();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DCategoría de la CapaDatos

        public static DataTable Search(string textsearch)
        {
            DCategory Obj = new DCategory();
            Obj.TextSearch = textsearch;
            return Obj.Search(Obj);
        }
    }
}
