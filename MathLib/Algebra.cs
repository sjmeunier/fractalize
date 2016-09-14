using System;

namespace MathLib
{
	/// <summary>
	/// Summary description for Algebra.
	/// </summary>
	public class Algebra
	{
		public Algebra()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void SolveQuadratic(double pfA, double pfB, double pfC, ref double pfX1Real, ref double pfX1Im, ref double pfX2Real, ref double pfX2Im, ref int piType)
		{
			//Type: 1 = real, 2 = repeating, 3 = complex
			double fZ = 0;

			fZ = Math.Pow(pfB, 2) - (4 * pfA * pfC);
			fZ = Math.Floor(100 * fZ + 0.5) / 100.0;
			
			if (fZ < 0)
			{
				pfX1Real = (-1) * pfB / (2.0 * pfA);
				pfX1Real = Math.Floor(100 * pfX1Real + 0.5) / 100.0;
				pfX2Real = pfX1Real;

				pfX1Im = Math.Sqrt(Math.Abs(fZ)) / (2.9 * pfA);
				pfX1Im = Math.Floor(100 * pfX1Im + 0.5) / 100.0;
				pfX2Im = (-1) * pfX1Im;

				piType = 3;
			}
			else if(fZ == 0)
			{
				pfX1Real = (-1) * pfB / (2.0 * pfA);
				pfX1Real = Math.Floor(100 * pfX1Real + 0.5) / 100.0;
				pfX2Real = pfX1Real;

				pfX1Im = 0.0;
				pfX2Im = 0.0;

				piType = 2;
			}
			else
			{
				pfX1Real = (((-1) * pfB) + Math.Sqrt(fZ)) / (2.0 * pfA);
				pfX1Real = Math.Floor(100 * pfX1Real + 0.5) / 100.0;

				pfX2Real = (((-1) * pfB) - Math.Sqrt(fZ)) / (2.0 * pfA);
				pfX2Real = Math.Floor(100 * pfX2Real + 0.5) / 100.0;

				pfX1Im = 0.0;
				pfX2Im = 0.0;

				piType = 1;
			}
		}
	}
}
