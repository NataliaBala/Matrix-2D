using MatrixConsoleApp;
using System;
// Tworzenie macierzy za pomocą konstruktora z parametrami
Console.WriteLine("Creating matrix with parameters:");
Matrix2D matrix1 = new(1, 2, 3, 4);
Console.WriteLine(matrix1.ToString());

// Tworzenie macierzy identycznościowej za pomocą konstruktora domyślnego
Console.WriteLine("\nCreating identity matrix:");
Matrix2D identityMatrix = Matrix2D.Id;
Console.WriteLine(identityMatrix.ToString());


// Zmiana znaku macierzy
Console.WriteLine("\nChanging sign of matrix:");
Matrix2D negativeMatrix = matrix1;
Console.WriteLine($"Negative of Matrix1:");
Console.WriteLine(negativeMatrix.ToString());

// Transpozycja macierzy
Console.WriteLine("\nTransposing matrix:");
Matrix2D transposedMatrix = matrix1.Transpose();
Console.WriteLine($"Transposed Matrix1:");
Console.WriteLine(transposedMatrix.ToString());

// Obliczanie wyznacznika macierzy
Console.WriteLine("\nCalculating determinant:");
int determinant = matrix1.Det();
Console.WriteLine($"Determinant of Matrix1: {determinant}");

// Rzutowanie macierzy na tablicę
Console.WriteLine("\nCasting matrix to array:");
int[,] arrayMatrix = matrix1.ToArray();
Console.WriteLine($"Array representation of Matrix1:");
for (int i = 0; i < arrayMatrix.GetLength(0); i++)
{
    for (int j = 0; j < arrayMatrix.GetLength(1); j++)
    {
        Console.Write(arrayMatrix[i, j] + " ");
    }
    Console.WriteLine();
}

// Parsowanie ciągu znaków na macierz
Console.WriteLine("\nParsing string to matrix:");
string matrixString = "[[1, 2], [3, 4]]";
Matrix2D parsedMatrix = Matrix2D.Parse(matrixString);
Console.WriteLine($"Parsed matrix from string '{matrixString}':");
Console.WriteLine(parsedMatrix.ToString());

Console.ReadLine();


namespace MatrixConsoleApp
{
    internal class Matrix2D
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;

        public Matrix2D(int v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public static Matrix2D Id { get; internal set; }

        internal static Matrix2D Parse(string matrixString)
        {
            throw new NotImplementedException();
        }

        internal int Det()
        {
            throw new NotImplementedException();
        }

        internal int[,] ToArray()
        {
            throw new NotImplementedException();
        }

        internal Matrix2D Transpose()
        {
            throw new NotImplementedException();
        }
    }
}
