using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Matrix
    {
        public double[,] val;
        public int Cols;
        public int Rows;

        public Matrix(int X, int Y)
        {
            Cols = X;
            Rows = Y;
            val = new double[Rows, Cols];
            Zero();
        }

        public Matrix(double[,] dArray)
        {
            val = dArray;
            Cols = val.GetLength(1);
            Rows = val.GetLength(0);
        }

        public void Zero()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    val[i, j] = 0;
                }
            }
        }
        public void SetIdentity()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (i == j)
                    {
                        val[i, j] = 1;
                    }
                    else
                    {
                        val[i, j] = 0;
                    }
                }
            }
        }
        public Matrix Transpose()
        {
            double[,] values = new double[Cols, Rows];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    values[j, i] = val[i, j];
                }
            }
            return new Matrix(values);
        }

        public Matrix Scale(double dFactor)
        {
            double[,] values = new double[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    values[i, j] = dFactor * val[i, j];
                }
            }
            return new Matrix(values);
        }

        public double Determinant()
        {
            double dDet = 0;
            int colIndex = 0;
            double dVal = 1;
            int k;
            for (int i = 0; i < Cols; i++)
            {
                k = 0;
                dVal = 1;
                for (int j = 0; j < Cols; j++)
                {
                    colIndex = (i + j) % 3;
                    dVal *= val[colIndex, k];
                    k++;
                }
                dDet += dVal;
            }
            for (int i = 0; i < Cols; i++)
            {
                k = 0;
                dVal = 1;
                for (int j = Cols-1; j >= 0; j--)
                {
                    colIndex = (i + j) % 3;
                    dVal *= val[colIndex, k];
                    k++;
                }
                dDet -= dVal;
            }

            return dDet;
        }
        public double Trace()
        {
            if (Rows != Cols)
            {
                return 0;
            }
            double dTrace = 0;
            for (int i = 0; i < Rows; i++)
            {

               dTrace += val[i, i];
            }
            return dTrace;            
        }

        public override string ToString()
        {
            string sStr = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    sStr += val[i, j].ToString() + ",";
                }
                sStr += Environment.NewLine;
            }
            return sStr;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            if ((left.Cols != right.Cols) || (left.Rows != right.Rows))
            {
                return left;
            }
            double[,] values = new double[left.Rows, left.Cols];

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Cols; j++)
                {
                    values[i,j] = left.val[i,j] + right.val[i,j];
                }
            }
            return (new Matrix(values));
        }

        public static Matrix operator +(double left, Matrix right)
        {
            double[,] values = new double[right.Rows, right.Cols];

            for (int i = 0; i < right.Rows; i++)
            {
                for (int j = 0; j < right.Cols; j++)
                {
                    values[i, j] = left + right.val[i, j];
                }
            }
            return (new Matrix(values));
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if ((left.Cols != right.Cols) || (left.Rows != right.Rows))
            {
                return left;
            }
            double[,] values = new double[left.Cols, left.Rows];

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Cols; j++)
                {
                    values[i, j] = left.val[i, j] - right.val[i, j];
                }
            }
            return (new Matrix(values));
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            double[,] values = new double[left.Rows, right.Cols];

            for (int h = 0; h < left.Rows; h++)
            {
                for (int i = 0; i < right.Cols; i++)
                {
                    for (int j = 0; j < left.Cols; j++)
                    {
                            values[h, i] += left.val[h, j] * right.val[j, i];
                    }
                }
            }
            return (new Matrix(values));
        }

    }
}
