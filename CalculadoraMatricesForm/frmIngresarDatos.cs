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
    public partial class frmIngresarDatos : Form
    {
        public frmIngresarDatos()
        {
            InitializeComponent();
        }
        private Colores colores=new Colores();
        public frmIngresarDatos(double numero)
        {
            InitializeComponent();
           
            nuevoValor = numero;
            txtNuevoValor.Text = nuevoValor.ToString();

        }
        public frmIngresarDatos(String texto) { 
            nuevoString = texto;
        }

        public double? nuevoValor;
        public String nuevoString = null;

        private void btnOk_Click(object sender, EventArgs e)
        {
            nuevoValor = FuncionesGenerales.IngresarDouble(txtNuevoValor.Text);
            if (nuevoValor == null && nuevoString==null)
            {
                FuncionesGenerales.MostrarMensaje("Debes ingresar un valor valido", 2);
            }
            else
            {
                nuevoString = nuevoValor.ToString();

                this.Close();
            }
        }

        private void txtNuevoValor_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevoValor.Text.Trim() == "")
            {
                btnOk.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
            }
        }

        private void frmIngresarDatos_Load(object sender, EventArgs e)
        {
            this.BackColor = colores.MARRON;
            this.ForeColor = colores.BLANCO;
            btnOk.BackColor = colores.BOTON_VOLVER;
        }
    }
}
