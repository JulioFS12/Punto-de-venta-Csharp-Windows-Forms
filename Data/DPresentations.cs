using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DPresentations
    {
        private int _Idpresentation;
        private string _Name;
        private string _Description;
        private string _TextSearch;

        public int Idpresentation
        {
            get { return _Idpresentation; }
            set { _Idpresentation = value; }
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
        public DPresentations()
        {

        }
        //Constructor con parámetros
        public DPresentations(int idpresentation, string name, string description, string textsearch)
        {
            this.Idpresentation = idpresentation;
            this.Name = name;
            this.Description = description;
            this.TextSearch = textsearch;

        }


        //Método Insertar

        public string Insert(DPresentations Presentations)
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
                SqlCmd.CommandText = "insertar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentations = new SqlParameter();
                ParIdpresentations.ParameterName = "@id_presentacion";
                ParIdpresentations.SqlDbType = SqlDbType.Int;
                ParIdpresentations.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpresentations);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 100;
                ParName.Value = Presentations.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@descripcion";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 256;
                ParDescription.Value = Presentations.Description;
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
        public string Edit(DPresentations Presentations)
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
                SqlCmd.CommandText = "editar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentations = new SqlParameter();
                ParIdpresentations.ParameterName = "@id_presentacion";
                ParIdpresentations.SqlDbType = SqlDbType.Int;
                ParIdpresentations.Value = Presentations.Idpresentation;
                SqlCmd.Parameters.Add(ParIdpresentations);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 100;
                ParName.Value = Presentations.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@descripcion";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 256;
                ParDescription.Value = Presentations.Description;
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
        public string Delete(DPresentations Presentations)
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
                SqlCmd.CommandText = "eliminar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentations = new SqlParameter();
                ParIdpresentations.ParameterName = "@id_presentacion";
                ParIdpresentations.SqlDbType = SqlDbType.Int;
                ParIdpresentations.Value = Presentations.Idpresentation;
                SqlCmd.Parameters.Add(ParIdpresentations);


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
            DataTable DtResultado = new DataTable("presentacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_presentacion";
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
        public DataTable Search(DPresentations Presentations)
        {
            DataTable DtResultado = new DataTable("presentacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_presentacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextSearch = new SqlParameter();
                ParTextSearch.ParameterName = "@textobuscar";
                ParTextSearch.SqlDbType = SqlDbType.VarChar;
                ParTextSearch.Size = 100;
                ParTextSearch.Value = Presentations.TextSearch;
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
