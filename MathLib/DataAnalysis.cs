using System;


namespace MathLib
{
	/// <summary>
	/// Summary description for DataAnalysis.
	/// </summary>
	public class DataAnalysis
	{
		public DataAnalysis()
		{
		}

		public static double GeometricMean(double[] pfData, int piItems)
		{
			int i;
			double fGMean, fProd;

			fProd = 1.0;

			for (i = 0; i < piItems; i++)
			{
				fProd  *= pfData[i];
			}

			
			fGMean =  Math.Pow(fProd, (1.0 / (double)piItems));
			return fGMean;
		}

		public static double ArithmeticMean(double[] pfData, int piItems)
		{
			int i;
			double fMean, fSum;

			fSum = 0.0;

			for (i = 0; i < piItems; i++)
			{
				fSum  += pfData[i];
			}

			
			fMean =  fSum / (double)piItems;
			return fMean;
		}

		public static double Sum(double[] pfData, int piItems)
		{
			int i;
			double fSum;

			fSum = 0.0;

			for (i = 0; i < piItems; i++)
			{
				fSum  += pfData[i];
			}

			return fSum;
		}

		public static double Median(double[] pfData, int piItems)
		{
			int iMid;
			double fMedian, fSum;

			fSum = 0.0;

			//Add a sort here


			if (((int)Math.Round((double)piItems / 2.0) * 2) != piItems)
			{
				iMid = piItems / 2;
		
		
				fSum  = pfData[iMid];
				fSum  += pfData[iMid + 1];
				fSum /= 2.0;
			}
			else
			{
				iMid = (piItems / 2) + 1;
				fSum = pfData[iMid];
			}
			
			fMedian = fSum;
			return fMedian;
		}
		public static double StandardDeviation(double[] pfData, int piItems)
		{
			int i;
			double fSD, fMean, fDevMean;
			double[] fDeviation = new double[piItems];
			
			fMean = ArithmeticMean(pfData, piItems);

			for (i = 0; i < piItems; i++)
			{
				fDeviation[i] = Math.Pow((pfData[i] - fMean), 2);
			}

			fDevMean = ArithmeticMean(fDeviation, piItems);
			fSD = Math.Sqrt(fDevMean);

			return fSD;
		}

		public static double Variance(double[] pfData, int piItems)
		{
			double fSD, fVariance;

			fSD = StandardDeviation(pfData, piItems);
			fVariance = Math.Pow(fSD, 2);

			return fVariance;
		}

		public static double Max(double[] pfData, int piItems)
		{
			int i;
			double fMax;
			fMax = -1.0E300;
			
			for(i = 0; i < piItems; i++)
			{
				if (fMax < pfData[i])
				{
					fMax = pfData[i];
				}
			}

			return fMax;
		}

		public static double Min(double[] pfData, int piItems)
		{
			int i;
			double fMin;
			fMin = 1.0E300;
			
			for(i = 0; i < piItems; i++)
			{
				if (fMin > pfData[i])
				{
					fMin = pfData[i];
				}
			}

			return fMin;
		}

		public static void LeastSquaresFitLinear(Pnt[] pfP, int piPoints, ref double pfM, ref double pfB)
		{
			//Gives best fit of data to line Y = MC + B
			double fX1, fY1, fXY, fX2, fJ;
			int i;

			fX1 = 0.0;
			fY1 = 0.0;
			fXY = 0.0;
			fX2 = 0.0;

			for (i = 0; i < piPoints; i++)
			{
				fX1 = fX1 + pfP[i].X;
				fY1 = fY1 + pfP[i].Y;
				fXY = fXY + pfP[i].X * pfP[i].Y;
				fX2 = fX2 + pfP[i].X * pfP[i].X;
			}

			fJ = ((double)piPoints * fX2) - (fX1 * fX1);
			if (fJ != 0.0)
			{
				pfM = (((double)piPoints * fXY) - (fX1 * fY1)) / fJ;
				pfM = Math.Floor(1.0E3 * pfM + 0.5) / 1.0E3;
				pfB = ((fY1 * fX2) - (fX1 * fXY)) / fJ;
				pfB = Math.Floor(1.0E3 * pfB + 0.5) / 1.0E3;
			}
			else
			{
				pfM = 0;
				pfB = 0;
			}
		}

		public static void LeastSquaresFitLogOrdinate(Pnt[] pfP, int piPoints, ref double pfM, ref double pfB)
		{
			//Gives best fit of data to curve Y = B*(10^M)^X

			double fX1, fY1, fXY, fX2, fJ, fLY;
			int i;

			fX1 = 0.0;
			fY1 = 0.0;
			fXY = 0.0;
			fX2 = 0.0;

			for (i = 0; i < piPoints; i++)
			{
				fLY = Math.Log10(pfP[i].Y);
				fX1 = fX1 + pfP[i].X;
				fY1 = fY1 + fLY;
				fXY = fXY + pfP[i].X * fLY;
				fX2 = fX2 + pfP[i].X * pfP[i].X;
			}

			fJ = ((double)piPoints * fX2) - (fX1 * fX1);
			if (fJ != 0.0)
			{
				pfM = (((double)piPoints * fXY) - (fX1 * fY1)) / fJ;
				pfM = Math.Floor(1.0E3 * pfM + 0.5) / 1.0E3;
				pfB = ((fY1 * fX2) - (fX1 * fXY)) / fJ;
				pfB = Math.Floor(1.0E3 * pfB + 0.5) / 1.0E3;
			}
			else
			{
				pfM = 0;
				pfB = 0;
			}
		}

		public static void LeastSquaresFitLogAbscissa(Pnt[] pfP, int piPoints, ref double pfM, ref double pfB)
		{
			//Gives best fit of data to curve Y = M*log(X)/log(10) + B

			double fX1, fY1, fXY, fX2, fJ, fLX;
			int i;

			fX1 = 0.0;
			fY1 = 0.0;
			fXY = 0.0;
			fX2 = 0.0;

			for (i = 0; i < piPoints; i++)
			{
				fLX = Math.Log10(pfP[i].X);
				fX1 = fX1 + fLX;
				fY1 = fY1 + pfP[i].Y;
				fXY = fXY + pfP[i].Y * fLX;
				fX2 = fX2 + fLX * fLX;
			}

			fJ = ((double)piPoints * fX2) - (fX1 * fX1);
			if (fJ != 0.0)
			{
				pfM = (((double)piPoints * fXY) - (fX1 * fY1)) / fJ;
				pfM = Math.Floor(1.0E3 * pfM + 0.5) / 1.0E3;
				pfB = ((fY1 * fX2) - (fX1 * fXY)) / fJ;
				pfB = Math.Floor(1.0E3 * pfB + 0.5) / 1.0E3;
			}
			else
			{
				pfM = 0;
				pfB = 0;
			}
		}

		public static void LeastSquaresFitLogFull(Pnt[] pfP, int piPoints, ref double pfM, ref double pfB)
		{
			//Gives best fit of data to curve Y = B*X^M

			double fX1, fY1, fXY, fX2, fJ;
			double[] fLX = new double[piPoints];
			double[] fLY = new double[piPoints];
			int i;

			fX1 = 0.0;
			fY1 = 0.0;
			fXY = 0.0;
			fX2 = 0.0;

			for (i = 0; i < piPoints; i++)
			{
				fLX[i] = Math.Log10(pfP[i].X);
				fLY[i] = Math.Log10(pfP[i].Y);
				fX1 = fX1 + fLX[i];
				fY1 = fY1 + fLY[i];
				fXY = fXY + fLY[i] * fLX[i];
				fX2 = fX2 + fLX[i] * fLX[i];
			}

			fJ = ((double)piPoints * fX2) - (fX1 * fX1);
			if (fJ != 0.0)
			{
				pfM = (((double)piPoints * fXY) - (fX1 * fY1)) / fJ;
				pfM = Math.Floor(1.0E3 * pfM + 0.5) / 1.0E3;
				pfB = ((fY1 * fX2) - (fX1 * fXY)) / fJ;
				pfB = Math.Floor(1.0E3 * pfB + 0.5) / 1.0E3;
			}
			else
			{
				pfM = 0;
				pfB = 0;
			}
		}

		public double InterpolateLinearY(double pfM, double pfB, double pfX)
		{
			double fY;

			fY = (pfM * pfX) + pfB;
			return fY;
		}

		public double InterpolateLinearX(double pfM, double pfB, double pfY)
		{
			double fX;

			fX = (pfY - pfB) / pfM;
			return fX;
		}

		public double InterpolateLogOrdinateY(double pfM, double pfB, double pfX)
		{
			double fY;

			fY = pfB * Math.Pow(Math.Pow(10, pfM), pfX);
			return fY;
		}

		public double InterpolateLogOrdinateX(double pfM, double pfB, double pfY)
		{
			double fX;
			fX = 0;
			//fX = (pfY / pfB);
			return fX;
		}

		public double InterpolateLogAbscissaY(double pfM, double pfB, double pfX)
		{
			double fY;

			fY = (pfM * Math.Log10(pfX)) + pfB;
			return fY;
		}

		public double InterpolateLogAbscissaX(double pfM, double pfB, double pfY)
		{
			double fX;

			fX = Math.Pow(10, ((pfY - pfB) / pfM));
			return fX;
		}

		public double InterpolateLogFullY(double pfM, double pfB, double pfX)
		{
			double fY;

			fY = (pfB * Math.Pow(pfX, pfM));
			return fY;
		}

		public double InterpolateLogFullX(double pfM, double pfB, double pfY)
		{
			double fX;
			fX = 0;
			//fX = (pfY / pfM);
			return fX;
		}
	}
}
