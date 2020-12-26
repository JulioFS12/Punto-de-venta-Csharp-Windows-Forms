using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DProduct
    {
       private int _Idarticulo;
        private string _Codigo;
        private string _Nombre;
        private string _Categoria;
        private string _Descripcion;
        private string _Presentacion;
        private decimal _Precio_compra;
        private decimal _Precio_venta;
        private decimal _Existencia_actual;
        private string _Unidad;
        private Byte[] _Imagen;
        private string _Trabajador_responsable;
        private string _Proveedor;
        private string _Tipo_comprobante;
        private string _Numero_comprobante;
        private decimal _Iva;
        private string _Impuesto;
        private decimal _Descuento;
        private string _Texto_buscar;
        private string TradeMark;

        public string TradeMark1
        {
            get { return TradeMark; }
            set { TradeMark = value; }
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
        

        public string Texto_buscar
        {
            get { return _Texto_buscar; }
            set { _Texto_buscar = value; }
        }


        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }

        public string Numero_comprobante
        {
            get { return _Numero_comprobante; }
            set { _Numero_comprobante = value; }
        }


        public string Tipo_comprobante
        {
            get { return _Tipo_comprobante; }
            set { _Tipo_comprobante = value; }
        }


        public string Proveedor
        {
            get { return _Proveedor; }
            set { _Proveedor = value; }
        }


        public string Trabajador_responsable
        {
            get { return _Trabajador_responsable; }
            set { _Trabajador_responsable = value; }
        }
        public Byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public string Unidad
        {
            get { return _Unidad; }
            set { _Unidad = value; }
        }

        public decimal Existencia_actual
        {
            get { return _Existencia_actual; }
            set { _Existencia_actual = value; }
        }

        public decimal Precio_venta
        {
            get { return _Precio_venta; }
            set { _Precio_venta = value; }
        }

        public decimal Precio_compra
        {
            get { return _Precio_compra; }
            set { _Precio_compra = value; }
        }

        public string Presentacion
        {
            get { return _Presentacion; }
            set { _Presentacion = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
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

        public int Idarticulo
        {
            get { return _Idarticulo; }
            set { _Idarticulo = value; }
        }

        //Constructores
        public DProduct()
        {

        }

        public DProduct(int idarticulo, string codigo, string nombre, string categoria, string descripcion, string presentacion, decimal precio_compra, decimal precio_venta, decimal existencia_actual, string unidad, byte[] imagen, string trabajador_responsable,
            string proveedor, string tipo_comprobante, string numero_comprobante, decimal iva, string impuesto, decimal descuento, string texto_buscar, string trademark)
        {
            this.Idarticulo = idarticulo;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Descripcion = descripcion;
            this.Presentacion = presentacion;
            this.Precio_compra = precio_compra;
            this.Precio_venta = precio_venta;
            this.Existencia_actual = Existencia_actual;
            this.Unidad = unidad;
            this.Imagen = Imagen;
            this.Trabajador_responsable = trabajador_responsable;
            this.Proveedor = proveedor;
            this.Tipo_comprobante = tipo_comprobante;
            this.Numero_comprobante = numero_comprobante;
            this.Iva = iva;
            this.Impuesto = impuesto;
            this.Descuento = descuento;
            this.TradeMark = trademark;


            this.Texto_buscar = texto_buscar;
        }

        //metodo INSERTAR
        public string Insertar(DProduct Product)
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
                SqlCmd.CommandText = "insertar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Product.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Product.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCategoria = new SqlParameter();
                ParCategoria.ParameterName = "@Categoria";
                ParCategoria.SqlDbType = SqlDbType.VarChar;
                ParCategoria.Size = 50;
                ParCategoria.Value = Product.Categoria;
                SqlCmd.Parameters.Add(ParCategoria);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 150;
                ParDescripcion.Value = Product.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter Parpresentacion = new SqlParameter();
                Parpresentacion.ParameterName = "@presentacion";
                Parpresentacion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                Parpresentacion.Value = Product.Presentacion;
                SqlCmd.Parameters.Add(Parpresentacion);

                SqlParameter ParPrecioCompra = new SqlParameter();
                ParPrecioCompra.ParameterName = "@precio_compra";
                ParPrecioCompra.SqlDbType = SqlDbType.Money;
                ParPrecioCompra.Value = Product.Precio_compra;
                SqlCmd.Parameters.Add(ParPrecioCompra);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = Product.Precio_venta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                SqlParameter ParExistenciaActual = new SqlParameter();
                ParExistenciaActual.ParameterName = "@existencia_actual";
                ParExistenciaActual.SqlDbType = SqlDbType.Decimal;
                ParExistenciaActual.Value = Product.Existencia_actual;
                SqlCmd.Parameters.Add(ParExistenciaActual);

                SqlParameter ParUnidadMedida = new SqlParameter();
                ParUnidadMedida.ParameterName = "@unidad";
                ParUnidadMedida.SqlDbType = SqlDbType.VarChar;
                ParUnidadMedida.Size = 50;
                ParUnidadMedida.Value = Product.Unidad;
                SqlCmd.Parameters.Add(ParUnidadMedida);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Product.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

                SqlParameter ParTrabajadorResponsable = new SqlParameter();
                ParTrabajadorResponsable.ParameterName = "@trabajador_responsable";
                ParTrabajadorResponsable.SqlDbType = SqlDbType.VarChar;
                ParUnidadMedida.Size = 100;
                ParTrabajadorResponsable.Value = Product.Trabajador_responsable;
                SqlCmd.Parameters.Add(ParTrabajadorResponsable);

                SqlParameter ParProveedor = new SqlParameter();
                ParProveedor.ParameterName = "@proveedor";
                ParProveedor.SqlDbType = SqlDbType.VarChar;
                ParProveedor.Size = 50;
                ParProveedor.Value = Product.Proveedor;
                SqlCmd.Parameters.Add(ParProveedor);

                SqlParameter ParTipoComprobante = new SqlParameter();
                ParTipoComprobante.ParameterName = "@tipo_comprobante";
                ParTipoComprobante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprobante.Size = 50;
                ParTipoComprobante.Value = Product.Tipo_comprobante;
                SqlCmd.Parameters.Add(ParTipoComprobante);

                SqlParameter ParNumeroComprobante = new SqlParameter();
                ParNumeroComprobante.ParameterName = "@numero_comprobante";
                ParNumeroComprobante.SqlDbType = SqlDbType.VarChar;
                ParNumeroComprobante.Size = 100;
                ParNumeroComprobante.Value = Product.Numero_comprobante;
                SqlCmd.Parameters.Add(ParNumeroComprobante);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = Product.Iva;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParImpuesto = new SqlParameter();
                ParImpuesto.ParameterName = "@impuesto";
                ParImpuesto.SqlDbType = SqlDbType.VarChar;
                ParImpuesto.Size = 100;
                ParImpuesto.Value = Product.Impuesto;
                SqlCmd.Parameters.Add(ParImpuesto);

                SqlParameter ParDescuetno = new SqlParameter();
                ParDescuetno.ParameterName = "@descuento";
                ParDescuetno.SqlDbType = SqlDbType.Money;
                ParDescuetno.Value = Product.Descuento;
                SqlCmd.Parameters.Add(ParDescuetno);

                SqlParameter ParTradeMark = new SqlParameter();
                ParTradeMark.ParameterName = "@marca";
                ParTradeMark.SqlDbType = SqlDbType.VarChar;
                ParTradeMark.Size = 100;
                ParTradeMark.Value = Product.TradeMark;
                SqlCmd.Parameters.Add(ParTradeMark);

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

        public string Editar(DProduct Product)
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
                SqlCmd.CommandText = "editar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Product.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Product.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 100;
                ParNombre.Value = Product.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCategoria = new SqlParameter();
                ParCategoria.ParameterName = "@Categoria";
                ParCategoria.SqlDbType = SqlDbType.VarChar;
                ParCategoria.Size = 50;
                ParCategoria.Value = Product.Categoria;
                SqlCmd.Parameters.Add(ParCategoria);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 150;
                ParDescripcion.Value = Product.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter Parpresentacion = new SqlParameter();
                Parpresentacion.ParameterName = "@presentacion";
                Parpresentacion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                Parpresentacion.Value = Product.Presentacion;
                SqlCmd.Parameters.Add(Parpresentacion);

                SqlParameter ParPrecioCompra = new SqlParameter();
                ParPrecioCompra.ParameterName = "@precio_compra";
                ParPrecioCompra.SqlDbType = SqlDbType.Money;
                ParPrecioCompra.Value = Product.Precio_compra;
                SqlCmd.Parameters.Add(ParPrecioCompra);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = Product.Precio_venta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                SqlParameter ParExistenciaActual = new SqlParameter();
                ParExistenciaActual.ParameterName = "@existencia_actual";
                ParExistenciaActual.SqlDbType = SqlDbType.Decimal;
                ParExistenciaActual.Value = Product.Existencia_actual;
                SqlCmd.Parameters.Add(ParExistenciaActual);

                SqlParameter ParUnidadMedida = new SqlParameter();
                ParUnidadMedida.ParameterName = "@unidad";
                ParUnidadMedida.SqlDbType = SqlDbType.VarChar;
                ParUnidadMedida.Size = 50;
                ParUnidadMedida.Value = Product.Unidad;
                SqlCmd.Parameters.Add(ParUnidadMedida);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Product.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

                SqlParameter ParTrabajadorResponsable = new SqlParameter();
                ParTrabajadorResponsable.ParameterName = "@trabajador_responsable";
                ParTrabajadorResponsable.SqlDbType = SqlDbType.VarChar;
                ParUnidadMedida.Size = 100;
                ParTrabajadorResponsable.Value = Product.Trabajador_responsable;
                SqlCmd.Parameters.Add(ParTrabajadorResponsable);

                SqlParameter ParProveedor = new SqlParameter();
                ParProveedor.ParameterName = "@proveedor";
                ParProveedor.SqlDbType = SqlDbType.VarChar;
                ParProveedor.Size = 50;
                ParProveedor.Value = Product.Proveedor;
                SqlCmd.Parameters.Add(ParProveedor);

                SqlParameter ParTipoComprobante = new SqlParameter();
                ParTipoComprobante.ParameterName = "@tipo_comprobante";
                ParTipoComprobante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprobante.Size = 50;
                ParTipoComprobante.Value = Product.Tipo_comprobante;
                SqlCmd.Parameters.Add(ParTipoComprobante);

                SqlParameter ParNumeroComprobante = new SqlParameter();
                ParNumeroComprobante.ParameterName = "@numero_comprobante";
                ParNumeroComprobante.SqlDbType = SqlDbType.VarChar;
                ParNumeroComprobante.Size = 100;
                ParNumeroComprobante.Value = Product.Numero_comprobante;
                SqlCmd.Parameters.Add(ParNumeroComprobante);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = Product.Iva;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParImpuesto = new SqlParameter();
                ParImpuesto.ParameterName = "@impuesto";
                ParImpuesto.SqlDbType = SqlDbType.VarChar;
                ParImpuesto.Size = 100;
                ParImpuesto.Value = Product.Impuesto;
                SqlCmd.Parameters.Add(ParImpuesto);

                SqlParameter ParDescuetno = new SqlParameter();
                ParDescuetno.ParameterName = "@descuento";
                ParDescuetno.SqlDbType = SqlDbType.Money;
                ParDescuetno.Value = Product.Descuento;
                SqlCmd.Parameters.Add(ParDescuetno);

                SqlParameter ParTradeMark = new SqlParameter();
                ParTradeMark.ParameterName = "@marca";
                ParTradeMark.SqlDbType = SqlDbType.VarChar;
                ParTradeMark.Size = 100;
                ParTradeMark.Value = Product.TradeMark;
                SqlCmd.Parameters.Add(ParTradeMark);

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

        //Método Eliminar
        public string Eliminar(DProduct Product)
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
                SqlCmd.CommandText = "eliminar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Product.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

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
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("articulos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_articulo";
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

        public DataTable BuscarCodigo(DProduct Product)
        {
            DataTable DtResultado = new DataTable("articulos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_articulo_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Product.Texto_buscar;
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

        public DataTable ValidarArticulo(DProduct Product)
        {
            DataTable DtResultado = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "validar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 20;
                ParCodigo.Value = Product.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

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
