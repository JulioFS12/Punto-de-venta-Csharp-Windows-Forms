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
    public class LProduct
    {
        //Método Insertar que llama al método Insertar de la clase DArticulo
        //de la CapaDatos
        public static string Insertar(string codigo, string nombre, string categoria, string descripcion, string presentacion, decimal precio_compra, decimal precio_venta, decimal existencia_actual, string unidad, byte[] imagen, string trabajador_responsable,
            string proveedor, string tipo_comprobante, string numero_comprobante, decimal iva, string impuesto, decimal descuento, string trademark)
        {
            DProduct Obj = new DProduct();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Categoria = categoria;
            Obj.Descripcion = descripcion;
            Obj.Presentacion = presentacion;
            Obj.Precio_compra = precio_compra;
            Obj.Precio_venta = precio_venta;
            Obj.Existencia_actual = existencia_actual;
            Obj.Unidad = unidad;
            Obj.Imagen = imagen;
            Obj.Trabajador_responsable = trabajador_responsable;
            Obj.Proveedor = proveedor;
            Obj.Tipo_comprobante = tipo_comprobante;
            Obj.Numero_comprobante = numero_comprobante;
            Obj.Iva = iva;
            Obj.Impuesto = impuesto;
            Obj.Descuento = descuento;
            Obj.TradeMark1 = trademark;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DArticulo
        //de la CapaDatos
        public static string Editar(int idarticulo, string codigo, string nombre, string categoria, string descripcion, string presentacion, decimal precio_compra, decimal precio_venta, decimal existencia_actual, string unidad, byte[] imagen, string trabajador_responsable,
            string proveedor, string tipo_comprobante, string numero_comprobante, decimal iva, string impuesto, decimal descuento, string trademark)
        {
            DProduct Obj = new DProduct();
            Obj.Idarticulo = idarticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Categoria = categoria;
            Obj.Descripcion = descripcion;
            Obj.Presentacion = presentacion;
            Obj.Precio_compra = precio_compra;
            Obj.Precio_venta = precio_venta;
            Obj.Existencia_actual = existencia_actual;
            Obj.Unidad = unidad;
            Obj.Imagen = imagen;
            Obj.Trabajador_responsable = trabajador_responsable;
            Obj.Proveedor = proveedor;
            Obj.Tipo_comprobante = tipo_comprobante;
            Obj.Numero_comprobante = numero_comprobante;
            Obj.Iva = iva;
            Obj.Impuesto = impuesto;
            Obj.Descuento = descuento;
            Obj.TradeMark1 = trademark;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DArticulo
        //de la CapaDatos
        public static string Eliminar(int idarticulo)
        {
            DProduct Obj = new DProduct();
            Obj.Idarticulo = idarticulo;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DArticulo
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DProduct().Mostrar();
        }

        public static DataTable BuscarCodigo(string textobuscar)
        {
            DProduct Obj = new DProduct();
            Obj.Texto_buscar = textobuscar;
            return Obj.BuscarCodigo(Obj);
        }

        public static DataTable ValidarArticulo(string codigo)
        {
            DProduct Obj = new DProduct();
            Obj.Codigo = codigo;
            return Obj.ValidarArticulo(Obj);
        }
    }
}
