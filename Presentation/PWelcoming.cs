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
    public partial class PWelcoming : Form
    {
        public PWelcoming()
        {
            InitializeComponent();
        }

        private void Abrirdatos()
        {
            //PDatos_Empresa frm = new PDatos_Empresa();
            //frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();
                this.Visible = false;
                //DataTable Datos = Negocio.NDatos_Empresa.VerificarEmpresa();
                //Evaluar si existe el Usuario
                //if (Datos.Rows.Count == 0)
                //{
                //Abrirdatos();
                //}
                //else
                //{
                PLogin obj = new PLogin();
                obj.Show();
                //}
            }
        }

        private void PWelcoming_Load(object sender, EventArgs e)
        {

            bunifuCircleProgressbar1.Value = 0;
            this.Opacity = 0;
            this.timer1.Start();
        }
    }
}
