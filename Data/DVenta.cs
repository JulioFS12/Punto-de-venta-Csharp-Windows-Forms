using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DVenta
    {
        private int _Idventa;
        private string _Trabajador_responsable;
        private string _Cliente;
        private string _Documento;
        private string _Numero_factura;
        private string _Fecha;
        private string _Hora_venta;
        private string _Condicion_pago;
        private string _Forma_pago;
        private decimal _Porcentaje_iva;
        private decimal _Iva;
        private decimal _Sub_total;
        private decimal _Exhonerado;
        private decimal _Vuelto;
        private decimal _Pago;
        private decimal _Total;
        private string _Telefono;
        private string _Direccion;
        private decimal _Cantidad;
        private int _Idarticulo;
        private string _TextoBuscarT;
        private DateTime _TextoBuscar1;
        private DateTime _TextoBuscar2;

        public DateTime TextoBuscar2
        {
            get { return _TextoBuscar2; }
            set { _TextoBuscar2 = value; }
        }

        public DateTime TextoBuscar1
        {
            get { return _TextoBuscar1; }
            set { _TextoBuscar1 = value; }
        }

        public string TextoBuscarT
        {
            get { return _TextoBuscarT; }
            set { _TextoBuscarT = value; }
        }

        public int Idarticulo
        {
            get { return _Idarticulo; }
            set { _Idarticulo = value; }
        }

        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public decimal Pago
        {
            get { return _Pago; }
            set { _Pago = value; }
        }


        public decimal Vuelto
        {
            get { return _Vuelto; }
            set { _Vuelto = value; }
        }



        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        //private DateTime _TextoBuscar1;
        //private DateTime _TextoBuscar2;

        //public DateTime TextoBuscar2
        //{
        //    get { return _TextoBuscar2; }
        //    set { _TextoBuscar2 = value; }
        //}

        //public DateTime TextoBuscar1
        ////{
        ////    get { return _TextoBuscar1; }
        ////    set { _TextoBuscar1 = value; }
        //}


        public decimal Exhonerado
        {
            get { return _Exhonerado; }
            set { _Exhonerado = value; }
        }


        public decimal Sub_total
        {
            get { return _Sub_total; }
            set { _Sub_total = value; }
        }


        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }


        public decimal Porcentaje_iva
        {
            get { return _Porcentaje_iva; }
            set { _Porcentaje_iva = value; }
        }


        public string Forma_pago
        {
            get { return _Forma_pago; }
            set { _Forma_pago = value; }
        }



        public string Condicion_pago
        {
            get { return _Condicion_pago; }
            set { _Condicion_pago = value; }
        }


        public string Hora_venta
        {
            get { return _Hora_venta; }
            set { _Hora_venta = value; }
        }


        public string Numero_factura
        {
            get { return _Numero_factura; }
            set { _Numero_factura = value; }
        }


        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }


        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public string Trabajador_responsable
        {
            get { return _Trabajador_responsable; }
            set { _Trabajador_responsable = value; }
        }

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        //Constructores
        public DVenta()
        {

        }

        public DVenta(int idventa, string trabajador_responsable, string cliente, string fecha, string numero_factura, string hora_venta,
            string condicion_pago, string forma_pago, decimal porcentaje_iva, decimal iva, decimal sub_total, decimal exhonerado, decimal total,
            string documento, decimal vuelto, decimal pago, string telefono, string direccion, DateTime textobuscar1, DateTime textobuscar2,
            int idarticulo, int cantidad, string textobuscart)
        {
            this.Idventa = idventa;
            this.Trabajador_responsable = trabajador_responsable;
            this.Cliente = cliente;
            this.Fecha = fecha;
            this.Numero_factura = numero_factura;
            this.Hora_venta = hora_venta;
            this.Condicion_pago = condicion_pago;
            this.Forma_pago = forma_pago;
            this.Porcentaje_iva = porcentaje_iva;
            this.Iva = iva;
            this.Sub_total = sub_total;
            this.Exhonerado = exhonerado;
            this.Documento = documento;
            this.Total = total;
            this.Vuelto = vuelto;
            this.Pago = pago;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Cantidad = cantidad;
            this.Idarticulo = idarticulo;
            this.TextoBuscarT = textobuscart;
            this.TextoBuscar1 = textobuscar1;
            this.TextoBuscar2 = textobuscar2;
        }



        //Métodos
        public string DisminuirStock(string codigo, decimal cantidad)
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
                SqlCmd.CommandText = "disminuir_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 100;
                ParCodigo.Value = codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el stock";

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

        //Insertar
        public string Insertar(DVenta Venta, List<DDetalle_venta> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Connection.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter Partrabajador = new SqlParameter();
                Partrabajador.ParameterName = "@trabajador";
                Partrabajador.SqlDbType = SqlDbType.VarChar;
                Partrabajador.Size = 100;
                Partrabajador.Value = Venta.Trabajador_responsable;
                SqlCmd.Parameters.Add(Partrabajador);

                SqlParameter ParCliente = new SqlParameter();
                ParCliente.ParameterName = "@cliente";
                ParCliente.SqlDbType = SqlDbType.VarChar;
                ParCliente.Size = 100;
                ParCliente.Value = Venta.Cliente;
                SqlCmd.Parameters.Add(ParCliente);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParNumeroFactura = new SqlParameter();
                ParNumeroFactura.ParameterName = "@numero_factura";
                ParNumeroFactura.SqlDbType = SqlDbType.VarChar;
                ParNumeroFactura.Size = 100;
                ParNumeroFactura.Value = Venta.Numero_factura;
                SqlCmd.Parameters.Add(ParNumeroFactura);

                SqlParameter ParHora = new SqlParameter();
                ParHora.ParameterName = "@hora_venta";
                ParHora.SqlDbType = SqlDbType.Time;
                ParHora.Value = Venta.Hora_venta;
                SqlCmd.Parameters.Add(ParHora);

                SqlParameter ParCondicionPago = new SqlParameter();
                ParCondicionPago.ParameterName = "@condicion_pago";
                ParCondicionPago.SqlDbType = SqlDbType.VarChar;
                ParCondicionPago.Size = 100;
                ParCondicionPago.Value = Venta.Condicion_pago;
                SqlCmd.Parameters.Add(ParCondicionPago);

                SqlParameter ParFormaPago = new SqlParameter();
                ParFormaPago.ParameterName = "@forma_pago";
                ParFormaPago.SqlDbType = SqlDbType.VarChar;
                ParFormaPago.Size = 100;
                ParFormaPago.Value = Venta.Forma_pago;
                SqlCmd.Parameters.Add(ParFormaPago);

                SqlParameter ParProcentajeIva = new SqlParameter();
                ParProcentajeIva.ParameterName = "@porcentaje_iva";
                ParProcentajeIva.SqlDbType = SqlDbType.Decimal;
                ParProcentajeIva.Precision = 18;
                ParProcentajeIva.Scale = 2;
                ParProcentajeIva.Value = Venta.Porcentaje_iva;
                SqlCmd.Parameters.Add(ParProcentajeIva);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Money;
                ParIva.Value = Venta.Iva;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@sub_total";
                ParSubTotal.SqlDbType = SqlDbType.Money;
                ParSubTotal.Value = Venta.Sub_total;
                SqlCmd.Parameters.Add(ParSubTotal);

                SqlParameter ParExhonerado = new SqlParameter();
                ParExhonerado.ParameterName = "@exonerado";
                ParExhonerado.SqlDbType = SqlDbType.Money;
                ParExhonerado.Value = Venta.Exhonerado;
                SqlCmd.Parameters.Add(ParExhonerado);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 100;
                ParDocumento.Value = Venta.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = Venta.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParVuelto = new SqlParameter();
                ParVuelto.ParameterName = "@vuelto";
                ParVuelto.SqlDbType = SqlDbType.Money;
                ParVuelto.Value = Venta.Vuelto;
                SqlCmd.Parameters.Add(ParVuelto);

                SqlParameter ParPago = new SqlParameter();
                ParPago.ParameterName = "@pago";
                ParPago.SqlDbType = SqlDbType.Money;
                ParPago.Value = Venta.Pago;
                SqlCmd.Parameters.Add(ParPago);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Venta.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Venta.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.Idventa = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (DDetalle_venta det in Detalle)
                    {
                        det.Idventa = this.Idventa;
                        //Llamar al método insertar de la clase DDetalle_Ingreso
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizamos el stock
                            rpta = DisminuirStock(det.Codigo, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }

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

        //Elimininar
        public string Eliminar(DVenta Venta)
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
                SqlCmd.CommandText = "eliminar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Venta.Idventa;
                SqlCmd.Parameters.Add(ParIdventa);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";


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
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_venta";
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


        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
