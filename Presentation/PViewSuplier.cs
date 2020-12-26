using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class PViewSuplier : Form
    {
        public PViewSuplier()
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

        private void panelOver_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.IsNew = false;
            this.IsEdit = false;
            this.Botones();
            this.Limpiar();
        }

        private static PViewSuplier _instancia;

        //Crear y conseguir instacia del form
        public static PViewSuplier GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PViewSuplier();
            }
            return _instancia;
        }

        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNew = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsEdit = false;

        //Metodo set
        public void setSuplier(string idsuplier, string registered_name, string comercial_sector, string document_type, string document_number, string address, string number_phone, string email, string web)
        {
            this.txtIdSuplier.Text = idsuplier;
            this.txtRegisteredName.Text = registered_name;
            this.cbComercialSector.Text = comercial_sector;
            this.cbDocumentType.Text = document_type;
            this.txtDocumentNumber.Text = document_number;
            this.txtAddress.Text = address;
            this.txtNumberPhone.Text = number_phone;
            this.txtEmail.Text = email;
            this.txtWeb.Text = web;
        }

        private void Modificar()
        {
            if (this.txtIdSuplier.Text != string.Empty)
            {
                this.IsEdit = true;
                this.IsNew = false;
                this.Botones();
            }
            else
            {
                MessageBox.Show("No ha elegido nungun registro");
            }
        }

        //Limpia los controles del formulario
        private void Limpiar()
        {
            this.txtIdSuplier.Text = string.Empty;
            this.txtRegisteredName.Text = string.Empty;
            this.txtDocumentNumber.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtNumberPhone.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtWeb.Text = string.Empty;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtRegisteredName.Enabled = !Valor;
            this.txtDocumentNumber.Enabled = !Valor;
            this.txtAddress.Enabled = !Valor;
            this.txtNumberPhone.Enabled = !Valor;
            this.txtEmail.Enabled = !Valor;
            this.txtWeb.Enabled = !Valor;
        }

        //Habilita los botones
        private void Botones()
        {
            if (this.IsNew || this.IsEdit)
            {
                this.Habilitar(false);
                this.btnSave.Visible = true;
                this.btnCancel.Visible = true;
            }
            else
            {
                this.Habilitar(true);
                this.btnSave.Visible = false;
                this.btnCancel.Visible = false;
            }
        }

        private void PViewSuplier_Load(object sender, EventArgs e)
        {
            this.lblMistake.Visible = false;
            this.Habilitar(true);
            this.Botones();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            this.IsEdit = false;
            this.Botones();
            this.Limpiar();
            this.txtRegisteredName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Modificar();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //La variable que almacena si se inserto
                //o se modifico la tabla
                if (this.txtRegisteredName.Text == string.Empty|| this.cbDocumentType.Text == string.Empty || this.cbComercialSector.Text == string.Empty|| this.txtNumberPhone.Text == string.Empty|| this.txtNumberPhone.Text == string.Empty)
                {

                    this.lblMistake.Visible = true;
                }
                else
                {
                    if (this.IsNew)
                    {
                        this.lblMistake.Visible = false;
                        //Vamos a insertar un producto
                        Rpta = LSuplier.Insert(this.txtRegisteredName.Text.Trim(), this.cbComercialSector.Text.Trim(),  this.cbDocumentType.Text, this.txtDocumentNumber.Text, this.txtAddress.Text,this.txtNumberPhone.Text, this.txtEmail.Text,this.txtWeb.Text);

                    }
                    else
                    {
                        //Vamos a modificar un producto
                        Rpta = LSuplier.Edit(Convert.ToInt32(this.txtIdSuplier.Text), this.txtRegisteredName.Text.Trim(), this.cbComercialSector.Text.Trim(),  this.cbDocumentType.Text, this.txtDocumentNumber.Text, this.txtAddress.Text,this.txtNumberPhone.Text, this.txtEmail.Text,this.txtWeb.Text);
                    }
                    //Si la respuesta fue OK, fue porque se modifico
                    //o inserto el Producto
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNew)
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
                    this.IsNew = false;
                    this.IsEdit = false;
                    this.Botones();
                    this.Limpiar();
                    this.txtIdSuplier.Text = "";
                    PSuplier frm = Owner as PSuplier;
                    frm.ShowTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsNew = false;
            this.IsEdit = false;
            this.Botones();
            this.Limpiar();
            this.txtIdSuplier.Text = string.Empty;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.IsNew = false;
            this.IsEdit = false;
            this.Botones();
            this.Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PViewSuplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

    }
}
