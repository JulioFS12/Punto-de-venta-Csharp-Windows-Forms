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
    public class LLogin
    {
        public static DataTable Login(string usuario, string password)
        {
            DLogin Obj = new DLogin();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
    }
}
