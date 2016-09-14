using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class FFT
    {

        public static void swap(ref double num1, ref double num2)
        {
            double tmp = num1;
            num1 = num2;
            num2 = tmp;
        }

        private static int BitRev(int j, int nu)
        {
            int j2, j1 = j, k = 0;
            for (int i = 1; i <= nu; i++)
            {
                j2 = j1 / 2;
                k = ((2 * k) + j1) - (2 * j2);
                j1 = j2;
            }
            return k;
        }

        public static void Transform(double[] samples, int numSamples, int sampleRate, bool powerSpectrum, ref double[] spectrumData)
        {
            double halfPi = Math.PI / 2.0;

            double[] dataReal = new double[numSamples];
            double[] dataIm = new double[numSamples];
            int sinCosRng = 2048;
            double[] sinTab = new double[sinCosRng];
            double[] cosTab = new double[sinCosRng];

            int nu = (int)(Math.Log10(numSamples) / Math.Log10(2));
            int halfSampCount = numSamples / 2;
            int nu1 = nu - 1;

            double tr, ti, p, arg, c, s;
            double step = halfPi / (double)sinCosRng;

            double rad = 0.0;
            for (int idx = 0; idx < sinCosRng; idx++)
            {
                sinTab[idx] = (double)Math.Sin(rad);
                cosTab[idx] = (double)Math.Cos(rad);
                rad += step;
            }


            // Load the sample data
            for (int i = 0; i < numSamples; i++)
            {
                dataReal[i] = samples[i];

                if (powerSpectrum != false)
                    spectrumData[i] = dataReal[i];

                dataIm[i] = 0;
            }
            int k = 0;
            int scidx;

            for (int l = 1; l <= nu; l++)
            {
                while (k < (numSamples / 2))
                {
                    for (int i = 1; i <= halfSampCount; i++)
                    {
                        // p   = (float)bitrev (k >> nu1, nu);
                        p = (double)BitRev(k >> nu1, nu);
                        arg = 2.0 * Math.PI * p / (double)numSamples;


                        // c   = (float) cos (arg);
                        // s   = (float) sin (arg);                    

                        while (arg >= halfPi)
                            arg = arg - halfPi;
                        scidx = (int)((arg / halfPi) * (double)sinCosRng);
                        c = cosTab[scidx];
                        s = sinTab[scidx];


                        tr = dataReal[k + halfSampCount] * c + dataIm[k + halfSampCount] * s;
                        ti = dataReal[k + halfSampCount] * c - dataReal[k + halfSampCount] * s;

                        dataReal[k + halfSampCount] = dataReal[k] - tr;
                        dataIm[k + halfSampCount] = dataIm[k] - ti;
                        dataReal[k] += tr;
                        dataIm[k] += ti;

                        k++;
                    }
                    k += halfSampCount;
                }

                k = 0;
                nu1--;

                halfSampCount = halfSampCount / 2;
            }

            k = 0;
            int r;

            while (k < numSamples)
            {
                r = BitRev(k, nu);

                if (r > k)
                {
                    tr = dataReal[k];
                    ti = dataIm[k];
                    dataReal[k] = dataReal[r];
                    dataIm[k] = dataIm[r];
                    dataReal[r] = tr;
                    dataIm[r] = ti;
                }

                k++;
            }

            halfSampCount = numSamples / 2;

            if (powerSpectrum != false)
            {
                for (int idx = 0; idx < halfSampCount; idx++)
                    spectrumData[idx] = 2.0 * ((double)dataReal[idx] / (double)numSamples);
            }
            else
            {
                spectrumData[0] = (double)(Math.Sqrt(dataReal[0] * dataReal[0] + dataIm[0] * dataIm[0])) / (double)numSamples;
                for (int idx = 1; idx < halfSampCount; idx++)
                    spectrumData[idx] = 2.0 * (double)(Math.Sqrt((dataReal[idx] * dataReal[idx]) + (dataIm[idx] * dataIm[idx]))) / (double)numSamples;
            }

        }

        public static void ComplexFFT(double[] data, int numSamples, int sampleRate, int sign, ref int fundamental, ref double[] complexData)
        {

            //variables for the fft
            int mmax, istep;
            int n;
            double wtemp, wr, wpr, wpi, wi, theta, tempr, tempi;

            //the complex array is real+complex so the array 
            //as a size n = 2* number of complex samples
            //real part is the data[index] and 
            //the complex part is the data[index+1]

            complexData = new double[(2 * sampleRate)];

            //put the real array in a complex array
            //the complex part is filled with 0's
            //the remaining complexData with no data is filled with 0's
            for (n = 0; n < sampleRate; n++)
            {
                if (n < numSamples)
                    complexData[2 * n] = data[n];
                else
                    complexData[2 * n] = 0;
                complexData[2 * n + 1] = 0;
            }

            //binary inversion (note that the indexes 
            //start from 0 witch means that the
            //real part of the complex is on the even-indexes 
            //and the complex part is on the odd-indexes)
            n = sampleRate << 1;
            int j = 0;
            int m = 0;

            for (int i = 0; i < n / 2; i += 2)
            {
                if (j > i)
                {
                    swap(ref complexData[j], ref complexData[i]);
                    swap(ref complexData[j + 1], ref complexData[i + 1]);
                    if ((j / 2) < (n / 4))
                    {
                        swap(ref complexData[(n - (i + 2))], ref complexData[(n - (j + 2))]);
                        swap(ref complexData[(n - (i + 2)) + 1], ref complexData[(n - (j + 2)) + 1]);
                    }
                }
                m = n >> 1;
                while (m >= 2 && j >= m)
                {
                    j -= m;
                    m >>= 1;
                }
                j += m;
            }
            //end of the bit-reversed order algorithm

            //Danielson-Lanzcos routine
            mmax = 2;
            while (n > mmax)
            {
                istep = mmax << 1;
                theta = sign * (2 * Math.PI / mmax);
                wtemp = Math.Sin(0.5 * theta);
                wpr = -2.0 * wtemp * wtemp;
                wpi = Math.Sin(theta);
                wr = 1.0;
                wi = 0.0;
                for (m = 1; m < mmax; m += 2)
                {
                    for (int i = m; i <= n; i += istep)
                    {
                        j = i + mmax;
                        tempr = wr * complexData[j - 1] - wi * complexData[j];
                        tempi = wr * complexData[j] + wi * complexData[j - 1];
                        complexData[j - 1] = complexData[i - 1] - tempr;
                        complexData[j] = complexData[i] - tempi;
                        complexData[i - 1] += tempr;
                        complexData[i] += tempi;
                    }
                    wtemp = wr;
                    wr = wr * wpr - wi * wpi + wr;
                    wi = wi * wpr + wtemp * wpi + wi;
                }
                mmax = istep;
            }
            //end of the algorithm

            //determine the fundamental frequency
            //look for the maximum absolute value in the complex array
            fundamental = 0;
            for (int i = 2; i <= sampleRate; i += 2)
            {
                if ((Math.Pow(complexData[i], 2) + Math.Pow(complexData[i + 1], 2)) > (Math.Pow(complexData[fundamental], 2) + Math.Pow(complexData[fundamental + 1], 2)))
                {
                    fundamental = i;
                }
            }

            //since the array of complex has the format [real][complex]=>[absolute value]
            //the maximum absolute value must be ajusted to half
            fundamental = Convert.ToInt32(Math.Floor((double)fundamental / 2.0));

        }
    }
}
