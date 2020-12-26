using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DDetalle_venta
    {
        private int _Id_detalle_venta;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private decimal _Cantidad;
        private decimal _Precio_unitario;
        private decimal _Precio_total;
        private decimal _Porcentaje_descuento;
        private int _Idventa;
        private string _Impuesto;
        private decimal _Descuento;
        private int _TextoBuscar;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }
      
        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }
        
        public string Impuesto
        {
            get { return _Impuesto; }
            set { _Impuesto = value; }
        }
        public decimal Porcentaje_descuento
        {
            get { return _Porcentaje_descuento; }
            set { _Porcentaje_descuento = value; }
        }

        public int TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public decimal Precio_total
        {
            get { return _Precio_total; }
            set { _Precio_total = value; }
        }
        public decimal Precio_unitario
        {
            get { return _Precio_unitario; }
            set { _Precio_unitario = value; }
        }

        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public int Id_detalle_venta
        {
            get { return _Id_detalle_venta; }
            set { _Id_detalle_venta = value; }
        }

        //contructores
        public DDetalle_venta()
        {

        }

        public DDetalle_venta(int iddetalle_venta, string codigo, string nombre, string descripcion, int cantidad, decimal precio_unitario, 
            decimal precio_total, decimal porcentaje_descuento, int idventa, string impuesto, decimal descuento, int textobuscar)
        {
            this.Id_detalle_venta = iddetalle_venta;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this._Precio_unitario = precio_unitario;
            this.Precio_total = precio_total;
            this.Porcentaje_descuento = porcentaje_descuento;
            this.Idventa = idventa;
            this.Impuesto = impuesto;
            this.Descuento = descuento;
            this.TextoBuscar = textobuscar;
        }

        //metodos

        public string Insertar(DDetalle_venta Detalle_venta,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                //Comando de coneccion
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Venta = new SqlParameter();
                ParIddetalle_Venta.ParameterName = "@iddetalle_venta";
                ParIddetalle_Venta.SqlDbType = SqlDbType.Int;
                ParIddetalle_Venta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Venta);

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Detalle_venta.Idventa;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 100;
                ParCodigo.Value = Detalle_venta.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Detalle_venta.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = Detalle_venta.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = Detalle_venta.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioUnitario = new SqlParameter();
                ParPrecioUnitario.ParameterName = "@precio_unitario";
                ParPrecioUnitario.SqlDbType = SqlDbType.Money;
                ParPrecioUnitario.Value = Detalle_venta.Precio_unitario;
                SqlCmd.Parameters.Add(ParPrecioUnitario);

                SqlParameter ParPrecioTotal = new SqlParameter();
                ParPrecioTotal.ParameterName = "@Precio_total_producto";
                ParPrecioTotal.SqlDbType = SqlDbType.Money;
                ParPrecioTotal.Value = Detalle_venta.Precio_total;
                SqlCmd.Parameters.Add(ParPrecioTotal);

                SqlParameter ParImpuesto = new SqlParameter();
                ParImpuesto.ParameterName = "@impuesto";
                ParImpuesto.SqlDbType = SqlDbType.VarChar;
                ParImpuesto.Size = 100;
                ParImpuesto.Value = Detalle_venta.Impuesto;
                SqlCmd.Parameters.Add(ParImpuesto);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Money;
                ParDescuento.Value = Detalle_venta.Porcentaje_descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
    }
}
