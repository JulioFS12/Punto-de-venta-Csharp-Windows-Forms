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
using Logic;

namespace Presentation
{
    public partial class PViewClient : Form
    {
        public PViewClient()
        {
            InitializeComponent();
        }
        private static PViewClient _instancia;

        public static PViewClient GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PViewClient();
            }
            return _instancia;
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
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        //Metodo set
        public void setCliente(string idcliente, string nombre,  string tipo_documento,
            string numero_documento, string direccion, string telefono)
        {
            this.txtIdCliente.Text = idcliente;
            this.txtName.Text = nombre;
            this.txtDocNumber.Text = numero_documento;
            this.cbDocumentType.Text = tipo_documento;
            this.txtPhone.Text = telefono;
            this.txtAddress.Text = direccion;
        }
        private void Modificar()
        {
            if (this.txtIdCliente.Text != string.Empty)
            {
                this.IsNuevo = false;
                this.IsModificar = true;
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
            this.txtIdCliente.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtDocNumber.Text = string.Empty;
            this.cbDocumentType.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtIdCliente.Enabled = !Valor;
            this.txtName.Enabled = !Valor;
            this.txtDocNumber.Enabled = !Valor;
            this.txtPhone.Enabled = !Valor;
            this.txtAddress.Enabled = !Valor;;
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsModificar)
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

        private void PViewClient_Load(object sender, EventArgs e)
        {
            this.lblMistake.Visible = false;
            this.Habilitar(true);
            this.Botones();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.txtName.Focus();
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
                if (this.txtName.Text == string.Empty || this.cbDocumentType.Text == string.Empty || this.txtDocNumber.Text == string.Empty || this.txtAddress.Text == string.Empty||this.txtPhone.Text == string.Empty)
                {

                    this.lblMistake.Enabled = true;
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        this.lblMistake.Visible = false;
                        //Vamos a insertar un producto
                        Rpta = LClient.Insertar(this.txtName.Text.Trim(),this.cbDocumentType.Text.Trim(), this.txtDocNumber.Text.Trim(), this.txtAddress.Text.Trim(), this.txtPhone.Text.Trim());

                    }
                    else
                    {
                        //Vamos a modificar un producto
                        Rpta = LClient.Editar(Convert.ToInt32(this.txtIdCliente.Text), this.txtName.Text.Trim(), this.cbDocumentType.Text.Trim(), this.txtDocNumber.Text.Trim(), this.txtAddress.Text.Trim(), this.txtPhone.Text.Trim());
                    }

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
                    PClient frm = Owner as PClient;
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
            this.IsNuevo = false;
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PViewClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

       
    }
}
