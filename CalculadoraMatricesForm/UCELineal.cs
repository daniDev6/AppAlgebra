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
    public partial class UCELineal : UserControl
    {
        Componentes componentes=new Componentes();
        Colores colores = new Colores();
        public UCELineal()
        {
            InitializeComponent();
            btnCalcular.BackColor = colores.BOTON_NARANJA;
            btnVolver.BackColor= colores.BOTON_VOLVER;
            btnLimpiar.BackColor= colores.BOTON_ROJO;
        }
        string[,] variablesGlobales;
        double[,] matrizProblema;

        private void UCELineal_Load(object sender, EventArgs e)
        {
            cmbCantVariable.Items.Clear();
            for (int i = 2; i < 4; i++) {
                cmbCantVariable.Items.Add(i.ToString());
            }
            cmbCantVariable.SelectedIndex = 0;
        }
        public void RellenarMatrices() {

            if (cmbCantVariable.Items == null) return;
            int columnasVariables = (int)FuncionesGenerales.IngresarEntero(cmbCantVariable.SelectedItem.ToString());
            if (columnasVariables == 3)
            {
                variablesGlobales = new string[,] { { "X", "Y", "Z", "Sol" } };
            }
            else { 
                variablesGlobales=new string[,]{ { "X", "Y", "Sol" } };

            }
            matrizProblema = new double[columnasVariables, columnasVariables + 1];
            componentes.ActualizarMatrizTabla(tlpVariables, variablesGlobales, false);
            componentes.ActualizarMatrizTabla(tlpMatriz, matrizProblema,true);
        }

        private void cmbCantVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantVariable.SelectedItem == null) { MessageBox.Show("Saliendo"); return; }; 
            RellenarMatrices();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Resultado result=EcuacionesLineales.GaussJordan(matrizProblema);

            if(result != null ) {
            if (EcuacionesLineales.ConSolucion(result))
            {
                    if (!EcuacionesLineales.ConSolucionFinita(result))
                    {
                        FuncionesGenerales.MostrarMensaje("El sistema es Compatible Indeterminado", 2);
                    }
                    else { 
                        string[,] respuestas = new string[result.Result.Length, 2];
                for (int i = 0; i < result.Result.Length; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            respuestas[i, j] = "X";
                        }
                        else if (i == 1 && j == 0)
                        {
                            respuestas[i, j] = "Y";

                        }
                        else if (i == 2 && j == 0)
                        {
                            respuestas[i, j] = "Z";

                        }
                        else
                        {
                            respuestas[i, j] = result.Result[i];

                        }
                    }
                }
                componentes.ActualizarMatrizTabla(tlpSolucion, respuestas, false);
                    }
                }

                else { 
                FuncionesGenerales.MostrarMensaje("El sistema es Incompatible", 2);

            }
            }
            componentes.ActualizarMatrizTabla(tlpIncognitas, variablesGlobales, false);

            componentes.ActualizarMatrizTabla(tlpResultadosMatriz, matrizProblema, false);
            btnCalcular.Enabled = false;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tlpSolucion.Controls.Clear();
            tlpIncognitas.Controls.Clear();
            tlpResultadosMatriz.Controls.Clear();
            cmbCantVariable.SelectedIndex = 0;
            RellenarMatrices();
            btnCalcular.Enabled=true;
   
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) { frmPrincipal.irAlMenu(); };
        }
    }
}
