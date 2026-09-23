namespace Assignment_3_OOP
{
    using global::Project1;
    using System;

    namespace Project1
    {
        class Program
        {
            static int ReadInt(string message)
            {
                int value;
                Console.Write(message);
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Invalid input, please enter an integer: ");
                }
                return value;
            }

            static Point3D ReadPoint(string name)
            {
                Console.WriteLine($"Enter coordinates of {name}:");
                int x = ReadInt("X = ");
                int y = ReadInt("Y = ");
                int z = ReadInt("Z = ");
                return new Point3D(x, y, z);
            }

            static void Main(string[] args)
            {
                Point3D P = new Point3D(10, 10, 10);
                Console.WriteLine(P.ToString());
                Point3D P1 = ReadPoint("P1");
                Point3D P2 = ReadPoint("P2");
                Console.WriteLine(P1);
                Console.WriteLine(P2);
                if (P1 == P2)
                    Console.WriteLine("P1 == P2 (same coordinates)");
                else
                    Console.WriteLine("P1 != P2");
                Console.WriteLine("Same reference? " + ((object)P1 == (object)P2));
                Point3D[] points =
                {
                new Point3D(5, 2, 1),
                new Point3D(1, 9, 3),
                new Point3D(5, 1, 7),
                new Point3D(3, 3, 3),
                new Point3D(1, 2, 0)
            };

                Array.Sort(points);
                Console.WriteLine("\nSorted points:");
                foreach (Point3D p in points)
                    Console.WriteLine(p);

                // Clone
                Point3D copy = (Point3D)P1.Clone();
                Console.WriteLine("\nClone: " + copy);
                Console.WriteLine("Same reference as P1? " + ReferenceEquals(P1, copy));
                Console.WriteLine("Equal to P1? " + (P1 == copy));
            }
        }
    }
}
