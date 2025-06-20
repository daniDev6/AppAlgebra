using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatricesForm
{
    public partial class UCMenu : UserControl
    {
        Colores colores = new Colores();
        public UCMenu()
        {
            InitializeComponent();

            
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal=this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) { frmPrincipal.irAInfo(); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) { frmPrincipal.Close(); }
        }

        private void btnEL_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) { frmPrincipal.irAEcuacionesLineales(); }
        }

        private void btnMatrices_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) { frmPrincipal.irAMatrices(); }
        }

        private void UCMenu_Load(object sender, EventArgs e)
        {
            btnEL.BackColor = colores.AZUL_CLARO;
            btnMatrices.BackColor=colores.AZUL_CLARO;
            btnInfo.BackColor=colores.BOTON_NARANJA;
            btnSalir.BackColor=colores.BOTON_ROJO;
        }
    }
}
