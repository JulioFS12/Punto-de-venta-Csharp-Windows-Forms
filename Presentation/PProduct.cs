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
    public partial class PProduct : Form
    {
        public PProduct()
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

        private void PProduct_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.BuscarCodigo();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }

        private void chkDelete_OnChange(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dataGridViewCategory.Columns[0].Visible = true;
            }
            else
            {
                this.dataGridViewCategory.Columns[0].Visible = false;
            }
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCategory.Columns["Spr"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataGridViewCategory.Rows[e.RowIndex].Cells["Spr"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los registros?", "Sistema Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataGridViewCategory.Rows)
                    {

                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = LProduct.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se eliminó de forma correcta el registro");
                            }
                            else
                            {
                                //Mostramos el mensaje de error
                                MessageBox.Show(Rpta);
                            }
                        }
                    }

                    this.Mostrar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PViewProduct form = PViewProduct.GetInstancia();
            AddOwnedForm(form);
            string par1, par2, par3, par4, par5, par6, par12, par14, par15, par16, par17, par20;
            decimal par7, par8, par10, par18, par21;
            Byte[] par19;
            par1 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Id Articulo"].Value);
            par2 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Codigo"].Value);
            par3 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Nombre"].Value);
            par4 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Categoria"].Value);
            par5 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Descripcion"].Value);
            par6 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Presentacion"].Value);
            par7 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Precio de compra"].Value);
            par8 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Precio de venta"].Value);
            par10 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Existencia actual"].Value);
            par12 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Unidad de medida"].Value);
            par14 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Trabajador responsable"].Value);
            par15 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Proveedor"].Value);
            par16 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Tipo de comprobante"].Value);
            par17 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Numero de comprobante"].Value);
            par18 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["IVA"].Value);
            par20 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Impuesto"].Value);
            par21 = Convert.ToDecimal(this.dataGridViewCategory.CurrentRow.Cells["Descuento"].Value);
            par19 = (Byte[])this.dataGridViewCategory.CurrentRow.Cells["Imagen"].Value;

            form.setArticulo(par1, par2, par3, par4, par5, par6, par7, par8, par10, par12,
             par14, par15, par16, par17, par18, par19, par20, par21);
            form.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            PViewProduct form = PViewProduct.GetInstancia();
            AddOwnedForm(form);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
