using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Data
{
    public class DPersonal
    {
        private int _IdWorker;
        private string _Name;
        private string _SecondName;
        private string _DocumentType;
        private string _NumberDocument;
        private string _User;
        private string _Password;
        private byte[] _Photo;
        private string _TextSearch;
        private string _Position;
        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        public byte[] Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        }
        public string TextSearch
        {
          get { return _TextSearch; }
          set { _TextSearch = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        public string NumberDocument
        {
            get { return _NumberDocument; }
            set { _NumberDocument = value; }
        }
        public string DocumentType
        {
            get { return _DocumentType; }
            set { _DocumentType = value; }
        }
        public string SecondName
        {
            get { return _SecondName; }
            set { _SecondName = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int IdWorker
        {
            get { return _IdWorker; }
            set { _IdWorker = value; }
        }

        public DPersonal()
        {

        }

        public DPersonal(int idworker, string name, string second_name, string document_type, string number_document, string user, string password,string postion, byte[] photo,
            string textsearch)
        {
            this.IdWorker = idworker;
            this.Name = Name;
            this.SecondName = second_name;
            this.DocumentType = document_type;
            this.NumberDocument = number_document;
            this.User = user;
            this.Password = password;
            this.Position = postion;
            this.Photo = photo;
            this.TextSearch = textsearch;
        }

        //Método Insertar

        public string Insert(DPersonal Personal)
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
                SqlCmd.CommandText = "insertar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproduct = new SqlParameter();
                ParIdproduct.ParameterName = "@id_trabajador";
                ParIdproduct.SqlDbType = SqlDbType.Int;
                ParIdproduct.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdproduct);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Personal.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParSeconName = new SqlParameter();
                ParSeconName.ParameterName = "@apellido";
                ParSeconName.SqlDbType = SqlDbType.VarChar;
                ParSeconName.Size = 50;
                ParSeconName.Value = Personal.SecondName;
                SqlCmd.Parameters.Add(ParSeconName);

                SqlParameter ParDocumentType = new SqlParameter();
                ParDocumentType.ParameterName = "@tipo_documento";
                ParDocumentType.SqlDbType = SqlDbType.VarChar;
                ParDocumentType.Size = 50;
                ParDocumentType.Value = Personal.DocumentType;
                SqlCmd.Parameters.Add(ParDocumentType);

                SqlParameter ParDocumentNumber = new SqlParameter();
                ParDocumentNumber.ParameterName = "@numero_documento";
                ParDocumentNumber.SqlDbType = SqlDbType.VarChar;
                ParDocumentNumber.Size = 50;
                ParDocumentNumber.Value = Personal.NumberDocument;
                SqlCmd.Parameters.Add(ParDocumentNumber);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@usuario";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Personal.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@contraseña";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Personal.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParPosition = new SqlParameter();
                ParPosition.ParameterName = "@cargo";
                ParPosition.SqlDbType = SqlDbType.VarChar;
                ParPosition.Size = 50;
                ParPosition.Value = Personal.Position;
                SqlCmd.Parameters.Add(ParPosition);

                SqlParameter ParPhoto = new SqlParameter();
                ParPhoto.ParameterName = "@foto";
                ParPhoto.SqlDbType = SqlDbType.Image;
                ParPhoto.Value = Personal.Photo;
                SqlCmd.Parameters.Add(ParPhoto);

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
        public string Edit(DPersonal Personal)
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
                SqlCmd.CommandText = "editar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdWorker = new SqlParameter();
                ParIdWorker.ParameterName = "@id_trabajador";
                ParIdWorker.SqlDbType = SqlDbType.Int;
                ParIdWorker.Value = Personal.IdWorker;
                SqlCmd.Parameters.Add(ParIdWorker);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Personal.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParSeconName = new SqlParameter();
                ParSeconName.ParameterName = "@apellido";
                ParSeconName.SqlDbType = SqlDbType.VarChar;
                ParSeconName.Size = 50;
                ParSeconName.Value = Personal.SecondName;
                SqlCmd.Parameters.Add(ParSeconName);

                SqlParameter ParDocumentType = new SqlParameter();
                ParDocumentType.ParameterName = "@tipo_documento";
                ParDocumentType.SqlDbType = SqlDbType.VarChar;
                ParDocumentType.Size = 50;
                ParDocumentType.Value = Personal.DocumentType;
                SqlCmd.Parameters.Add(ParDocumentType);

                SqlParameter ParDocumentNumber = new SqlParameter();
                ParDocumentNumber.ParameterName = "@numero_documento";
                ParDocumentNumber.SqlDbType = SqlDbType.VarChar;
                ParDocumentNumber.Size = 50;
                ParDocumentNumber.Value = Personal.NumberDocument;
                SqlCmd.Parameters.Add(ParDocumentNumber);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@usuario";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Personal.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@contraseña";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Personal.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParPhoto = new SqlParameter();
                ParPhoto.ParameterName = "@foto";
                ParPhoto.SqlDbType = SqlDbType.Image;
                ParPhoto.Value = Personal.Photo;
                SqlCmd.Parameters.Add(ParPhoto);

                SqlParameter ParPosition = new SqlParameter();
                ParPosition.ParameterName = "@cargo";
                ParPosition.SqlDbType = SqlDbType.VarChar;
                ParPosition.Size = 50;
                ParPosition.Value = Personal.Position;
                SqlCmd.Parameters.Add(ParPosition);

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
        public string Delete(DPersonal Personal)
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
                SqlCmd.CommandText = "eliminar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdWorker = new SqlParameter();
                ParIdWorker.ParameterName = "@textobuscar";
                ParIdWorker.SqlDbType = SqlDbType.Int;
                ParIdWorker.Value = Personal.IdWorker;
                SqlCmd.Parameters.Add(ParIdWorker);


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
            DataTable DtResultado = new DataTable("trabajador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_trabajador";
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
        public DataTable Search(DPersonal Personal)
        {
            DataTable DtResultado = new DataTable("trabajador");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextSearch = new SqlParameter();
                ParTextSearch.ParameterName = "@textobuscar";
                ParTextSearch.SqlDbType = SqlDbType.VarChar;
                ParTextSearch.Size = 50;
                ParTextSearch.Value = Personal.TextSearch;
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
