using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PBlock : Form
    {
        public PBlock()
        {
            InitializeComponent();
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
                this.Close();
            }
        }
    }
}
