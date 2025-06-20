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
    public partial class UCSuma : UserControl
    {
        Componentes componentes = new Componentes();
        Colores colores = new Colores();
        double[,] matrizA;
        double[,] matrizB;
        double[,] matrizSolucion;
        public UCSuma()
        {
            InitializeComponent();
            btnLimpiar.BackColor = colores.BOTON_ROJO;
            btnIB.BackColor= colores.BOTON_NARANJA;
            btnIA.BackColor= colores.BOTON_NARANJA;
            btnTB.BackColor= colores.BOTON_NARANJA;
            btnTA.BackColor= colores.BOTON_NARANJA;
            btnDeterminanteA.BackColor= colores.BOTON_NARANJA;
            btnDeterminanteB.BackColor= colores.BOTON_NARANJA;
            btnVolver.BackColor=colores.BOTON_VOLVER;
            btnSumar.BackColor = colores.AZUL_CLARO;
            btnRestar.BackColor = colores.AZUL_CLARO;
            btnMultiplicar.BackColor = colores.AZUL_CLARO;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            matrizSolucion=MatricesMath.SumarMatrices(matrizA, matrizB);
            componentes.ActualizarMatrizTabla(tlpResultado,matrizSolucion,false);
            componentes.PonerTitulo(lblTMR,tlpResultado,"Resultado SUMA");
            borrarTabla2();
            
        }
 
        private void UCSuma_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++) {
                cmbFilasA.Items.Add(i);
                cmbFilasB.Items.Add(i);
                cmbColumnasB.Items.Add(i);
                cmbColumnasA.Items.Add(i);
            }
            cmbFilasA.SelectedIndex = 2;
            cmbFilasB.SelectedIndex = 2;
            cmbColumnasB.SelectedIndex = 2;
            cmbColumnasA.SelectedIndex = 2;
        }

        private void cmbFilasA_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla(tlpMatrizA, lblTMAA, "A", cmbFilasA, cmbColumnasA, 0);

        }
        private void cmbColumnasA_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla(tlpMatrizA, lblTMAA, "A", cmbFilasA, cmbColumnasA, 0);
        }
        private void ActualizarTabla(TableLayoutPanel panel,Label titulo,string tituloString, ComboBox filas, ComboBox columnas, int opcion) {
            actualizarMatrizTabla(panel, filas,columnas, opcion);
            componentes.PonerTitulo(titulo, panel, tituloString);
            HabilitarBotones();
        }

        private void cmbFilasB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla(tlpMatrizB,lblTMB,"B",cmbFilasB, cmbColumnasB, 1);
        }

        private void cmbColumnasB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla(tlpMatrizB, lblTMB, "B", cmbFilasB, cmbColumnasB, 1);


        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            matrizSolucion = MatricesMath.RestaMatrices(matrizA, matrizB);
            componentes.ActualizarMatrizTabla(tlpResultado, matrizSolucion, false);
            componentes.PonerTitulo(lblTMR, tlpResultado, "Resultado RESTA");

            borrarTabla2();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            borrarTabla2();
            if (matrizA.GetLength(0) == 1 && matrizA.GetLength(1) == 1)
            {
                matrizSolucion = MatricesMath.MultiplicacionMatrices(matrizB, matrizA[0, 0]);
                componentes.ActualizarMatrizTabla(tlpResultado, matrizSolucion, false);
            }else if (matrizB.GetLength(0) == 1 && matrizB.GetLength(1) == 1)
            {
                matrizSolucion = MatricesMath.MultiplicacionMatrices(matrizA, matrizB[0, 0]);
                componentes.ActualizarMatrizTabla(tlpResultado, matrizSolucion, false);
            }
            else {
                matrizSolucion = MatricesMath.MultiplicacionMatrices(matrizA, matrizB);
                componentes.ActualizarMatrizTabla(tlpResultado, matrizSolucion, false);
            }
            componentes.PonerTitulo(lblTMR, tlpResultado, "Resultado");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            tlpResultado.Controls.Clear();
            cmbColumnasA.SelectedIndex = 0;
            cmbColumnasB.SelectedIndex = 0;
            cmbFilasA.SelectedIndex = 0;
            cmbFilasB.SelectedIndex = 0;
            ActualizarTabla(tlpMatrizA, lblTMAA, "A", cmbFilasA, cmbColumnasA, 0);
            ActualizarTabla(tlpMatrizA, lblTMB, "B", cmbFilasB, cmbColumnasB, 1);
            borrarTabla2();

        }
        private void borrarTabla2() { 
            tlpInversaB.Controls.Clear ();
        }

        private void btnDeterminanteA_Click(object sender, EventArgs e)
        {
            lblDetA.Text = MatricesMath.Determinante(matrizA).ToString();
        }

        private void btnDeterminanteB_Click(object sender, EventArgs e)
        {
            lblDetB.Text = MatricesMath.Determinante(matrizB).ToString();

        }

        private void btnTA_Click(object sender, EventArgs e)
        {
            componentes.ActualizarMatrizTabla(tlpResultado, MatricesMath.TranspuestaMatriz(matrizA), false);
            componentes.PonerTitulo(lblTMR, tlpResultado, "Transpuesta A");

        }

        private void btnIA_Click(object sender, EventArgs e)
        {
            componentes.ActualizarMatrizTabla(tlpResultado, MatricesMath.CalcularInversaMatriz(matrizA), false);
            componentes.PonerTitulo(lblTMR, tlpResultado, "Inversa A");

        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            componentes.ActualizarMatrizTabla(tlpInversaB, MatricesMath.TranspuestaMatriz(matrizB), false);
            componentes.PonerTitulo(lblTMI, tlpInversaB, "Transpuesta B");

        }

        private void btnIB_Click(object sender, EventArgs e)
        {
            componentes.ActualizarMatrizTabla(tlpInversaB, MatricesMath.CalcularInversaMatriz(matrizB), false);
            componentes.PonerTitulo(lblTMI, tlpInversaB, "Inversa B");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal=this.FindForm() as frmPrincipal;
            if (frmPrincipal != null) { frmPrincipal.irAlMenu(); }
        }
        //Metodos y funciones para uso comun
        public void ConfigurarTabla(string titulo, double[,] matriz, TableLayoutPanel tablePanel)
        {
            tablePanel.Controls.Clear();
            tablePanel.RowCount = matriz.GetLength(0) + 1;
            tablePanel.ColumnCount = matriz.GetLength(1);
            tablePanel.ColumnStyles.Clear();
            tablePanel.RowStyles.Clear();
            tablePanel.AutoSize = true;

            for (int i = 0; i < tablePanel.ColumnCount; i++)
            {
                tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30)); // Ancho columna
            }
            for (int j = 0; j < tablePanel.RowCount; j++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // Alto fila
            }

        }
        public void HabilitarBotones()
        {
            if (cmbFilasA.SelectedItem != null && cmbColumnasA.SelectedItem != null && cmbColumnasB.SelectedItem != null && cmbFilasB.SelectedItem != null)
            {
                int filasA = (int)FuncionesGenerales.IngresarEntero(cmbFilasA.SelectedItem.ToString());
                int columnasA = (int)FuncionesGenerales.IngresarEntero(cmbColumnasA.SelectedItem.ToString());
                int filasB = (int)FuncionesGenerales.IngresarEntero(cmbFilasB.SelectedItem.ToString());
                int columnasB = (int)FuncionesGenerales.IngresarEntero(cmbColumnasB.SelectedItem.ToString());

                //Evalua si tiene la misma NXM
                if (filasA == filasB && columnasB == columnasA)
                {
                    btnRestar.Enabled = true;
                    btnSumar.Enabled = true;
                }
                else
                {
                    btnSumar.Enabled = false;
                    btnRestar.Enabled = false;
                }
                //Evalua si se puede multiplicar
                if (columnasA == filasB || columnasA == 1 && filasA == 1 || filasB == 1 && columnasB == 1)
                {
                    btnMultiplicar.Enabled = true;
                }
                else
                {
                    btnMultiplicar.Enabled = false;
                }
                //Evalua si son cuadradas
                if (columnasA == filasA)
                {
                    btnDeterminanteA.Enabled = true;
                    btnIA.Enabled = true;
                }
                else
                {
                    btnDeterminanteA.Enabled = false;
                    btnIA.Enabled = false;

                }
                if (columnasB == filasB)
                {
                    btnDeterminanteB.Enabled = true;
                    btnIB.Enabled = true;
                }
                else
                {
                    btnDeterminanteB.Enabled = false;
                    btnIB.Enabled = false;

                }


            }


        }
        public void BorrarTable(TableLayoutPanel tplPanel)
        {
            tplPanel.Controls.Clear();
        }
        public void actualizarMatrizTabla(TableLayoutPanel tablePanel, ComboBox cmbFilas, ComboBox cmbColumnas, int matrizElegida)
        {
            if (cmbFilas.SelectedItem != null && cmbColumnas.SelectedItem != null)
            {
                borrarTabla2();
                BorrarTable(tlpResultado);
                int filas = (int)FuncionesGenerales.IngresarEntero(cmbFilas.SelectedItem.ToString());
                int columnas = (int)FuncionesGenerales.IngresarEntero(cmbColumnas.SelectedItem.ToString());
                if (matrizElegida == 0)
                {
                    matrizA = new double[filas, columnas];
                    MatricesMath.MatrizCeros(matrizA);
                }
                else
                {
                    matrizB = new double[filas, columnas];
                    MatricesMath.MatrizCeros(matrizB);
                }
                HabilitarBotones();
                componentes.ConfigurarTabla(tablePanel, filas, columnas, 30, 30);
                Label[,] labels = new Label[filas, columnas];

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        labels[i, j] = componentes.CrearLabel("0", 30, 30, Color.Black, Color.White);
                        if (matrizElegida == 0)
                        {

                            componentes.EventoLabelMatriz(labels[i, j], i, j, matrizA);
                        }
                        else
                        {
                            componentes.EventoLabelMatriz(labels[i, j], i, j, matrizB);

                        }

                    }
                }
                componentes.LlenarTabla(tablePanel, labels);

            }
        }


    }
}
