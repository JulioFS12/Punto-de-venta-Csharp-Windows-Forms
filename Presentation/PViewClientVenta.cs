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

namespace Presentation
{
    public partial class PViewClientVenta : Form
    {
        public PViewClientVenta()
        {
            InitializeComponent();
        }
        private void HideColumns()
        {
            this.dataGridViewCategory.Columns[0].Visible = false;
            this.dataGridViewCategory.Columns[1].Visible = false;
        }
        public void ShowTable()
        {
            this.dataGridViewCategory.DataSource = LClient.Mostrar();
            this.HideColumns();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        private void SearchName()
        {
            this.dataGridViewCategory.DataSource = LClient.BuscarNum_Documento(this.txtSearch.Text);
            this.HideColumns();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.SearchName();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PVenta form = PVenta.GetInstancia();
            string par1, par2, par3, par4;
            par1 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Nombre y Apellido"].Value);
            par2 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Numero de documento"].Value);
            par3 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Telefono"].Value);
            par4 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Direccion"].Value);
            form.setCliente(par1, par2, par3, par4);
            this.Close();
        
        }

        private void PViewClientVenta_Load(object sender, EventArgs e)
        {
            this.ShowTable();
        }

        private void PViewClientVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
