using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatricesForm
{
    internal static class FuncionesGenerales
    {
        public static int? IngresarEntero(string texto)
        { 
           if(int.TryParse(texto, out int num)) { return num; }else { MostrarMensaje("Debe ingresar un entero",3); return null; }   
        }
        public static double? IngresarDouble(string texto)
        { 
           if(double.TryParse(texto, out double num)) { return num; }else { MostrarMensaje("Debe ingresar un numero Decimal",3); return null; }   
        }
        /// <summary>
        /// Muestra un mensaje al usuario con un icono según el tipo indicado.
        /// <list type="">
        /// 1 = Error,
        /// 2 = Información,
        /// 3 = Advertencia.
        /// </list>
        /// </summary>
        /// <param name="msj"></param>
        /// <param name="tipo"></param>
        public static void MostrarMensaje(string msj, int tipo) {
           
            MessageBoxIcon messageBoxIcon=MessageBoxIcon.Exclamation;
            string titulo;
            switch (tipo) {
                case 1:titulo = "ERROR";messageBoxIcon = MessageBoxIcon.Error; break;
                case 2:titulo = "Information";messageBoxIcon = MessageBoxIcon.Information; break;
                case 3:titulo = "Warning"; messageBoxIcon = MessageBoxIcon.Warning; break;
                default:titulo = "Error Default"; messageBoxIcon = MessageBoxIcon.Error; break;
            }
            MessageBox.Show(msj,titulo, MessageBoxButtons.OK,messageBoxIcon);
        }

       

    }
}
