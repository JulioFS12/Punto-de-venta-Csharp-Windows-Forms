using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logic;

namespace Presentation
{
    public partial class PVenta : Form
    {
        public PVenta()
        {
            InitializeComponent();
            this.lblFecha.Text = DateTime.Now.ToShortDateString();
            this.lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMssage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        private bool IsNuevo = false;
        public int Idtrabajador;

        private DataTable dtDetalle;


        private static PVenta _instancia;

        //Creamos una instancia para poder utilizar los
        //Objetos del formulario
        public static PVenta GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PVenta();
            }
            return _instancia;
        }

        public void setCliente(string cliente, string documento, string telefono, string direccion)
        {
            this.txtCliente.Text = cliente;
            this.txtDocumento.Text = documento;
            this.txtTelefono.Text = telefono;
            this.txtDireccion.Text = direccion;
        }

        public void setArticulo(int idartculo, string codigo, string nombre, decimal precio_unitario, decimal cantidad_max, string impuesto, decimal descuento, string descripcion)
        {
            this.txtIdArticulo.Text = Convert.ToString(idartculo);
            this.txtCodigo.Text = codigo;
            this.txtArticulo.Text = nombre;
            this.txtCantidadMaxima.Text = Convert.ToString(cantidad_max);
            this.cbImpuesto.Text = impuesto;

            precio_unitario *= Convert.ToDecimal(txtConversion.Text);
            this.txtPrecioUnitario.Text = Convert.ToString(precio_unitario);

            descuento *= Convert.ToDecimal(txtConversion.Text);
            this.txtDescuento.Text = Convert.ToString(descuento);

            decimal value1;
            if (Decimal.TryParse(txtCantidadMaxima.Text, out value1))
                txtCantidadMaxima.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N3}", value1);
            else
                txtCantidadMaxima.Text = "0,000";

            decimal value2;
            if (Decimal.TryParse(txtPrecioUnitario.Text, out value2))
                txtPrecioUnitario.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value2);
            else
                txtPrecioUnitario.Text = "0,00";

            decimal value3;
            if (Decimal.TryParse(txtDescuento.Text, out value3))
                txtDescuento.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value3);
            else
                txtDescuento.Text = "0,00";
        }
        private void Limpiar()
        {
            this.txtIdVenta.Text = string.Empty;
            this.txtCliente.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCantidadMaxima.Text = string.Empty;
            this.txtPrecioTotal.Text = "0,00";
            this.lblExento.Text = "0,00";
            this.txtDescripcion.Text = string.Empty;
            this.txtPago.Text = "0,00";
            this.txtCambio.Text = "0,00";
            this.txtTotalDescuento.Text = "0,00";
            this.txtDescuento.Text = "0,00";
            this.lblIVA.Text = "0,00";
            this.lblSubTotal.Text = "0,00";
            this.lblTotal.Text = "0,00";
            this.lblExonerado.Text = "0,00";
        }
        private void LimpiarDetalle()
        {
            this.txtIddetalleVenta.Text = string.Empty;
            this.txtArticulo.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtPrecioUnitario.Text = "0,00";
            this.txtPrecioTotal.Text = "0,00";
            this.txtTotalDescuento.Text = "0,00";
            this.txtPago.Text = "0,00";
            this.txtCambio.Text = "0,00";
            this.txtCantidad.Text = string.Empty;
            this.txtCantidadMaxima.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.btnAdd.Enabled = valor;
            this.btnSrp.Enabled = valor;
            this.btnBuscarCLiente.Enabled = valor;
            this.btnAñadirCliente.Enabled = valor;
        }
        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.Habilitar(true);
                this.btnImprimir.Enabled = true;
                this.btnAdd.Enabled = true;
                this.btnSrp.Enabled = true;
                this.btnBuscarArticulo.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnImprimir.Enabled = false;
                this.btnAdd.Enabled = false;
                this.btnSrp.Enabled = false;
                this.btnBuscarArticulo.Enabled = false;
            }

        }
        private void InstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                this.cbPrinter.Items.Add(pkInstalledPrinters);

            }
        }
        private void txtConversion_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtConversion.Text, out value))
                txtConversion.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtConversion.Text = "0,00";
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void SumaDescuento()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in datalistadoDetalle.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Monto Descuento"].Value);
            }

            this.lblExonerado.Text = Convert.ToString(total);

            Double value;
            if (Double.TryParse(lblExonerado.Text, out value))
                lblExonerado.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                lblExonerado.Text = "0,00";
        }

        private void CalcularIva()
        {
            decimal iva = 0;

            foreach (DataGridViewRow row in datalistadoDetalle.Rows)
            {
                if (Convert.ToString(row.Cells["Impuesto"].Value) == "IVA")
                    iva = iva + (Convert.ToDecimal(row.Cells["Precio total"].Value) * Convert.ToDecimal(cbIva.Text));
            }

            this.lblIVA.Text = iva.ToString();

            Double value;
            if (Double.TryParse(lblIVA.Text, out value))
                lblIVA.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                lblIVA.Text = "0,00";
        }

        //Calcular EXENTO
        private void CalcularExento()
        {
            decimal exento = 0;

            foreach (DataGridViewRow row in datalistadoDetalle.Rows)
            {
                if (Convert.ToString(row.Cells["Impuesto"].Value) == "(E)")
                    exento = exento + (Convert.ToDecimal(row.Cells["Precio total"].Value));
            }

            this.lblExento.Text = exento.ToString();

            Double value;
            if (Double.TryParse(lblExento.Text, out value))
                lblExento.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                lblExento.Text = "0,00";
        }

        //Calcular sub total
        private void CalcularSubTotal()
        {
            decimal sub = 0;
            foreach (DataGridViewRow row in datalistadoDetalle.Rows)
            {
                sub += Convert.ToDecimal(row.Cells["Precio Total"].Value);
            }
            this.lblSubTotal.Text = sub.ToString();

            Double value;
            if (Double.TryParse(lblSubTotal.Text, out value))
                lblSubTotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                lblSubTotal.Text = "0,00";
        }

        //Calcular total
        public void CalcularTotal()
        {
            decimal total = 0;
            total = (decimal.Parse(lblSubTotal.Text) + decimal.Parse(lblIVA.Text)) - decimal.Parse(lblExonerado.Text);
            this.lblTotal.Text = total.ToString();

            Double value;
            if (Double.TryParse(lblTotal.Text, out value))
                lblTotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                lblTotal.Text = "0,00";
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text != String.Empty)
            {
                decimal value1;
                if (Decimal.TryParse(txtCantidad.Text, out value1))
                    txtCantidad.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N3}", value1);
                else
                    txtCantidad.Text = "0,000";

                decimal total;
                decimal precioU = decimal.Parse(txtPrecioUnitario.Text);

                decimal cantidad = decimal.Parse(txtCantidad.Text);
                total = precioU * cantidad;
                txtPrecioTotal.Text = total.ToString();

                decimal value2;
                if (Decimal.TryParse(txtPrecioTotal.Text, out value2))
                    txtPrecioTotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value2);
                else
                    txtPrecioTotal.Text = "0,00";

            }
            else
            {
                txtPrecioTotal.Text = "0,00";
            }

            if (Decimal.Parse(txtDescuento.Text) > Convert.ToDecimal("0,00"))
            {
                decimal descuentoT;
                decimal descuento = decimal.Parse(txtDescuento.Text);
                decimal precioT = decimal.Parse(txtPrecioTotal.Text);
                descuentoT = precioT - descuento;
                this.txtTotalDescuento.Text = descuentoT.ToString();
            }
            else
            {
                txtTotalDescuento.Text = "0,00";
            }

            Double value;
            if (Double.TryParse(txtTotalDescuento.Text, out value))
                txtTotalDescuento.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtTotalDescuento.Text = "0,00";

        }

        private void txtCambio_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(this.txtCambio.Text, out value))
                txtCambio.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtCambio.Text = "0,00";
        }

        private void txtPago_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtPago.Text, out value))
                txtPago.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtPago.Text = "0,00";
        }

        private void LLenarTrabajador()
        {
            cbTrabajador.DataSource = LPersonal.Show();
            cbTrabajador.ValueMember = "Id Trabajador";
            cbTrabajador.DisplayMember = "Nombre";
        }

        private void ocultarDetalle()
        {
            this.datalistadoDetalle.Columns[0].Visible = false;
            this.datalistadoDetalle.Columns[4].Visible = false;
        }

        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Id Detalle Venta", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Nombre", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Precio unitario", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Precio Total", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Monto Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Impuesto", System.Type.GetType("System.String"));
            //prueba de resta de stock
            //Relacionamos nuestro datagridview con nuestro datatable
            this.datalistadoDetalle.DataSource = this.dtDetalle;
        }

        private void PVenta_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Limpiar();
            this.LimpiarDetalle();
            this.Botones();
            this.crearTabla();
            this.ocultarDetalle();
            this.LLenarTrabajador();
            this.InstalledPrintersCombo();
            this.txtConversion.Visible = false;
            this.cbPrinter.Visible = false;
            this.lblError.Visible = false;
        }

        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
            PViewClientVenta vista = new PViewClientVenta();
            vista.ShowDialog();
        }

        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            PViewClient2 vista = new PViewClient2();
            vista.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            PViewProductVenta vista = new PViewProductVenta();
            vista.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.Habilitar(true);
            this.crearTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.crearTabla();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIdArticulo.Text == string.Empty || this.txtCantidad.Text == string.Empty)
                {
                    this.lblError.Visible = true;
                }
                else
                {
                    //Variable que va a indicar si podemos registrar el detalle
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToString(row["Nombre"]) == Convert.ToString(this.txtArticulo.Text))
                        {
                            registrar = false;
                        }
                    }
                    if (registrar == true && Convert.ToDecimal(this.txtCantidad.Text) <= Convert.ToDecimal(this.txtCantidadMaxima.Text))
                    {
                        DataRow row = this.dtDetalle.NewRow();
                        row["Codigo"] = this.txtCodigo.Text;
                        row["Nombre"] = this.txtArticulo.Text;
                        row["Descripcion"] = this.txtDescripcion.Text;
                        row["Cantidad"] = Convert.ToDecimal(this.txtCantidad.Text);
                        row["Precio unitario"] = Convert.ToDecimal(this.txtPrecioUnitario.Text);
                        row["Precio total"] = Convert.ToDecimal(this.txtPrecioTotal.Text);
                        row["Descuento"] = Convert.ToDecimal(this.txtTotalDescuento.Text);
                        row["Monto Descuento"] = Convert.ToDecimal(this.txtDescuento.Text);
                        row["Impuesto"] = this.cbImpuesto.Text;
                        this.dtDetalle.Rows.Add(row);

                        this.LimpiarDetalle();
                        this.SumaDescuento();
                        this.CalcularSubTotal();
                        this.CalcularIva();
                        this.CalcularExento();
                        this.CalcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("No hay Stock Disponibles o ya ha agregado este artìculo");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnSrp_Click(object sender, EventArgs e)
        {
            try
            {
                //Indice dila actualmente seleccionado y que vamos a eliminar
                int indiceFila = this.datalistadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];

                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
                this.SumaDescuento();
                this.CalcularSubTotal();
                this.CalcularIva();
                this.CalcularExento();
                this.CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay fila para remover");
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
        private void ImprimirTicket()
        {
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.TextoCentro("SENIAT"); //imprime una linea de descripcion
            Ticket1.TextoCentro("J-40924130-0");
            Ticket1.TextoCentro("");
            Ticket1.TextoCentro("G.V.V 2906, C.A."); //imprime una linea de descripcion
            Ticket1.TextoCentro("Sector la Barraca");
            Ticket1.TextoCentro("Calle B, Casa Nº 27");
            Ticket1.TextoCentro("Maracay-Edo Aragua");
            Ticket1.TextoCentro("Caja: Caja1");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoIzquierda("Nombre o Razon: " + Convert.ToString(this.txtCliente.Text));
            Ticket1.TextoIzquierda("Rif/Doc Cliente: " + Convert.ToString(this.txtDocumento.Text));
            Ticket1.TextoIzquierda("Tel: " + Convert.ToString(this.txtTelefono.Text));
            Ticket1.TextoIzquierda("Dir: " + Convert.ToString(this.txtDireccion.Text));
            Ticket1.TextoIzquierda("Trabajador: " + this.cbTrabajador.Text);
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("FACTURA"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac:" + "                       " + Convert.ToString(lblNumeroFactura.Text));
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + "       Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("");
            CreaTicket.LineasGuion();
            CreaTicket.EncabezadoVenta();
            CreaTicket.LineasGuion();
            foreach (DataGridViewRow fila in datalistadoDetalle.Rows)
            {
                // Articulo                     //Precio                                    cantidad                            Subtotal
                Ticket1.AgregaArticulo(fila.Cells[3].Value.ToString(), decimal.Parse(fila.Cells[5].Value.ToString()), decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[7].Value.ToString()));
            }
            CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", decimal.Parse(lblSubTotal.Text)); // imprime linea con Subtotal
            Ticket1.AgregaTotales("Menos Descuento", decimal.Parse(lblExonerado.Text)); // imprime linea con decuento total
            Ticket1.AgregaTotales("IVA %", decimal.Parse(lblTotal.Text)); // imprime linea con ITBis total
            Ticket1.AgregaTotales("TOTAL", decimal.Parse(lblTotal.Text)); // imprime linea con total
            CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Efectivo Entregado:", decimal.Parse(txtPago.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", decimal.Parse(txtCambio.Text));
            //Ticket1.LineasTotales(); // imprime linea
            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("****GRACIAS POR SU COMPRA****");
            Ticket1.TextoIzquierda(" ");
            Ticket1.ImprimirTiket(this.cbPrinter.Text);
        }

        private void Guardar()
        {
            try
            {
                string Rpta = "";
                string Rpta2 = "";
                if (this.txtIdArticulo.Text == string.Empty)
                {
                    this.lblError.Visible = true;
                }
                else
                {
                    if (this.IsNuevo)
                    { 
                        Rpta = LVenta.Insertar(this.cbTrabajador.Text, this.txtCliente.Text, this.lblFecha.Text, this.lblNumeroFactura.Text,
                            this.lblHora.Text, this.cbCondicionPago.Text, this.cbFormaPago.Text, Convert.ToDecimal(cbIva.Text), Convert.ToDecimal(lblIVA.Text),
                            Convert.ToDecimal(lblSubTotal.Text), Convert.ToDecimal(lblExonerado.Text), this.txtDocumento.Text, Convert.ToDecimal(this.lblTotal.Text), Convert.ToDecimal(txtCambio.Text), Convert.ToDecimal(txtPago.Text), txtTelefono.Text, txtDireccion.Text, dtDetalle);

                        //Verficacion para efectivo
                        decimal suma_entrada;
                        if (cbFormaPago.Text == "EFECTIVO") { suma_entrada = Convert.ToDecimal(this.lblTotal.Text); }
                        else { suma_entrada = Convert.ToDecimal("0,00"); }
                        decimal exento = Convert.ToDecimal(lblExento.Text);
                        decimal iva = Convert.ToDecimal(lblIVA.Text);
                        decimal exonerado = Convert.ToDecimal(lblExonerado.Text);
                        decimal total = Convert.ToDecimal(lblTotal.Text);

                        Rpta2 = LCaja.Editar(1, suma_entrada,Convert.ToDateTime(DateTime.Now.ToShortDateString()),exento,iva,exonerado,1,lblNumeroFactura.Text,
                        total);
                    }

                    if (Rpta.Equals("OK"))
                    {
                    }
                    else
                    {
                        MessageBox.Show(Rpta);
                    }
                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.crearTabla();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToShortTimeString();
            this.lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }

        private void chkvisible_OnChange(object sender, EventArgs e)
        {
            if (chkvisible.Checked == false)
            {
                this.txtConversion.Visible = false;
                this.cbPrinter.Visible = false;
            }
            else
            {
                this.txtConversion.Visible = true;
                this.cbPrinter.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelOver_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            PCaja form = new PCaja();
            form.ShowDialog();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            PBlock form = new PBlock();
            form.ShowDialog();
        }

       

    }
}
