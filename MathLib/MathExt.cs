using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public static class MathExt
    {
        public static long Factorial(int iNum)
        {
            long lFact = 1;
            for (int i = 2; i <= iNum; i++)
            {
                lFact = lFact * i;
            }
            return lFact;
        }

        public static int Permutation(int n, int r)
        {
            int Perm = 0;
            Perm = (int)(MathExt.Factorial(n) / MathExt.Factorial(n - r));
            return Perm;
        }

        public static int Combination(int n, int r)
        {
            int Comb = 0;
            Comb = (int)(MathExt.Factorial(n) / (MathExt.Factorial(n) * MathExt.Factorial(n - r)));
            return Comb;
        }

        public static int GCD(int iA, int iB)
        {
            if (iA == iB)
            {
                return iA;
            }
            if ((iA == 1) || (iB == 1))
            {
                return 1;
            }
            if ((iA % 2 == 0) && (iB % 2 == 0))
            {
                return 2 * GCD(iA / 2, iB / 2);
            }
            else if ((iA % 2 == 0) && (iB % 2 != 0))
            {
                return GCD(iA / 2, iB);
            }
            else if ((iA % 2 != 0) && (iB % 2 == 0))
            {
                return GCD(iA, iB / 2);
            }
            else
            {
                return GCD(Math.Abs(iA - iB) / 2, iB);
            }

        }


        public static long[] PrimeFactors(long lNum)
        {
            long[] lFactors = new long[10000];
            int iFactorCount = 0;
            while (lNum % 2 == 0)
            {
                lFactors[iFactorCount] = 2;
                lNum = lNum / 2;
                iFactorCount++;
            }

            long lDivisor = 3;
            while (lDivisor <= lNum)
            {
                if (lNum % lDivisor == 0)
                {
                    lFactors[iFactorCount] = lDivisor;
                    lNum = lNum / lDivisor;
                    iFactorCount++;
                }
                else
                {
                    lDivisor += 2;
                }
            }
           
            return lFactors;
        }

        public static long Fibonacci(int iCount)
        {
            if (iCount <= 1)
            {
                return iCount;
            }
            return Fibonacci(iCount - 1) + Fibonacci(iCount - 2);
        }

        public static bool IsOdd(int iNum)
        {
            if (iNum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsEven(int iNum)
        {
            if (iNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Root(double pfNum, double pfPower)
        {
            return Math.Pow(pfNum, (1.0 / pfPower));
        }

        public static double Inverse(double pfNum)
        {
            return 1.0 / pfNum;
        }

    }
}
