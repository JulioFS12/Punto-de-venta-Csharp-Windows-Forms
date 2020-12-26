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
    public partial class PViewTradeMark : Form
    {
        public PViewTradeMark()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.IsNew = false;
            this.IsEdit = false;
            this.Botones();
            this.Limpiar();
        }

        private static PViewTradeMark _instancia;

        //Crear y conseguir instacia del form
        public static PViewTradeMark GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PViewTradeMark();
            }
            return _instancia;
        }

        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNew = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsEdit = false;

        //Metodo set
        public void setTradeMark(string idtrademark, string nombre, string descripcion)
        {
            this.txtIdTradeMark.Text = idtrademark;
            this.txtName.Text = nombre;
            this.txtDescription.Text = descripcion;
        }

        private void Modificar()
        {
            if (this.txtIdTradeMark.Text != string.Empty)
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
            this.txtName.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtIdTradeMark.Text = string.Empty;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtName.Enabled = !Valor;
            this.txtDescription.Enabled = !Valor;
            this.txtIdTradeMark.Enabled = !Valor;
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

        private void PViewTradeMark_Load(object sender, EventArgs e)
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
                if (this.txtName.Text == string.Empty)
                {

                    this.lblMistake.Visible = true;
                }
                else
                {
                    if (this.IsNew)
                    {
                        this.lblMistake.Visible = false;
                        //Vamos a insertar un producto
                        Rpta = LTradeMark.Insert(this.txtName.Text.Trim(),
                                   this.txtDescription.Text.Trim());

                    }
                    else
                    {
                        //Vamos a modificar un producto
                        Rpta = LTradeMark.Edit(Convert.ToInt32(this.txtIdTradeMark.Text),
                                     this.txtName.Text.Trim(),this.txtDescription.Text.Trim());
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
                    this.txtIdTradeMark.Text = "";
                    PTradeMark frm = Owner as PTradeMark;
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
            this.txtIdTradeMark.Text = string.Empty;
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

        private void PViewTradeMark_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
