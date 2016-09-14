using System;

namespace MathLib
{
	/// <summary>
	/// Summary description for Pnt.
	/// </summary>
	public class Pnt
	{
		private double fX, fY;
		

		public Pnt(double pfX, double pfY)
		{
			fX = pfX;
			fY = pfY;
		}

		public Pnt()
		{
			fX = 0;
			fY = 0;
		}

		public void SetXY(double pfX, double pfY)
		{
			fX = pfX;
			fY = pfY;
		}


		public double X
		{
			get
			{
				return fX;
			}
			set
			{
				fX = value;
			}
		}

		public double Y
		{
			get
			{
				return fY;
			}
			set
			{
				fY = value;
			}
		}



		public void GetPolarCoords(ref double fR, ref double fTheta)
		{
			fR = Math.Sqrt(Math.Pow(fX, 2) + Math.Pow(fX, 2));
			fTheta = Math.Atan(fY / fX);
			fTheta = Trig.RadToDeg(fTheta);
			fTheta = Trig.TanQuadrant(fX, fY, fTheta);
		}

		public void SetPolarCoords(double fR, double fTheta)
		{
			fX = fR * Trig.Cos(fTheta);
			fY = fR * Trig.Sin(fTheta);
		}

		public void Translate(double piNewXOrigin, double piNewYOrigin)
		{
			fX -= piNewXOrigin;
			fY -= piNewYOrigin;
		}


	}
}
