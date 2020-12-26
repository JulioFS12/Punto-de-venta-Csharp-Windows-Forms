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
    public partial class PViewProductVenta : Form
    {
        public PViewProductVenta()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataGridViewCategory.Columns[0].Visible = false;
            this.dataGridViewCategory.Columns[1].Visible = false;
            this.dataGridViewCategory.Columns[13].Visible = false;
            this.dataGridViewCategory.Columns[14].Visible = false;
            this.dataGridViewCategory.Columns[15].Visible = false;
            this.dataGridViewCategory.Columns[16].Visible = false;
            this.dataGridViewCategory.Columns[17].Visible = false;
            this.dataGridViewCategory.Columns[18].Visible = false;
        }

        //Método Mostrar
        public void Mostrar()
        {
            this.dataGridViewCategory.DataSource = LProduct.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        private void BuscarCodigo()
        {
            this.dataGridViewCategory.DataSource = LProduct.BuscarCodigo(this.txtSearch.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        private void PViewProductVenta_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.BuscarCodigo();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PVenta form = PVenta.GetInstancia();
            string par2, par3, par6, par8;
            int par1 = Convert.ToInt32(this.dataGridViewCategory.CurrentRow.Cells["Id Articulo"].Value);
            par2 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Codigo"].Value);
            par3 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Nombre"].Value);
            decimal par4 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Precio de venta"].Value);
            decimal par5 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Existencia actual"].Value);
            par6 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Impuesto"].Value);
            decimal par7 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Descuento"].Value);
            par8 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Descripcion"].Value);

            form.setArticulo(par1, par2, par3, par4, par5, par6, par7, par8);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }
    }
}
