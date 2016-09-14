using System;

namespace MathLib
{
	/// <summary>
	/// Summary description for Geometry.
	/// </summary>
	public class Geometry
	{
		public Geometry()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static double AreaCircle(double pfRadius)
		{
			return Math.PI * pfRadius * pfRadius;
		}

		public static double AreaSquare(double pfSide)
		{
			return pfSide * pfSide;
		}

		public static double AreaRectangle(double pfHeight, double pfWidth)
		{
			return pfWidth * pfWidth;
		}

		public static double AreaCircleSegment(double pfRadius, double pfDeg)
		{
			return pfRadius * pfRadius * Trig.DegToRad(pfDeg) / 2.0;
		}

		public static double AreaTriangle(double pfSide1, double pfSide2, double pfInnerAngleDeg)
		{
			return 0.5 * pfSide1 * pfSide2 * Trig.Sin(pfInnerAngleDeg);
		}

		public static double VolumeCube(double pfSide)
		{
			return pfSide * pfSide * pfSide;
		}

		public static double VolumeCylinder(double pfRadius, double pfHeight)
		{
			return Math.PI * pfRadius * pfRadius * pfHeight;
		}

		public static double VolumeSphere(double pfRadius)
		{
			return Math.PI * pfRadius * pfRadius * pfRadius * 4.0 / 3.0;
		}

		public static double VolumeRectBlock(double pfWidth, double pfHeight, double pfDepth)
		{
			return pfWidth * pfHeight * pfDepth;
		}

		public static double VolumeCone(double pfRadius, double pfHeight)
		{
			return Math.PI * pfRadius * pfRadius * pfHeight / 3.0;
		}

		public static double PerimeterSquare(double pfSide)
		{
			return 4.0 * pfSide;
		}

		public static double PerimeterRectangle(double pfWidth, double pfHeight)
		{
			return (2.0 * pfWidth) + (2.0 * pfWidth);
		}

		public static double CircumferenceCircle(double pfRadius)
		{
			return pfRadius * 2.0 * Math.PI;
		}

		public static double SurfaceAreaCube(double pfSide)
		{
			return 6.0 * pfSide * pfSide;
		}

		public static double SurfaceAreaSphere(double pfRadius)
		{
			return Math.PI * pfRadius * pfRadius * pfRadius * 4.0;
		}

		public static double SurfaceAreaRectBlock(double pfWidth, double pfHeight, double pfDepth)
		{
			return (2.0 * pfWidth * pfHeight) + (2.0 * pfWidth * pfDepth) + (2.0 * pfHeight * pfDepth);
		}



	}
}
