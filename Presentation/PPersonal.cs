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
    public partial class PPersonal : Form
    {
        public PPersonal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMssage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void panelOver_MouseDown_1(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMssage(this.Handle, 0x112, 0xf012, 0);
        }
        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataGridViewCategory.Columns[0].Visible = false;
            this.dataGridViewCategory.Columns[1].Visible = false;
            this.dataGridViewCategory.Columns[6].Visible = false;
            this.dataGridViewCategory.Columns[7].Visible = false;
        }

        //Método Mostrar
        public void ShowTable()
        {
            this.dataGridViewCategory.DataSource = LPersonal.Show();
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        //Método BuscarNombre
        private void SearchDocument()
        {
            this.dataGridViewCategory.DataSource = LPersonal.Search(this.txtSearch.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(dataGridViewCategory.Rows.Count);
        }

        private void PPersonal_Load(object sender, EventArgs e)
        {
            this.ShowTable();
            this.lblMistake.Visible = false;
            this.Habilitar(true);
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.SearchDocument();
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
                            Rpta = LPersonal.Delete(Convert.ToInt32(Codigo));

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

        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNew = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsEdit = false;

        private void Modificar()
        {
            if (this.txtIdWorker.Text != string.Empty)
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
            this.txtSecondName.Text = string.Empty;
            this.txtDocumetNumber.Text = string.Empty;
            this.txtUser.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtIdWorker.Text = string.Empty;
            this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxPhoto.Image = global::Presentation.Properties.Resources.User_Group;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtName.Enabled = !Valor;
            this.txtSecondName.Enabled = !Valor;
            this.txtDocumetNumber.Enabled = !Valor;
            this.txtUser.Enabled = !Valor;
            this.txtPassword.Enabled = !Valor;
            this.txtIdWorker.Enabled = !Valor;
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

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtIdWorker.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Id trabajador"].Value);
            this.txtName.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Nombre"].Value);
            this.txtSecondName.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Apellido"].Value);
            this.cbDocumentType.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Tipo Documento"].Value);
            this.txtDocumetNumber.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Numero Documento"].Value);
            this.txtUser.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Usuario"].Value);
            this.txtPassword.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Contraseña"].Value);
            this.cbPosition.Text = Convert.ToString(this.dataGridViewCategory.CurrentRow.Cells["Cargo"].Value);

            byte[] imagenBuffer = (byte[])this.dataGridViewCategory.CurrentRow.Cells["Photo"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.pxPhoto.Image = Image.FromStream(ms);
            this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
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
                if (this.txtName.Text == string.Empty || this.txtSecondName.Text == string.Empty || this.cbDocumentType.Text == string.Empty || this.txtDocumetNumber.Text == string.Empty || this.txtUser.Text == string.Empty || this.xx.Text == string.Empty || this.cbPosition.Text == string.Empty)
                {
                    this.lblMistake.Visible = true;
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen = ms.GetBuffer();

                    if (this.IsNew)
                    {
                        this.lblMistake.Visible = false;
                            //Vamos a insertar un producto
                            Rpta = LPersonal.Insert(this.txtName.Text.Trim(), this.txtSecondName.Text.Trim(), this.cbDocumentType.Text.Trim(), this.txtDocumetNumber.Text.Trim(), this.txtUser.Text.Trim(), this.txtPassword.Text.Trim(), imagen,this.cbPosition.Text.Trim());
                    }
                    else
                    {
                        //Vamos a modificar un producto
                        Rpta = LPersonal.Edit(Convert.ToInt32(this.txtIdWorker.Text), this.txtName.Text.Trim(), this.txtSecondName.Text.Trim(), this.cbDocumentType.Text.Trim(), this.txtDocumetNumber.Text.Trim(), this.txtUser.Text.Trim(), this.txtPassword.Text.Trim(), imagen, this.cbPosition.Text.Trim());
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
                    this.txtIdWorker.Text = "";
                    this.ShowTable();
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
            this.txtIdWorker.Text = string.Empty;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            this.pxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxPhoto.Image = global::Presentation.Properties.Resources.User_Group;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.IsNew = false;
            this.IsEdit = false;
            this.Botones();
            this.Limpiar();
        }

    }
}
