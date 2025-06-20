using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatricesForm
{
    internal static class EcuacionesLineales
    {
        public static Resultado GaussJordan(double[,] matriz) { 
            MatricesMath.Gauss(matriz);
            Resultado result=AnalizadorMatrizGauss(matriz);
            return result;
        }
        private static Resultado AnalizadorMatrizGauss(double[,] matriz) {
         
            Resultado resultado =new Resultado(matriz.GetLength(0));
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1)-1; j++) {

                    if (matriz[i, j] == 1)
                    {
                        if (matriz[i, j] != 0 && matriz[i,matriz.GetLength(1)-1]!=0 || matriz[i, j] != 0 && matriz[i, matriz.GetLength(1) - 1] == 0)
                        {
                            resultado.Result[i] = matriz[i, matriz.GetLength(1) - 1].ToString();
                            resultado.Sistema = "Sistema Compatible Determinado";

                        }
                        else if (matriz[i, j] == 0 && matriz[i, matriz.GetLength(1) - 1] != 0)
                        {
                            resultado.Result[i] = "NO HAY SOLUCION POSIBLE";
                            resultado.Sistema = "Sistema Indeterminado";
                        }
                        else if (matriz[i, j] == 0 && matriz[i, matriz.GetLength(1) - 1] == 0)
                        {
                            resultado.Result[i] = "SOLUCIONES INFINITAS";

                            resultado.Sistema = "Sistema Compatible Indeterminado";
                        }
                        break;
                    }
                    
                }
                
            }
            return resultado;

        }
        public static bool ConSolucion(Resultado resultado) {
            
            for (int i = 0; i < resultado.Result.Length; i++) {
                if (resultado.Result[i]==null ||resultado.Result[i].ToUpper() == "NO HAY SOLUCION POSIBLE") { 
                return false;
                }
            }
            return true;
        }
        public static bool ConSolucionFinita(Resultado resultado) {
            if (ConSolucion(resultado))
            {
                for (int i = 0; i < resultado.Result.Length; i++)
                {
                    if (resultado.Result[i].ToUpper() == "SOLUCIONES INFINITAS")
                    {
                        return false;
                    }
                }

                return true;

            }
            else { 
                return false;
            }
           
        }



    }
    class Resultado { 
        public string[] Result { get; set; }
        public string Sistema { get; set; }
        public Resultado(int cantIncognitas) { 
            Result = new string[cantIncognitas];
        }
    }
}
