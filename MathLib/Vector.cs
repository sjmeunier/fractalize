using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Vector
    {
        public double[] val;
        public int Dimension;

        public Vector(double[] Values)
        {
            val = Values;
            Dimension = val.GetLength(0);
        }

        public Vector(int iDim)
        {
            val = new double[iDim];
            Dimension = iDim;
            Zero();
        }


        public void Zero()
        {
            for(int i = 0; i < Dimension; i++)
            {
                val[i] = 0;
            }
        }

        public double Abs()
        {
            double dAbs = 0;

            for (int i = 0; i < Dimension; i++)
            {
                dAbs += val[i] * val[i];
            }
            return Math.Sqrt(dAbs);
        }

        public double Dot(Vector oVec)
        {
            if (oVec.Dimension != Dimension)
            {
                return 0;
            }
            double dDotProd = 0;
            for (int i = 0; i < Dimension; i++)
            {
                dDotProd += val[i] * oVec.val[i];
            }
            return dDotProd;
        }

        public Vector Scale(double dFactor)
        {
            double[] values = new double[Dimension];

            for (int i = 0; i < Dimension; i++)
            {
                values[i] = val[i] * dFactor;
            }
            return new Vector(values);
        }

        public override string ToString()
        {
            string sStr = "";
            for (int i = 0; i < Dimension; i++)
            {
                if (i != 0)
                {
                    sStr += ", ";
                }
                sStr += val[i];
            }
            return "(" + sStr + ")";
        }


        public static Vector operator +(Vector left, Vector right)
        {
            if (left.Dimension != right.Dimension)
            {
                return left;
            }
            double[] values = new double[left.Dimension];

            for (int i = 0; i < left.Dimension; i++)
            {
                values[i] = left.val[i] + right.val[i];
            }
            return (new Vector(values));
        }

        public static Vector operator -(Vector left, Vector right)
        {
            if (left.Dimension != right.Dimension)
            {
                return left;
            }
            double[] values = new double[left.Dimension];

            for (int i = 0; i < left.Dimension; i++)
            {
                values[i] = left.val[i] - right.val[i];
            }
            return (new Vector(values));
        }

    }
}
