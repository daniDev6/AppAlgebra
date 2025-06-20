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
    public partial class frmPrincipal : Form
    {
        Colores colores=new Colores();
        public frmPrincipal()
        {
            InitializeComponent();
            this.BackColor=colores.AZUL_OSCURO;
            this.ForeColor = colores.BLANCO;
            this.FormBorderStyle=FormBorderStyle.FixedSingle;
        }


        UCMenu uCMenu = new UCMenu();
        UCInfo uCInfo = new UCInfo();
        UCELineal uCELineal = new UCELineal();
        UCSuma uCSuma = new UCSuma();
        public void irAlMenu() { 
            irAPantalla(uCMenu);
        }
        public void irAInfo() {
            irAPantalla(uCInfo);
        }
        public void irAEcuacionesLineales() {
            irAPantalla(uCELineal);
        }
        public void irAMatrices() { 
            irAPantalla(uCSuma);
        }
        public void irAPantalla(UserControl userControl) { 
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(userControl);
            pnlPrincipal.Width = userControl.Width;
            pnlPrincipal.Height = userControl.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            userControl.BackColor = Color.Transparent;


            this.Size=pnlPrincipal.Size;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            irAlMenu();
            this.AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
