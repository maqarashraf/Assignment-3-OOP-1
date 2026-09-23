using System;

namespace Project1
{
    class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public static bool operator ==(Point3D a, Point3D b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Point3D a, Point3D b) => !(a == b);

        public override bool Equals(object obj)
        {
            return obj is Point3D p && this == p;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public int CompareTo(object obj)
        {
            if (obj is null) return 1;
            if (!(obj is Point3D other))
                throw new ArgumentException("Object is not a Point3D");

            int result = X.CompareTo(other.X);
            if (result == 0)
                result = Y.CompareTo(other.Y);
            return result;
        }

        
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}