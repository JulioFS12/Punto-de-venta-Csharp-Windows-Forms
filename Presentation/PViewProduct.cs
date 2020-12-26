using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Logic;

namespace Presentation
{
    public partial class PViewProduct : Form
    {
        decimal OldActually = 0;
        decimal actually = 0;
        public PViewProduct()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMssage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void panelOver_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMssage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private static PViewProduct _instancia;

        public static PViewProduct GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PViewProduct();
            }
            return _instancia;
        }

        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        //Metodo set
        public void setArticulo(string idarticulo, string codigo, string nombre, string categoria, string descripcion, string presentacion, decimal precio_compra, decimal precio_venta, decimal existencia_actual, string unidad, string trabajador_responsable, string proveedor,
        string tipo_comprobante, string numero_comprobante, decimal iva, byte[] imagen, string impuesto, decimal descuento)
        {
            this.txtIdProduct.Text = idarticulo;
            this.txtCode.Text = codigo;
            this.txtName.Text = nombre;
            this.cbCategory.Text = categoria;
            this.txtDescription.Text = descripcion;
            this.cbPresentation.Text = presentacion;
            this.txtPurchasePrice.Text = Convert.ToString(precio_compra);
            this.txtSalePrice.Text = Convert.ToString(precio_venta);
            this.txtActualNumber.Text = Convert.ToString(existencia_actual);
            OldActually = Convert.ToDecimal(existencia_actual);
            this.cbMeasurementUnit.Text = unidad;
            this.cbSuplier.Text = proveedor;
            this.cbWorker.Text = trabajador_responsable;
            this.cbVoucherType.Text = tipo_comprobante;
            this.txtVaucherNumber.Text = numero_comprobante;
            this.cbIva.Text = Convert.ToString(iva);
            this.txtDiscount.Text = Convert.ToString(descuento);
            this.cbTax.Text = impuesto;
            Byte[] foto = imagen;
            MemoryStream ms = new MemoryStream(foto);
            this.pxPhoto.Image = Image.FromStream(ms);
            this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            Double value;
            if (Double.TryParse(txtActualNumber.Text, out value))
                txtActualNumber.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N3}", value);
            else
                txtActualNumber.Text = "0,000";

        }

        //Limpia los controles del formulario
        private void Limpiar()
        {
            this.txtIdProduct.Text = string.Empty; ;
            this.txtCode.Text = string.Empty; ;
            this.txtName.Text = string.Empty; ;
            this.cbCategory.Text = string.Empty; ;
            this.txtDescription.Text = string.Empty; ;
            this.cbPresentation.Text = string.Empty; ;
            this.txtPurchasePrice.Text = string.Empty; ;
            this.txtSalePrice.Text = string.Empty; ;
            this.txtActualNumber.Text = string.Empty; ;
            this.cbMeasurementUnit.Text = string.Empty;
            this.cbSuplier.Text = string.Empty; ;
            this.cbWorker.Text = string.Empty; ;
            this.cbVoucherType.Text = string.Empty; ;
            this.txtVaucherNumber.Text = string.Empty; ;
            this.cbIva.Text = string.Empty; ;
            this.txtDiscount.Text = string.Empty; ;
            this.cbTax.Text = string.Empty; ;

            this.pxPhoto.Image = global::Presentation.Properties.Resources.producto;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtCode.Enabled = Valor;
            this.txtName.Enabled = Valor;
            this.txtIdProduct.Enabled = Valor;
            this.txtIdProduct.Enabled = Valor;
            this.txtDescription.Enabled = Valor;
            this.txtPurchasePrice.Enabled = Valor;
            this.txtSalePrice.Enabled = Valor;
            this.cbMeasurementUnit.Enabled = Valor;
            this.txtVaucherNumber.Enabled = Valor;
            this.txtDiscount.Enabled = Valor;
        }
        //Habilita los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsModificar)
            {
                this.Habilitar(true);
                this.btnSave.Visible = true;
                this.btnCancel.Visible = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnSave.Visible = false;
                this.btnCancel.Visible = false;
            }
        }

        private void GetfullCategory()
        {
            cbCategory.DataSource = LCategory.Show();
            cbCategory.ValueMember = "Id Categoria";
            cbCategory.DisplayMember = "Nombre";
        }

        private void GetfullPresentation()
        {
            cbPresentation.DataSource = LPresentations.Show();
            cbPresentation.ValueMember = "Id Presentacion";
            cbPresentation.DisplayMember = "Nombre";
        }
        private void GetfullWorker()
        {
            cbWorker.DataSource = LPersonal.Show();
            cbWorker.ValueMember = "Id Trabajador";
            cbWorker.DisplayMember = "Nombre";
        }

        private void GetfullSuplier()
        {
            cbSuplier.DataSource = LSuplier.Show();
            cbSuplier.ValueMember = "Id Proveedor";
            cbSuplier.DisplayMember = "Razon Social";
        }
        private void GetfullTradeMark()
        {
            cbTradeMark.DataSource = LTradeMark.Show();
            cbTradeMark.ValueMember = "Id Marca";
            cbTradeMark.DisplayMember = "Nombre";
        }
        private void PViewProduct_Load(object sender, EventArgs e)
        {
            this.Habilitar(true);
            this.Botones();
            this.lblMistake.Visible = false;
            this.GetfullCategory();
            this.GetfullPresentation();
            this.GetfullSuplier();
            this.GetfullWorker();
            this.GetfullTradeMark();
        }

        private void txtEntryNumber_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtEntryNumber.Text, out value))
                txtEntryNumber.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N3}", value);
            else
                txtEntryNumber.Text = "0,000";
        }

        private void txtActualNumber_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtActualNumber.Text, out value))
                txtActualNumber.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N3}", value);
            else
                txtActualNumber.Text = "0,000";
        }

        private void txtPurchasePrice_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtPurchasePrice.Text, out value))
                txtPurchasePrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtPurchasePrice.Text = "0,00";
        }

        private void txtSalePrice_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtSalePrice.Text, out value))
                txtSalePrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtSalePrice.Text = "0,00";
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtDiscount.Text, out value))
                txtDiscount.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtDiscount.Text = "0,00";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCode.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtIdProduct.Text != string.Empty)
            {
                this.IsNuevo = false;
                this.IsModificar = true;
                this.Botones();
            }
            else
            {
                MessageBox.Show("Selecione antes un registro");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //La variable que almacena si se inserto
                //o se modifico la tabla
                if (this.txtCode.Text == string.Empty || this.txtName.Text == string.Empty || this.cbCategory.Text == string.Empty || this.cbPresentation.Text == string.Empty || this.txtPurchasePrice.Text == string.Empty || this.txtSalePrice.Text == string.Empty || this.cbMeasurementUnit.Text == string.Empty || this.cbWorker.Text == string.Empty || this.cbSuplier.Text == string.Empty || this.cbVoucherType.Text == string.Empty || this.txtVaucherNumber.Text == string.Empty || this.cbIva.Text == string.Empty || this.cbTax.Text == string.Empty || this.txtEntryNumber.Text == string.Empty)
                {

                    this.lblMistake.Visible = true;
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    this.pxPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] foto = ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        DataTable Datos = LProduct.ValidarArticulo(this.txtCode.Text);

                        if (Datos.Rows.Count >= 1)
                        {
                            Rpta = "El còdigo o articulo ya se encuentra registrado";
                        }
                        else
                        {
                            actually = Convert.ToDecimal(this.txtEntryNumber.Text) + OldActually;
                            this.lblMistake.Visible = false;
                            //Vamos a insertar un producto
                            Rpta = LProduct.Insertar(this.txtCode.Text.Trim(), this.txtName.Text.Trim(), this.cbCategory.Text.Trim(), this.txtDescription.Text.Trim(), this.cbPresentation.Text.Trim(), Convert.ToDecimal(this.txtPurchasePrice.Text.Trim()), Convert.ToDecimal(this.txtSalePrice.Text.Trim()), actually, this.cbMeasurementUnit.Text, foto, this.cbWorker.Text, this.cbSuplier.Text.Trim(), this.cbVoucherType.Text.Trim(), this.txtVaucherNumber.Text.Trim(), Convert.ToDecimal(this.cbIva.Text), this.cbTax.Text.Trim(), Convert.ToDecimal(this.txtDiscount.Text), cbTradeMark.Text);
                        }
                    }
                    else
                    {
                        decimal actually = Convert.ToDecimal(this.txtEntryNumber.Text) + OldActually;

                        Rpta = LProduct.Editar(Convert.ToInt32(this.txtIdProduct.Text), this.txtCode.Text.Trim(), this.txtName.Text.Trim(), this.cbCategory.Text.Trim(), this.txtDescription.Text.Trim(), this.cbPresentation.Text.Trim(), Convert.ToDecimal(this.txtPurchasePrice.Text), Convert.ToDecimal(this.txtSalePrice.Text), actually, this.cbMeasurementUnit.Text, foto, this.cbWorker.Text, this.cbSuplier.Text.Trim(), this.cbVoucherType.Text.Trim(), this.txtVaucherNumber.Text.Trim(), Convert.ToDecimal(this.cbIva.Text), this.cbTax.Text.Trim(), Convert.ToDecimal(this.txtDiscount.Text), cbTradeMark.Text);
                    }
                    //Si la respuesta fue OK, fue porque se modifico
                    //o inserto el Producto
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            MessageBox.Show("Se insertò el registro correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Se actualizò el registro correctamente");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        MessageBox.Show(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsModificar = false;
                    this.Botones();
                    this.Limpiar();
                    PProduct frm = Owner as PProduct;
                    frm.Mostrar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            this.pxPhoto.Image = global::Presentation.Properties.Resources.producto;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.IsNuevo = false;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Close();
        }

        private void txtCode_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void PViewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
