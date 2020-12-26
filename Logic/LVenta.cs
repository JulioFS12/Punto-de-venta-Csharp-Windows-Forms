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
    public class LVenta
    {
        public static string Insertar(string trabajador_responsable, string cliente, string fecha, string numero_factura, string hora_venta,
            string condicion_pago, string forma_pago, decimal porcentaje_iva, decimal iva, decimal sub_total, decimal exhonerado, string documento, decimal total,
            decimal vuelto, decimal pago, string telefono, string direccion, DataTable dtDetalles)
        {//Ejecutamos nuestro comando

            DVenta Obj = new DVenta();
            Obj.Trabajador_responsable = trabajador_responsable;
            Obj.Cliente = cliente;
            Obj.Fecha = fecha;
            Obj.Numero_factura = numero_factura;
            Obj.Hora_venta = hora_venta;
            Obj.Condicion_pago = condicion_pago;
            Obj.Forma_pago = forma_pago;
            Obj.Porcentaje_iva = porcentaje_iva;
            Obj.Iva = iva;
            Obj.Sub_total = sub_total;
            Obj.Exhonerado = exhonerado;
            Obj.Documento = documento;
            Obj.Total = total;
            Obj.Vuelto = vuelto;
            Obj.Pago = pago;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            List<DDetalle_venta> detalles = new List<DDetalle_venta>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_venta detalle = new DDetalle_venta();
                //detalle.Id_detalle_venta = Convert.ToInt32(row["Id Detalle Venta"].ToString());
                detalle.Codigo = Convert.ToString(row["Codigo"].ToString());
                detalle.Nombre = Convert.ToString(row["Nombre"].ToString());
                detalle.Descripcion = Convert.ToString(row["Descripcion"].ToString());
                detalle.Cantidad = Convert.ToDecimal(row["Cantidad"].ToString());
                detalle.Precio_unitario = Convert.ToDecimal(row["Precio unitario"].ToString());
                detalle.Precio_total = Convert.ToDecimal(row["Precio total"].ToString());
                detalle.Porcentaje_descuento = Convert.ToDecimal(row["Monto Descuento"].ToString());
                detalle.Impuesto = Convert.ToString(row["Impuesto"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public static string Eliminar(int idventa)
        {
            DVenta Obj = new DVenta();
            Obj.Idventa = idventa;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DVenta
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }

        public static DataTable MostrarDetalle(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
