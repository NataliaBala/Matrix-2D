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

        public override string ToString()
        {
            return $"[[{A}, {B}], [{C}, {D}]]";
        }  // Implementacja interfejsu IEquatable<Matrix2D>
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
        // Przeciążenie operatorów + i -
        public static Matrix2D operator +(Matrix2D a, Matrix2D b)
        {
            return new Matrix2D(a.A + b.A, a.B + b.B, a.C + b.C, a.D + b.D);
        }

        public static Matrix2D operator -(Matrix2D a, Matrix2D b)
        {
            return new Matrix2D(a.A - b.A, a.B - b.B, a.C - b.C, a.D - b.D);
        }

        // Przeciążenie operatora *
        public static Matrix2D operator *(Matrix2D a, Matrix2D b)
        {
            return new Matrix2D(a.A * b.A + a.B * b.C, a.A * b.B + a.B * b.D, a.C * b.A + a.D * b.C, a.C * b.B + a.D * b.D);
        }

        // Przeciążenie operatora * dla mnożenia przez skalar
        public static Matrix2D operator *(int k, Matrix2D m)
        {
            return new Matrix2D(k * m.A, k * m.B, k * m.C, k * m.D);
        }

        public static Matrix2D operator *(Matrix2D m, int k)
        {
            return k * m;
        }

        // Przeciążenie jednoargumentowego operatora -
        public static Matrix2D operator -(Matrix2D m)
        {
            return new Matrix2D(-m.A, -m.B, -m.C, -m.D);
        }
        public Matrix2D(int value) : this(value, value, value, value) { }
        public static void Main(string[] args)
        {
            
        }
    }
}
