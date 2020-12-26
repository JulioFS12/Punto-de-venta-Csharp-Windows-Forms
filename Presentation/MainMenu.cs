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

namespace Presentation
{
    public partial class MainMenu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMssage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        public MainMenu()
        {
            InitializeComponent();
            panelMenu.Width = 40;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (panelMenu.Width == 300)
            {
                while (panelMenu.Width > 40) {panelMenu.Width -= 20; }
            }
            else if (panelMenu.Width == 40)
            {
                while (panelMenu.Width < 300) { panelMenu.Width += 20; }
            }
        }

        private void OpenClose()
        {
            if (panelMenu.Width == 300)
            {
                while (panelMenu.Width > 40) { panelMenu.Width -= 20; }
            }
            else if (panelMenu.Width == 40)
            {
                while (panelMenu.Width < 300) { panelMenu.Width += 20; }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString();
        }

        //Datos de usuario
        public string Idtrabajador = "";
        public string Nombre = "";
        public string Apellido = "";
        public string Cargo = "";
        public Byte[] Foto;

        //Permisos de usuario
        private void GestionUsuario()
        {
            if (Cargo == "Gerente")
            {
                

            }
            else if (Cargo == "Encargado")
            {
                this.btnClient.Enabled = false;
                this.btnCategory.Enabled = false;
                this.btnPresentation.Enabled = false;
                this.BtnSuplier.Enabled = false;
                this.btnPresentation.Enabled = false;
                this.btnProduct.Enabled = false;
                this.btnPersonal.Enabled = false;
            }
            else if (Cargo == "Trabajador")
            {
                this.btnClient.Enabled = false;
                this.btnCategory.Enabled = false;
                this.btnPresentation.Enabled = false;
                this.BtnSuplier.Enabled = false;
                this.btnPresentation.Enabled = false;
                this.btnProduct.Enabled = false;
                this.btnPersonal.Enabled = false;
                this.btnSale.Enabled = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();

            lblName.Text = Nombre;
            lblSecondName.Text = Apellido;
            Byte[] foto = Foto;

            MemoryStream ms = new MemoryStream(foto);
            this.pxPhoto.Image = Image.FromStream(ms);
            this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            lblPosition.Text = Cargo;
            GestionUsuario();

            DateTime fechaFinal = dateTimePicker1.Value;
            DateTime FechaActual = DateTime.Now;

            int totalDays = Convert.ToInt32((fechaFinal - FechaActual).Days);

            if (totalDays <= 0)
            {
                DataTable DatosValidacion = Logic.LRegister.ValidarActivacion();
                if (DatosValidacion.Rows.Count != 2)
                {
                    RegisterProduct form = new RegisterProduct();
                    form.ShowDialog();
                }
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            OpenClose();
            PClient form = new PClient();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenClose();
            PTradeMark form = new PTradeMark();
            form.ShowDialog();
        }

        private void BtnSuplier_Click(object sender, EventArgs e)
        {
            OpenClose();
            PSuplier form = new PSuplier();
            form.ShowDialog();
        }

        private void btPresentation_Click(object sender, EventArgs e)
        {
            OpenClose();
            PPresentations form = new PPresentations();
            form.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenClose();
            PCategory form = new PCategory();
            form.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenClose();
            PProduct form = new PProduct();
            form.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            OpenClose();
            PVenta form = PVenta.GetInstancia();
            form.ShowDialog();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            OpenClose();
            PPersonal form = new PPersonal();
            form.ShowDialog();
        }

        private void btnFacturaion_Click(object sender, EventArgs e)
        {
            OpenClose();
            this.WindowState = FormWindowState.Minimized;
            PVenta form = PVenta.GetInstancia();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            ReportesVenta form = new ReportesVenta();
            form.ShowDialog();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}