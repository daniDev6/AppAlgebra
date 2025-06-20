using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatricesForm
{
    public partial class UCInfo : UserControl
    {
        Colores colores=new Colores();
        public UCInfo()
        {
            InitializeComponent();
            btnVolver.BackColor = colores.BOTON_VOLVER;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal=this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) {
                frmPrincipal.irAlMenu();
            }
        }
        private void AbrirEnlace(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
            }
        }

        private void pctWp_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://api.whatsapp.com/send?phone=541151387649&text=Hola%20buenas%20DaniDev%2C%20me%20gustaria%20saber%20mas%20sobre%20tus%20proyectos.");

        }

        private void pctGmail_Click(object sender, EventArgs e)
        {
            AbrirEnlace("mailto:danidev067@gmail.com");

        }

        private void pctLink_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://www.linkedin.com/in/daniel-villalba-developer/");

        }

        private void pctGitHub_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://github.com/daniDev6");

        }
    }
}
