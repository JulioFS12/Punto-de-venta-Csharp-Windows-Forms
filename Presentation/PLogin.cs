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

namespace Presentation
{
    public partial class PLogin : Form
    {
        public PLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMssage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        private void PLogin_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PLogin_Load(object sender, EventArgs e)
        {
            PWelcoming frm = new PWelcoming();
            frm.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataTable Datos = Logic.LLogin.Login(this.txtUser.Text, this.txtPassword.Text);
            //Evaluar si existe el Usuario
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            MainMenu frm = new MainMenu();
            frm.Idtrabajador = Datos.Rows[0][0].ToString();
            frm.Nombre = Datos.Rows[0][1].ToString();
            frm.Apellido = Datos.Rows[0][2].ToString();
            frm.Cargo = Datos.Rows[0][3].ToString();
            frm.Foto = (Byte[])Datos.Rows[0][4];
            frm.Show();
            this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

    }
}
