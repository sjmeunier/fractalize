using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Point3D
    {
        public double X;
        public double Y;
        public double Z;

        public Point3D()
        {
        }

        public Point3D(double dX, double dY, double dZ)
        {
            X = dX;
            Y = dY;
            Z = dZ;
        }

        public static double Abs(Point3D p1)
        {
            return Math.Sqrt((p1.X * p1.X) + (p1.Y * p1.Y) + (p1.Z * p1.Z));
        }

        public static Point3D Add(Point3D p1, Point3D p2)
        {
            double dX, dY, dZ;
            dX = p1.X + p2.X;
            dY = p1.Y + p2.Y;
            dZ = p1.Z + p2.Z;
            return new Point3D(dX, dY, dZ);
        }

        public static Point3D Subtract(Point3D p1, Point3D p2)
        {
            double dX, dY, dZ;
            dX = p1.X - p2.X;
            dY = p1.Y - p2.Y;
            dZ = p1.Z - p2.Z;
            return new Point3D(dX, dY, dZ);
        }

        public static Point3D Normalise(Point3D p1)
        {
            double dX, dY, dZ;
            double dAbs = Point3D.Abs(p1);
            dX = p1.X / dAbs;
            dY = p1.Y / dAbs;
            dZ = p1.Z / dAbs;
            return new Point3D(dX, dY, dZ);
        }

        public static double DotProduct(Point3D p1, Point3D p2)
        {
            double dDot = p1.X * p2.X + p1.Y * p2.Y +  p1.Z * p2.Z;
            if (dDot > 1)
            {
                dDot = 1;
            }
            if (dDot < 0)
            {
                dDot = 0;
            }
            return dDot;
        }

        public static Point3D CrossProduct(Point3D p1, Point3D p2)
        {
            double dX, dY, dZ;
            dX = p1.Y * p2.Z - p1.Z * p2.Y;
            dY = p1.Z * p2.X - p1.X * p2.Z;
            dZ = p1.X * p2.Y - p1.Y * p2.X;

            return new Point3D(dX, dY, dZ);
        }

        public static Point3D Scale(Point3D p, double dScale)
        {
            return new Point3D(p.X * dScale, p.Y * dScale, p.Z * dScale);
        }

        public static double GetAngleBetween(Point3D p1, Point3D p2)
        {
            double dAngle = Math.Acos(DotProduct(p1, p2));
            return dAngle;
        }
    }
}
