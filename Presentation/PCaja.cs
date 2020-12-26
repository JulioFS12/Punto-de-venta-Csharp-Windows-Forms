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
    public partial class PCaja : Form
    {
        public PCaja()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMssage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        private void panelOver_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMssage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PCaja_Load(object sender, EventArgs e)
        {
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(this.txtName.Text, out value))
                txtName.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", value);
            else
                txtName.Text = "0,00";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                    string Rpta = "";

                    if (this.txtName.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor rellene el campo nombre");
                    }
                    else
                    {
                        Rpta = LCaja.Insertar(Convert.ToDecimal(txtName.Text), Convert.ToDecimal("0,00"), Convert.ToDateTime(DateTime.Now.ToShortDateString()), Convert.ToDecimal("0,00"), Convert.ToDecimal("0,00"), Convert.ToDecimal("0,00"), Convert.ToInt32("0"), "000000000", Convert.ToDecimal("0,00"));

                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Se aperturò caja correctamente");
                            this.Close();
                        }
                        else
                        {
                            //Mostramos el mensaje de error
                            MessageBox.Show(Rpta);
                        }
                    }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
