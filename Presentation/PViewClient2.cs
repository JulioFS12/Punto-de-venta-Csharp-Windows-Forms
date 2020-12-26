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
    public partial class PViewClient2 : Form
    {
        public PViewClient2()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                //La variable que almacena si se inserto
                //o se modifico la tabla
                if (this.txtName.Text == string.Empty || this.cbDocumentType.Text == string.Empty || this.txtDocNumber.Text == string.Empty || this.txtAddress.Text == string.Empty)
                {

                    this.lblMistake.Enabled = true;
                }
                else
                {
                   
                        this.lblMistake.Enabled = false;
                        //Vamos a insertar un producto
                        Rpta = LClient.Insertar(this.txtName.Text.Trim(), this.cbDocumentType.Text.Trim(), this.txtDocNumber.Text.Trim(), this.txtAddress.Text.Trim(), this.txtPhone.Text.Trim());

                   
                    if (Rpta.Equals("OK"))
                    {
                       
                            MessageBox.Show("Se insertò el registro correctamente");
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
