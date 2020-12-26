using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DCashDesk
    {
        private int _IdCaja;
        private decimal _MontoInicial;
        private decimal _MontoFinal;
        private DateTime _Fecha;
        private decimal _Exento;
        private decimal _Iva;
        private decimal _Descuento;
        private int _NumeroCompras;
        private string _UltimaFactura;
        private decimal _Total;

        public decimal Total
            {
            get { return _Total; }
            set { _Total = value; }
             }
        public string UltimaFactura
        {
            get { return _UltimaFactura; }
            set { _UltimaFactura = value; }
        }
        public int NumeroCompras
        {
            get { return _NumeroCompras; }
            set { _NumeroCompras = value; }
        }
        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }
 
        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }
        public decimal Exento
        {
            get { return _Exento; }
            set { _Exento = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public decimal MontoFinal
        {
            get { return _MontoFinal; }
            set { _MontoFinal = value; }
        }
        public decimal MontoInicial
        {
            get { return _MontoInicial; }
            set { _MontoInicial = value; }
        }
        public int IdCaja
        {
            get { return _IdCaja; }
            set { _IdCaja = value; }
        }

        public DCashDesk()
        {

        }
        public DCashDesk(int idcaja, decimal monto_inicial, decimal monto_final, DateTime fecha, decimal exento, decimal iva, decimal descuento, int numero_compras, string ultima_factura, decimal total, string textobuscar)
        {
            this.IdCaja = idcaja;
            this.MontoInicial = monto_inicial;
            this.MontoFinal = monto_final;
            this.Fecha = fecha;
            this.Exento = exento;
            this.Iva = iva;
            this.Descuento = descuento;
            this.NumeroCompras = numero_compras;
            this.UltimaFactura = ultima_factura;
            this.Total = total;
        }

        public string Insertar(DCashDesk CaskDesk)
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
                SqlCmd.CommandText = "insertar_caja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@id_caja";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParMontoIncial = new SqlParameter();
                ParMontoIncial.ParameterName = "@monto_inicial";
                ParMontoIncial.SqlDbType = SqlDbType.Money;
                ParMontoIncial.Value = CaskDesk.MontoInicial;
                SqlCmd.Parameters.Add(ParMontoIncial);

                SqlParameter ParMontoFinal = new SqlParameter();
                ParMontoFinal.ParameterName = "@monto_final";
                ParMontoFinal.SqlDbType = SqlDbType.Money;
                ParMontoFinal.Value = CaskDesk.MontoFinal;
                SqlCmd.Parameters.Add(ParMontoFinal);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = CaskDesk.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParExento = new SqlParameter();
                ParExento.ParameterName = "@exento";
                ParExento.SqlDbType = SqlDbType.Decimal;
                ParExento.Value = CaskDesk.Exento;
                SqlCmd.Parameters.Add(ParExento);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = CaskDesk.Iva;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = CaskDesk.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParNCompras = new SqlParameter();
                ParNCompras.ParameterName = "@numero";
                ParNCompras.SqlDbType = SqlDbType.Int;
                ParNCompras.Value = CaskDesk.NumeroCompras;
                SqlCmd.Parameters.Add(ParNCompras);

                SqlParameter ParUltimaFactura = new SqlParameter();
                ParUltimaFactura.ParameterName = "@ultima_factura";
                ParUltimaFactura.SqlDbType = SqlDbType.VarChar;
                ParUltimaFactura.Size = 100;
                ParUltimaFactura.Value = CaskDesk.UltimaFactura;
                SqlCmd.Parameters.Add(ParUltimaFactura);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = CaskDesk.Total;
                SqlCmd.Parameters.Add(ParTotal);

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

        public string Editar(DCashDesk CaskDesk)
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
                SqlCmd.CommandText = "actualizar_caja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idcaja";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParMontoFinal = new SqlParameter();
                ParMontoFinal.ParameterName = "@monto_final";
                ParMontoFinal.SqlDbType = SqlDbType.Money;
                ParMontoFinal.Value = CaskDesk.MontoFinal;
                SqlCmd.Parameters.Add(ParMontoFinal);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = CaskDesk.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParExento = new SqlParameter();
                ParExento.ParameterName = "@exento";
                ParExento.SqlDbType = SqlDbType.Decimal;
                ParExento.Value = CaskDesk.Exento;
                SqlCmd.Parameters.Add(ParExento);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = CaskDesk.Iva;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = CaskDesk.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParNCompras = new SqlParameter();
                ParNCompras.ParameterName = "@numero_compras";
                ParNCompras.SqlDbType = SqlDbType.Int;
                ParNCompras.Value = CaskDesk.NumeroCompras;
                SqlCmd.Parameters.Add(ParNCompras);

                SqlParameter ParUltimaFactura = new SqlParameter();
                ParUltimaFactura.ParameterName = "@ultima_factura";
                ParUltimaFactura.SqlDbType = SqlDbType.VarChar;
                ParUltimaFactura.Size = 100;
                ParUltimaFactura.Value = CaskDesk.UltimaFactura;
                SqlCmd.Parameters.Add(ParUltimaFactura);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = CaskDesk.Total;
                SqlCmd.Parameters.Add(ParTotal);

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

        public DataTable VerificarFecha(DCashDesk CashDesk)
        {
            DataTable DtResultado = new DataTable("caja");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_caja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Size = 50;
                ParFecha.Value = Fecha;
                SqlCmd.Parameters.Add(ParFecha);

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
