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
    public class LRegister
    {

        public static string Insert(string serial)
        {
            Register Obj = new Register();
            Obj.Serial = serial;
            return Obj.Insert(Obj);
        }

        public static DataTable ValidarActivacion()
        {
            return new Register().Mostrar();
        }

        public static DataTable ValidarSerial(string serial)
        {
            Register Obj = new Register();
            Obj.Serial = serial;
            return Obj.ValidarSerial(Obj);
        }
    }
}
