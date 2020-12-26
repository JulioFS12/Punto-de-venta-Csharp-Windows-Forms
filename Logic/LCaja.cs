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
    public class LCaja
    {
        public static string Insertar(decimal monto_inicial, decimal monto_final, DateTime fecha, decimal exento, decimal iva, decimal descuento, int numero_compras, string ultima_factura, decimal total)
        {
            DCashDesk Obj = new DCashDesk();
            Obj.MontoInicial = monto_inicial;
            Obj.MontoFinal = monto_final;
            Obj.Fecha = fecha;
            Obj.Exento = exento;
            Obj.Iva = iva;
            Obj.Descuento = descuento;
            Obj.NumeroCompras = numero_compras;
            Obj.UltimaFactura = ultima_factura;
            Obj.Total = total;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCategoría
        //de la CapaDatos
        public static string Editar(int idcaja, decimal monto_final, DateTime fecha, decimal exento, decimal iva, decimal descuento, int numero_compras, string ultima_factura, decimal total)
        {
            DCashDesk Obj = new DCashDesk();
            Obj.IdCaja = idcaja;
            Obj.MontoFinal = monto_final;
            Obj.Fecha = fecha;
            Obj.Exento = exento;
            Obj.Iva = iva;
            Obj.Descuento = descuento;
            Obj.NumeroCompras = numero_compras;
            Obj.UltimaFactura = ultima_factura;
            Obj.Total = total;
            return Obj.Editar(Obj);
        }
        public static DataTable ValidarFecha(DateTime fecha)
        {
            DCashDesk Obj = new DCashDesk();
            Obj.Fecha = fecha;
            return Obj.VerificarFecha(Obj);
        }

    }
}
