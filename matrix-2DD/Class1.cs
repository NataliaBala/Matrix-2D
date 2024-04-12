using System;

namespace MatrixLibrary
{
    public class Matrix2D
    {
        private readonly int a;
        private readonly int b;
        private readonly int c;
        private readonly int d;

        public int A => a;
        public int B => b;
        public int C => c;
        public int D => d;

        // Stałe Id i Zero
        public static readonly Matrix2D Id = new Matrix2D(1, 0, 0, 1);
        public static readonly Matrix2D Zero = new Matrix2D(0, 0, 0, 0);

        public Matrix2D(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public Matrix2D() : this(1, 0, 0, 1) { }

        // Przesłonięta metoda ToString()
        public override string ToString()
        {
            return $"[[{A}, {B}], [{C}, {D}]]";
        }

        // Implementacja interfejsu IEquatable<Matrix2D>
        public bool Equals(Matrix2D other)
        {
            if (other == null) return false;
            return A == other.A && B == other.B && C == other.C && D == other.D;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals((Matrix2D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + A.GetHashCode();
                hash = hash * 23 + B.GetHashCode();
                hash = hash * 23 + C.GetHashCode();
                hash = hash * 23 + D.GetHashCode();
                return hash;
            }
        }
        // Operator mnożenia macierzy
        public static Matrix2D operator *(Matrix2D matrix1, Matrix2D matrix2)
        {
            int a = matrix1.A * matrix2.A + matrix1.B * matrix2.C;
            int b = matrix1.A * matrix2.B + matrix1.B * matrix2.D;
            int c = matrix1.C * matrix2.A + matrix1.D * matrix2.C;
            int d = matrix1.C * matrix2.B + matrix1.D * matrix2.D;

            return new Matrix2D(a, b, c, d);
        }

        // Operator jawnego rzutowania obiektu Matrix2D na typ tablicy regularnej int[2,2]
        public static explicit operator int[,](Matrix2D matrix)
        {
            return new int[,] { { matrix.A, matrix.B }, { matrix.C, matrix.D } };
        }

        // Metoda parsująca string do obiektu Matrix2D
        public static Matrix2D Parse(string input)
        {
            try
            {
                if (!input.StartsWith("[[") || !input.EndsWith("]]"))
                    throw new FormatException("Invalid input format.");

                string[] rows = input.Substring(2, input.Length - 4).Split("], [");

                if (rows.Length != 2)
                    throw new FormatException("Invalid input format.");

                string[] row1 = rows[0].Split(", ");
                string[] row2 = rows[1].Split(", ");

                if (row1.Length != 2 || row2.Length != 2)
                    throw new FormatException("Invalid input format.");

                int a = int.Parse(row1[0]);
                int b = int.Parse(row1[1]);
                int c = int.Parse(row2[0]);
                int d = int.Parse(row2[1]);

                return new Matrix2D(a, b, c, d);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input format.");
            }
        }
    }
   // public static void Main(string[] args)
   // {

    //}
}


