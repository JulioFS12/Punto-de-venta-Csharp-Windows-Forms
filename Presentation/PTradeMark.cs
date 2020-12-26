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
    public partial class PTradeMark : Form
    {
        public PTradeMark()
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

        private void HideColumns()
        {
            this.dataGridViewCategory.Columns[0].Visible = false;
            this.dataGridViewCategory.Columns[1].Visible = false;
        }

        //Método Mostrar()

        public void ShowTable()
        {
            this.dataGridViewCategory.DataSource = LTradeMark.Show();
            this.HideColumns();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        //Método BuscarNombre

        private void SearchName()
        {
            this.dataGridViewCategory.DataSource = LTradeMark.Search(this.txtSearch.Text);
            this.HideColumns();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        private void PTradeMark_Load(object sender, EventArgs e)
        {
            this.ShowTable();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.SearchName();
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
                            Rpta = LTradeMark.Delete(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se eliminó de forma correcta el registro");
                            }
                            else
                            {
                                MessageBox.Show(Rpta);
                            }
                        }
                    }

                    this.ShowTable();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PViewTradeMark form = new PViewTradeMark();
            AddOwnedForm(form);
            string par1, par2, par3;
            par1 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Id Marca"].Value);
            par2 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Nombre"].Value);
            par3 = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Descripcion"].Value);
            form.setTradeMark(par1, par2, par3);
            form.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            PViewTradeMark form = PViewTradeMark.GetInstancia();
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
