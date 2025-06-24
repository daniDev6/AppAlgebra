using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatricesForm
{
    internal class Componentes
    {
        public Label CrearLabel(string valor,int width,int heigth,Color foreColor,Color backColor) {
            Label label = new Label();
            label.Text = valor;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.Size = new Size(width, heigth);

            label.ForeColor = foreColor;
            label.BackColor = backColor;
            label.Margin = new Padding(0);
            label.Padding = new Padding(0);
            label.TextAlign=ContentAlignment.MiddleCenter;
            return label;
        }
        public void ConfigurarTabla(TableLayoutPanel tablePanel, int filas, int columnas, int withCelda, int heigthCelda)
        {
            tablePanel.Controls.Clear();
            tablePanel.RowCount = filas;
            tablePanel.ColumnCount = columnas;
            tablePanel.ColumnStyles.Clear();
            tablePanel.RowStyles.Clear();
            tablePanel.AutoSize = true;
            
            for (int i = 0; i < tablePanel.ColumnCount; i++)
            {
                tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, withCelda)); // Ancho columna
            }
            for (int j = 0; j < tablePanel.RowCount; j++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, heigthCelda)); // Alto fila
            }
        }
        //Agregar evento de relleno a un label
        public void LlenarTabla(TableLayoutPanel tablePanel, Label[,] labels) {

            for (int i = 0; i < labels.GetLength(0); i++) {
                for (int j = 0; j < labels.GetLength(1); j++) {
                    tablePanel.Controls.Add(labels[i,j], j , i ); // Columna, Fila
                }
            }
            tablePanel.Size = new Size(labels.GetLength(1) * 30, labels.GetLength(0) * 30);


        }
        public void PonerTitulo(Label tituloLabel,TableLayoutPanel tablePanel, string titulo) { 
            tituloLabel.Width= tablePanel.Width;
            tituloLabel.Height= 40;
            tituloLabel.Text= titulo;
        }
        public void EventoLabelMatriz (Label label,int fila,int columna, double[,] matriz) {
                label.Tag = new Point(fila, columna);  // Usamos Point o una tupla personalizada
                label.Click += (sender, e) =>
                {
                    if (sender is Label clickedLabel && clickedLabel.Tag is Point punto)
                    {
                        int filaV = punto.X;
                        int columnaV = punto.Y;
                        frmIngresarDatos ventanaIngresar = new frmIngresarDatos(matriz[fila, columna]);
                        ventanaIngresar.ShowDialog();
                        double? numeroNuevo = ventanaIngresar.nuevoValor;
                        if (numeroNuevo != null)
                        {
                            matriz[fila, columna] = (double)numeroNuevo;  // Aquí actualizamos la matriz
                        }
                        clickedLabel.Text = numeroNuevo.ToString();

                    }
                };
            }

        public void EventoLabelMatriz(Label label, int fila, int columna, string[,] matriz)
        {
            label.Tag = new Point(fila, columna);  // Usamos Point o una tupla personalizada
            label.Click += (sender, e) =>
            {
                if (sender is Label clickedLabel && clickedLabel.Tag is Point punto)
                {
                    int filaV = punto.X;
                    int columnaV = punto.Y;
                    string nuevoValor = Interaction.InputBox(
                        "Ingrese el nuevo valor:",
                        "Editar valor",
                        clickedLabel.Text);

                    if (!string.IsNullOrWhiteSpace(nuevoValor) && double.TryParse(nuevoValor, out double numero))
                    {
                        clickedLabel.Text = nuevoValor;
                        matriz[filaV, columnaV] = numero.ToString();  // Aquí actualizamos la matriz
                    }
                    else
                    {
                        MessageBox.Show("Valor no válido. Debe ser un número.");
                    }
                }
            };
        }



        public void ActualizarMatrizTabla(TableLayoutPanel tablePanel, double[,] matriz, bool conEvento)
        {
            if (matriz == null) return;

            ConfigurarTabla(tablePanel, matriz.GetLength(0), matriz.GetLength(1), 30, 30);
            Label[,] labels = new Label[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    labels[i, j] = CrearLabel(matriz[i, j].ToString(), 30, 30, Color.Black, Color.White);
                    if (conEvento)
                    {
                        EventoLabelMatriz(labels[i, j], i, j, matriz);

                    }
                }
            }
            LlenarTabla(tablePanel, labels);
            
        }
        public void ActualizarMatrizTabla(TableLayoutPanel tablePanel, string[,] matriz, bool conEvento)
        {
            if (matriz == null) return;
            ConfigurarTabla(tablePanel, matriz.GetLength(0), matriz.GetLength(1), 30, 30);
            Label[,] labels = new Label[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    labels[i, j] =CrearLabel(matriz[i, j].ToString(), 30, 30, Color.Black, Color.White);
                    if (conEvento)
                    {
                        EventoLabelMatriz(labels[i, j], i, j, matriz);

                    }
                }
            }
            LlenarTabla(tablePanel, labels);
            
        }





    }
      





    }
