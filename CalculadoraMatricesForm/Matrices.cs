using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculadoraMatricesForm
{
    internal static class MatricesMath
    {
        // Adiccion, Resta, Multiplicacion
        public static double[,] SumarMatrices(double[,] matrizA, double[,] matrizB) {
            if (matrizA.GetLength(0) == matrizB.GetLength(0) && matrizB.GetLength(1) == matrizA.GetLength(1))
            {
                double[,] result = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
                for (int i = 0; i < matrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizA.GetLength(1); j++)
                    {
                        result[i, j] = matrizA[i, j] + matrizB[i, j];
                    }
                }
                return result;
            }
            else {
                FuncionesGenerales.MostrarMensaje("No son compatibles las matrices", 3);
                return null;
            }
        }
        public static double[,] RestaMatrices(double[,] matrizA, double[,] matrizB) {
            if (matrizA.GetLength(0) == matrizB.GetLength(0) && matrizB.GetLength(1) == matrizA.GetLength(1))
            {
                double[,] result = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
                for (int i = 0; i < matrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizA.GetLength(1); j++)
                    {
                        result[i, j] = matrizA[i, j] - matrizB[i, j];
                    }
                }
                return result;
            }
            else {
                FuncionesGenerales.MostrarMensaje("No son compatibles las matrices", 3);
                return null;
            }
        }

        public static double[,] MultiplicacionMatrices(double[,] matrizA, double escalar) {
            double[,] result = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            for (int i = 0; i < matrizA.GetLength(0); i++) {
                for (int j = 0; j < matrizA.GetLength(1); j++) {
                    result[i, j] = matrizA[i, j] * escalar;
                }
            }
            return result;
        }
        public static double[,] MultiplicacionMatrices(double[,] matrizA, double[,] matrizB)
        {
            if (matrizA.GetLength(1) != matrizB.GetLength(0)) return null;
            double[,] result = new double[matrizA.GetLength(0), matrizB.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++) {
                for (int j = 0; j < result.GetLength(1); j++) {
                    result[i, j] = MultiplicacionVectores(VectorFila(matrizA, i), VectorColumna(matrizB, j));
                }
            }
            return result;
        }
        public static double MultiplicacionVectores(double[] vectorA, double[] vectorB) {
            double result = 0;
            for (int i = 0; i < vectorA.Length; i++) {
                result += vectorA[i] * vectorB[i];
            }
            return result;
        }
        //Funciones auxiliares
        private static double[] VectorFila(double[,] matriz, int fila)
        {
            double[] vectorFila = new double[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++) {
                vectorFila[i] = matriz[fila, i];
            }
            return vectorFila;
        }
        private static double[] VectorColumna(double[,] matriz, int columna)
        {
            double[] vectorColumna = new double[matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++) {
                vectorColumna[i] = matriz[i, columna];
            }
            return vectorColumna;
        }
        //Transpuesta
        public static double[,] TranspuestaMatriz(double[,] matriz)
        {
            double[,] transpuesta = new double[matriz.GetLength(1), matriz.GetLength(0)];
            for (int i = 0; i < transpuesta.GetLength(0); i++) {
                for (int j = 0; j < transpuesta.GetLength(1); j++) {
                    transpuesta[i, j] = matriz[j, i];
                }
            }
            return transpuesta;

        }
        //Determinante
        public static double? Determinante(double[,] matriz) {
            if (matriz.GetLength(0) != matriz.GetLength(1)) { FuncionesGenerales.MostrarMensaje("Debe ser una matriz Cuadrada", 1); return null; }
            if (matriz.GetLength(0) == 2)
            {
                return matriz[0, 0] * matriz[1, 1] - matriz[1, 0] * matriz[0, 1];
            }
            else if (matriz.GetLength(0) == 3)
            {
                return DeterminanteSarrus(matriz);
            }
            else if (matriz.GetLength(0) == 1)
            {
                return matriz[0, 0];
            }
            else  {
                
                return DeterminanteDeOrdenSuperiorA3(matriz);
            }



        }
        //Metodo de Sarrus
        private static double SumaDiagonal(double[,] matriz) {
            //Solo valido para matrices 3X5
            double suma = 0;

            for (int i = 0; i < 3; i++) {

                suma += matriz[0, i] * matriz[1, i + 1] * matriz[2, i + 2];


            }
            return suma;
        }
        private static double RestaDiagonal(double[,] matriz) {
            //Solo valido para matrices 3X5
            double suma = 0;
            for (int i = 0; i < 3; i++) {
                suma += matriz[2, i] * matriz[1, i + 1] * matriz[0, i + 2];

            }
            return suma;
        }
        private static double? DeterminanteSarrus(double[,] matriz) {
            //si o si matriz de 3X3
            if (matriz.GetLength(0) != matriz.GetLength(1) || matriz.GetLength(0) != 3) return null;
            double[,] matrizSarrus = new double[matriz.GetLength(0), 5];
            int fila = 0;
            int columna = 0;
            for (int i = 0; i < matrizSarrus.GetLength(0); i++) {
                for (int j = 0; j < matrizSarrus.GetLength(1); j++) {
                    if (j >= 3)
                    {
                        matrizSarrus[i, j] = matriz[i, columna];
                        columna++;
                    }
                    else {
                        matrizSarrus[i, j] = matriz[i, j];
                    }
                }
                columna = 0;
            }
          
            return SumaDiagonal(matrizSarrus) - RestaDiagonal(matrizSarrus);








        }

        //Mostrar matrices/vectores en depuracion
        public static string MostrarMatrizAlUsuario(double[,] matriz) {
            if(matriz==null) return null;
            String mensaje = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    mensaje += matriz[i, j].ToString() + " ";
                }
                mensaje += "\n";
            }
            return mensaje;
        }
        public static string MostrarMatrizAlUsuario(string[,] matriz)
        {
            if (matriz == null) return null;
            String mensaje = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    mensaje += matriz[i, j] + " ";
                }
                mensaje += "\n";
            }
            return mensaje;
        }

        public static string MostrarVectorAlUsuario(double[] vector)
        {

            String mensaje = "";
            for (int i = 0; i < vector.Length; i++)
            {
                mensaje += vector[i].ToString() + " ";
                mensaje += "\n";
            }
            return mensaje;
        }
        public static string MostrarVectorAlUsuario(string[] vector)
        {

            String mensaje = "";
            for (int i = 0; i < vector.Length; i++)
            {
                mensaje += "X" + i + vector[i] + " ";
                mensaje += "\n";
            }
            return mensaje;
        }
        public static void MatrizCeros(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    

                        matriz[i, j] = 0;



                }
            }
        }
        //Metodo de Gauss
        public static void Gauss(double[,] matriz) {
            int aplicamosGauss = 0;
            bool hayCambio = false;
            int filaCambio = 0;
            while (aplicamosGauss < matriz.GetLength(0) && PuedoAplicarGaussEnFila(matriz, aplicamosGauss))
            {
                MatrizGaussiana(matriz, aplicamosGauss, aplicamosGauss);
                aplicamosGauss++;
                if (aplicamosGauss < matriz.GetLength(0))
                {
                    if (matriz[aplicamosGauss, aplicamosGauss] == 0)
                    {
                        hayCambio = true;
                    }
                    else
                    {
                        hayCambio = false;
                    }
                    if (hayCambio)
                    {
                        for (int i = aplicamosGauss; i < matriz.GetLength(0); i++)
                        {
                            if (matriz[i, aplicamosGauss] != 0)
                            {
                                filaCambio = i;
                                break;
                            }
                        }
                        IntercambiarFilas(matriz, filaCambio, aplicamosGauss);
                    }
                }
            }
        }
        //Auxiliares para gauss
        private static void MatrizGaussiana(double[,] matriz, int filaPivote, int columnaPivote)
        {
            double divisor = matriz[filaPivote, columnaPivote];
            if (divisor == 0) return;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                matriz[filaPivote, i] = matriz[filaPivote, i] / divisor;
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                double multiplicador = -matriz[i, columnaPivote];
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i != filaPivote)
                    {

                        matriz[i, j] = multiplicador * matriz[filaPivote, j] + matriz[i, j];
                    }
                }
            }


        }
 
        private static void IntercambiarFilas(double[,] matriz, int valoresFilaA, int valoresFilaB)
        {
            double auxiliar = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                auxiliar = matriz[valoresFilaA, i];
                matriz[valoresFilaA, i] = matriz[valoresFilaB, i];
                matriz[valoresFilaB, i] = auxiliar;
            }
            ;
        }
        private static bool PuedoAplicarGaussEnFila(double[,] matriz, int fila)
        {
            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                if (matriz[fila, i] != 0)
                {
                    return true;
                }
            }
            return false;
        }
        private static bool FilasCeros(double[,] matriz, int filas)
        {
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                if (matriz[filas, i] != 0)
                {
                    return false;
                }
            }
            return true;

        }
        //Rango
        public static int Rango(double[,] matriz)
        {
            Gauss(matriz);
            int rango = 0;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                if (!FilasCeros(matriz, i)) {
                    rango++;
                }
            }
            return rango;
        }
        //Saber si son Linealmente independientes

        public static bool ColumnaslinealmenteIndependiente(double[,] matriz) {
            if (Rango(matriz) == matriz.GetLength(1))
            {
                return true;
            }
            return false;

        }
        public static bool FilaslinealmenteIndependiente(double[,] matriz)
        {
            if (Rango(matriz) == matriz.GetLength(0))
            {
                return true;
            }
            return false;

        }
        //Calculo de la inversa de una matriz
        public static double[,] CalcularInversaMatriz(double[,] matriz) {
            if (!TieneInversa(matriz)) { FuncionesGenerales.MostrarMensaje("No tiene inversa", 3); return null; }
            double[,] matrizConInvers= MatrizConInversa(matriz);
            Gauss(matrizConInvers);
            return SepararInversa(matrizConInvers);
        }
        //Auxiliares para calcular la inversa
        private static double[,] SepararInversa(double[,] matrizInversaCalculada)
        {
            double[,] inversa = new double[matrizInversaCalculada.GetLength(0), matrizInversaCalculada.GetLength(1) / 2];
            int inicio = inversa.GetLength(1);
            for (int i = 0; i < inversa.GetLength(0); i++) {
                for (int j = 0; j < inversa.GetLength(1); j++) { 
                    inversa[i,j]=matrizInversaCalculada[i,inicio];
                    inicio++;
                }
                inicio = inversa.GetLength(1);
            }
            return inversa;
        }
        private static double[,] CopiaMatriz(double[,] matriz) {
            double[,] copiaMatri = new double[matriz.GetLength(0), matriz.GetLength(1)]; 
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) { 
                    copiaMatri[i, j]=matriz[i,j];
                }
            }
            return copiaMatri;
        }
        private static double[,] MatrizConInversa(double[,] matriz) {
            double[,] matrizCompleta=new double[matriz.GetLength(0),matriz.GetLength(1)*2];
            double[,] matrizIdentidadM=MatrizIdentidad(matriz.GetLength(0),matriz.GetLength(1));
            int cantidad = 0;
            for (int i = 0; i < matrizCompleta.GetLength(0); i++) {
                for (int j = 0; j < matrizCompleta.GetLength(1); j++) {
                    if (j < matriz.GetLength(1))
                    {
                        matrizCompleta[i, j] = matriz[i, j];
                    }
                    else {
                        if (cantidad < matriz.GetLength(1))
                        {
                            matrizCompleta[i, j] = matrizIdentidadM[i, cantidad];
                            cantidad++;
                        }
                        
                    }

                        
                    }
                cantidad = 0;
                }
            return matrizCompleta;    
        }
        //Matriz identidad
        public static double[,] MatrizIdentidad(int filas, int columnas)
        {
            double[,] matrizIdentidad= new double[filas, columnas];
            for (int i = 0; i < filas; i++) {
                for (int j = 0; j < columnas; j++) {
                    if (i == j)
                    {
                        matrizIdentidad[i, j] = 1;
                    }
                    else {
                        matrizIdentidad[i, j] = 0;
                    }
                }
            }
            return matrizIdentidad;
        }
        public static bool TieneInversa(double[,] matriz) {

            if (Determinante(matriz) == 0 ||!EsCuadrada(matriz)) {
                return false;
            }
            return true;
        }
        public static bool EsCuadrada(double[,] matriz) {
            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                return false;
            }
            return true;

        }
        //Triangular superior el triangulo de abajo ceros
        private static void CalculoTriangularSuperior(double[,] matriz,int filaPivote,int columnaPivote) {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[filaPivote, columnaPivote] != 0) { 
                
                double multiplicador = -(matriz[i,columnaPivote] /matriz[filaPivote, columnaPivote]);

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i > filaPivote)
                    {
                        matriz[i, j] = multiplicador * matriz[filaPivote, j] + matriz[i, j];
                    }
                }
                }

            }
        }
        //Determinate de cualquier matriz
        private static double DeterminanteDeOrdenSuperiorA3(double[,] matriz) {
            TriangularSuperior(matriz);
            double suma = 1;
            
            for (int i = 0; i < matriz.GetLength(0); i++) {
                suma *= matriz[i, i];    
            }
            return suma;
        }
        private static void TriangularSuperior(double[,] matriz) {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                CalculoTriangularSuperior(matriz, i, i);
            }
        }


        //Triangular inferior el triangulo de arriba ceros Pensada a futuro
      
        private static void TriangularInferior(double[,] matriz)
        {
            double[,] matrizTranspuesta=TranspuestaMatriz(matriz);

            for (int i = 0; i <matriz.GetLength(0); i++)
            {
                CalculoTriangularSuperior(matrizTranspuesta, i, i);
            }

        }
    }
}
