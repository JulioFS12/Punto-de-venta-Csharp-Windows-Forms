using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DSuplier
    {
        private int _IdSuplier;
        private string _RegisteredName;
        private string _ComercialSector;
        private string _DocumentType;
        private string _DocumentNumber;
        private string _Address;
        private string _NumberPhone;
        private string _Email;
        private string _Web;
        private string _TextSearch;

        public string TextSearch
        {
            get { return _TextSearch; }
            set { _TextSearch = value; }
        }

        public string Web
        {
            get { return _Web; }
            set { _Web = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string NumberPhone
        {
            get { return _NumberPhone; }
            set { _NumberPhone = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string DocumentNumber
        {
            get { return _DocumentNumber; }
            set { _DocumentNumber = value; }
        }
        public string DocumentType
        {
            get { return _DocumentType; }
            set { _DocumentType = value; }
        }
        public string ComercialSector
        {
            get { return _ComercialSector; }
            set { _ComercialSector = value; }
        }
        public string RegisteredName
        {
            get { return _RegisteredName; }
            set { _RegisteredName = value; }
        }
        public int IdSuplier
        {
            get { return _IdSuplier; }
            set { _IdSuplier = value; }
        }

        public DSuplier()
        {

        }

        public DSuplier(int idsuplier, string registered_name, string comercial_sector, string document_type, string documentnumber, string address, string number_phone, string email, string web, string textsearch )
        {
            this.IdSuplier = idsuplier;
            this.RegisteredName = registered_name;
            this.ComercialSector = comercial_sector;
            this.DocumentType = document_type;
            this.DocumentNumber = documentnumber;
            this.Address = address;
            this.NumberPhone = number_phone;
            this.Email = email;
            this.Web = web;
            this.TextSearch = textsearch;
        }

        //Método Insertar

        public string Insert(DSuplier Suplier)
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
                SqlCmd.CommandText = "insertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdsuplier = new SqlParameter();
                ParIdsuplier.ParameterName = "@id_proveedor";
                ParIdsuplier.SqlDbType = SqlDbType.Int;
                ParIdsuplier.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdsuplier);

                SqlParameter ParRegisteredName = new SqlParameter();
                ParRegisteredName.ParameterName = "@razon_social";
                ParRegisteredName.SqlDbType = SqlDbType.VarChar;
                ParRegisteredName.Size = 50;
                ParRegisteredName.Value = Suplier.RegisteredName;
                SqlCmd.Parameters.Add(ParRegisteredName);

                SqlParameter ParComercialSector = new SqlParameter();
                ParComercialSector.ParameterName = "@sector_comercial";
                ParComercialSector.SqlDbType = SqlDbType.VarChar;
                ParComercialSector.Size = 50;
                ParComercialSector.Value = Suplier.ComercialSector;
                SqlCmd.Parameters.Add(ParComercialSector);

                SqlParameter ParDocumentType = new SqlParameter();
                ParDocumentType.ParameterName = "@tipo_documento";
                ParDocumentType.SqlDbType = SqlDbType.VarChar;
                ParDocumentType.Size = 50;
                ParDocumentType.Value = Suplier.DocumentType;
                SqlCmd.Parameters.Add(ParDocumentType);

                SqlParameter ParDocumentNumber = new SqlParameter();
                ParDocumentNumber.ParameterName = "@numero";
                ParDocumentNumber.SqlDbType = SqlDbType.VarChar;
                ParDocumentNumber.Size = 50;
                ParDocumentNumber.Value = Suplier.DocumentNumber;
                SqlCmd.Parameters.Add(ParDocumentNumber);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 50;
                ParAddress.Value = Suplier.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParNumberPhone = new SqlParameter();
                ParNumberPhone.ParameterName = "@telefono";
                ParNumberPhone.SqlDbType = SqlDbType.VarChar;
                ParNumberPhone.Size = 50;
                ParNumberPhone.Value = Suplier.NumberPhone;
                SqlCmd.Parameters.Add(ParNumberPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Suplier.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParWeb = new SqlParameter();
                ParWeb.ParameterName = "@web";
                ParWeb.SqlDbType = SqlDbType.VarChar;
                ParWeb.Size = 50;
                ParWeb.Value = Suplier.Web;
                SqlCmd.Parameters.Add(ParWeb);

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
        public string Edit(DSuplier Suplier)
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
                SqlCmd.CommandText = "editar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdSuplier = new SqlParameter();
                ParIdSuplier.ParameterName = "@id_proveedor";
                ParIdSuplier.SqlDbType = SqlDbType.Int;
                ParIdSuplier.Value = Suplier.IdSuplier;
                SqlCmd.Parameters.Add(ParIdSuplier);

                SqlParameter ParRegisteredName = new SqlParameter();
                ParRegisteredName.ParameterName = "@razon_social";
                ParRegisteredName.SqlDbType = SqlDbType.VarChar;
                ParRegisteredName.Size = 50;
                ParRegisteredName.Value = Suplier.RegisteredName;
                SqlCmd.Parameters.Add(ParRegisteredName);

                SqlParameter ParComercialSector = new SqlParameter();
                ParComercialSector.ParameterName = "@sector_comercial";
                ParComercialSector.SqlDbType = SqlDbType.VarChar;
                ParComercialSector.Size = 50;
                ParComercialSector.Value = Suplier.ComercialSector;
                SqlCmd.Parameters.Add(ParComercialSector);

                SqlParameter ParDocumentType = new SqlParameter();
                ParDocumentType.ParameterName = "@tipo_documento";
                ParDocumentType.SqlDbType = SqlDbType.VarChar;
                ParDocumentType.Size = 50;
                ParDocumentType.Value = Suplier.DocumentType;
                SqlCmd.Parameters.Add(ParDocumentType);

                SqlParameter ParDocumentNumber = new SqlParameter();
                ParDocumentNumber.ParameterName = "@numero";
                ParDocumentNumber.SqlDbType = SqlDbType.VarChar;
                ParDocumentNumber.Size = 50;
                ParDocumentNumber.Value = Suplier.DocumentNumber;
                SqlCmd.Parameters.Add(ParDocumentNumber);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 50;
                ParAddress.Value = Suplier.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParNumberPhone = new SqlParameter();
                ParNumberPhone.ParameterName = "@telefono";
                ParNumberPhone.SqlDbType = SqlDbType.VarChar;
                ParNumberPhone.Size = 50;
                ParNumberPhone.Value = Suplier.NumberPhone;
                SqlCmd.Parameters.Add(ParNumberPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Suplier.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParWeb = new SqlParameter();
                ParWeb.ParameterName = "@web";
                ParWeb.SqlDbType = SqlDbType.VarChar;
                ParWeb.Size = 50;
                ParWeb.Value = Suplier.Web;
                SqlCmd.Parameters.Add(ParWeb);

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
        public string Delete(DSuplier Suplier)
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
                SqlCmd.CommandText = "eliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdSuplier = new SqlParameter();
                ParIdSuplier.ParameterName = "@id_proveedor";
                ParIdSuplier.SqlDbType = SqlDbType.Int;
                ParIdSuplier.Value = Suplier.IdSuplier;
                SqlCmd.Parameters.Add(ParIdSuplier);


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
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_proveedor";
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
        public DataTable Search(DSuplier Suplier)
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextSearch = new SqlParameter();
                ParTextSearch.ParameterName = "@textobuscar";
                ParTextSearch.SqlDbType = SqlDbType.VarChar;
                ParTextSearch.Size = 50;
                ParTextSearch.Value = Suplier.TextSearch;
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
