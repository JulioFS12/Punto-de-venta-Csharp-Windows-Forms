 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DCategory
    {
        private int _Idcategory;
        private string _Name;
        private string _Description;
        private string _TextSearch;

        public int Idcategory
        {
            get { return _Idcategory; }
            set { _Idcategory = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public string TextSearch
        {
            get { return _TextSearch; }
            set { _TextSearch = value; }
        }

        //Constructor Vacío
        public DCategory()
        {

        }
        //Constructor con parámetros
        public DCategory(int idcategory, string name, string description, string textsearch)
        {
            this.Idcategory = idcategory;
            this.Name = name;
            this.Description = description;
            this.TextSearch = textsearch;

        }


        //Método Insertar

        public string Insert(DCategory Category)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Connection.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategory = new SqlParameter();
                ParIdcategory.ParameterName = "@id_categoria";
                ParIdcategory.SqlDbType = SqlDbType.Int;
                ParIdcategory.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcategory);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 100;
                ParName.Value = Category.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@descripcion";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 256;
                ParDescription.Value = Category.Description;
                SqlCmd.Parameters.Add(ParDescription);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        //Método Editar
        public string Edit(DCategory Category)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Connection.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "editar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@id_categoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Category.Idcategory;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Category.Name;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@descripcion";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 256;
                ParDescription.Value = Category.Description;
                SqlCmd.Parameters.Add(ParDescription);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Delete(DCategory Category)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Connection.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategory = new SqlParameter();
                ParIdcategory.ParameterName = "@id_categoria";
                ParIdcategory.SqlDbType = SqlDbType.Int;
                ParIdcategory.Value = Category.Idcategory;
                SqlCmd.Parameters.Add(ParIdcategory);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar
        public DataTable Show()
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método BuscarNombre
        public DataTable Search(DCategory Category)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextSearch = new SqlParameter();
                ParTextSearch.ParameterName = "@textobuscar";
                ParTextSearch.SqlDbType = SqlDbType.VarChar;
                ParTextSearch.Size = 100;
                ParTextSearch.Value = Category.TextSearch;
                SqlCmd.Parameters.Add(ParTextSearch);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
