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
    public partial class RegisterProduct : Form
    {
        public RegisterProduct()
        {
            InitializeComponent();
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataTable Validar = Logic.LRegister.ValidarSerial(this.txtName.Text);
            if (Validar.Rows.Count == 1)
            {
                Logic.LRegister.Insert(txtName.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("El serial ingresado es incorecto");
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            this.txtName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
