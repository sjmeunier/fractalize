using System;

namespace MathLib
{
	/// <summary>
	/// Summary description for Finance.
	/// </summary>
	public class Finance
	{
		public Finance()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static double SimpleInterestFinalVal(double pfPrincipalVal, double pfInterest, double pfYears)
		{
			return pfPrincipalVal * (1 + ((pfInterest / 100.0) * pfYears));
		}

		public static double SimpleInterestPrincipalVal(double pfFinalVal, double pfInterest, double pfYears)
		{
			return pfFinalVal / (1 + ((pfInterest / 100.0) * pfYears));
		}

		public static double SimpleInterestInterest(double pfPrincipalVal, double pfFinalVal, double pfYears)
		{
			return (((pfFinalVal / pfPrincipalVal) - 1) / pfYears) * 100.0;
		}

		public static double SimpleInterestYears(double pfPrincipalVal, double pfFinalVal, double pfInterest)
		{
			return (((pfFinalVal / pfPrincipalVal) - 1) / (pfInterest / 100.0));
		}
		
		public static double CompoundInterestFinalVal(double pfPrincipalVal, double pfInterest, double pfYears)
		{
			return pfPrincipalVal * Math.Pow((1 + (pfInterest / 100.0)), pfYears);
		}

		public static double CompoundInterestPrincipalVal(double pfFinalVal, double pfInterest, double pfYears)
		{
			return pfFinalVal / Math.Pow((1 + (pfInterest / 100.0)), pfYears);
		}

		public static double CompoundInterestInterest(double pfPrincipalVal, double pfFinalVal, double pfYears)
		{
			return (MathExt.Root((pfFinalVal / pfPrincipalVal), pfYears) - 1) * 100.0;
		}

		public static double CompoundInterestYears(double pfPrincipalVal, double pfFinalVal, double pfInterest)
		{
			return Math.Log10(pfFinalVal / pfPrincipalVal) / Math.Log10(1 + (pfInterest / 100.0));
		}


		public static double SimpleDepreciationFinalVal(double pfPrincipalVal, double pfInterest, double pfYears)
		{
			return pfPrincipalVal * (1 - ((pfInterest / 100.0) * pfYears));
		}

		public static double SimpleDepreciationPrincipalVal(double pfFinalVal, double pfInterest, double pfYears)
		{
			return pfFinalVal / (1 - ((pfInterest / 100.0) * pfYears));
		}

		public static double SimpleDepreciationInterest(double pfPrincipalVal, double pfFinalVal, double pfYears)
		{
			return (((pfFinalVal / pfPrincipalVal) - 1) * (-1) / pfYears) * 100.0;
		}

		public static double SimpleDepreciationYears(double pfPrincipalVal, double pfFinalVal, double pfInterest)
		{
			return (((pfFinalVal / pfPrincipalVal) - 1) * (-1) / (pfInterest / 100.0));
		}
		
		public static double CompoundDepreciationFinalVal(double pfPrincipalVal, double pfInterest, double pfYears)
		{
			return pfPrincipalVal * Math.Pow((1 - (pfInterest / 100.0)), pfYears);
		}

		public static double CompoundDepreciationPrincipalVal(double pfFinalVal, double pfInterest, double pfYears)
		{
			return pfFinalVal / Math.Pow((1 - (pfInterest / 100.0)), pfYears);
		}

		public static double CompoundDepreciationInterest(double pfPrincipalVal, double pfFinalVal, double pfYears)
		{
			return (MathExt.Root((pfFinalVal / pfPrincipalVal), pfYears) - 1) * (-1) * 100.0;
		}

		public static double CompoundDepreciationYears(double pfPrincipalVal, double pfFinalVal, double pfInterest)
		{
			return Math.Log10(pfFinalVal / pfPrincipalVal) / Math.Log10(1 - (pfInterest / 100.0));
		}
	}
}
