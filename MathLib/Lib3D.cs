using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public static class Lib3D
    {
        public static Pnt Map3dTo2dCart(Point3D p3d)
        {
            Pnt p2d = new Pnt();
	        double dZScale = (0.707 - p3d.Z) / 0.707;
	        p2d.X = p3d.X + (0.707 * p3d.Z * dZScale);
	        p2d.Y = p3d.Y + (0.707 * p3d.Z * dZScale);
            return p2d;
        }


        public static Pnt Map3dTo2d(double dDepth, Point3D p3d)
        {
            double dPersScale = (dDepth - p3d.Z) / dDepth;
            Pnt p2d = new Pnt();

            p2d.X = p3d.X * dPersScale;
            p2d.Y = p3d.Y * dPersScale;
            return p2d;
        }

        public static Point3D Map3dPerspective(double ScreenZ, Point3D p3d)
        {
            double dX, dY, dZ;
            dX = p3d.X * ScreenZ / p3d.Z;
            dY = p3d.Y * ScreenZ / p3d.Z;
            dZ = p3d.Z;
            return new Point3D(dX, dY, dZ);
        }
        public static Point3D[] Map3dPerspectiveArray(double ScreenZ, Point3D[] p3d)
        {
            Point3D[] p = new Point3D[p3d.GetLength(0)];

            for (int i = 0; i < p3d.GetLength(0); i++)
            {
                p[i] = Map3dPerspective(ScreenZ, p3d[i]);
            }
            return p;
        }
        public static Pnt[] Map3dTo2dArray(double ScreenZ, Point3D[] p3d)
        {
            Pnt[] p2d = new Pnt[p3d.GetLength(0)];
          
            for (int i = 0; i < p3d.GetLength(0); i++)
            {
                p2d[i] = Map3dTo2d(ScreenZ, p3d[i]);
            }
            return p2d;
        }

        public static void RotatePoint(ref double p1, ref double p2, ref double p3, double angle)
        {
            double new2 = (p2 * Math.Cos(angle)) - (p3 * Math.Sin(angle));
            double new3 = (p2 * Math.Sin(angle)) + (p3 * Math.Cos(angle));
            p2 = new2;
            p3 = new3;
        }


    }
}
