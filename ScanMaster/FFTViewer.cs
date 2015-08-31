using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics;

using System.Numerics;

namespace ScanMaster
{
    public class FFTViewer
    {
        public FFTViewerWindow window;

        public FFTViewer()
        {
            window = new FFTViewerWindow(this);
            window.Show();
        }

        public void Close()
        {
            window.Dispose();
        }

        private double[] calculateAbsFFT(double[] initialY)
        {
            int numberOfPointsToDrop = window.GetNumberOfPointsToDropFromUI();
            double[] y = new double[initialY.Length - numberOfPointsToDrop];
            for(int i = 0; i < y.Length; i++)
            {
                y[i] = initialY[i + numberOfPointsToDrop];
            }
            Complex[] data = new Complex[y.Length];
            for(int i = 0; i < y.Length; i++)
            {
                data[i] = new Complex(y[i], 0);
            }
            Fourier.Forward(data);
            int lengthOfFFT = (int)Math.Round((double)y.Length / 2);
            double[] result = new double[lengthOfFFT];
            for (int i = 0; i < lengthOfFFT; i++)
            {
                result[i] = data[i].Magnitude;
            }
            
            return result;
        }
        private double[] normaliseAbsFFT(double[] fft, int gateLengthInCardClockPeriodUnits)
        {
            int numberOfPointsToDrop = window.GetNumberOfPointsToDropFromUI();
            double[] newData = new double[fft.Length];
            for (int i = 0; i < newData.Length; i++ )
            {
                newData[i] = 30 + 10 * Math.Log10((fft[i] * Math.Sqrt(2) * fft[i]  * Math.Sqrt(2)) / (50 * (gateLengthInCardClockPeriodUnits - numberOfPointsToDrop)));
            }
            return newData;
        }
        public void PlotFFT(double[] data, int gateLengthInCardClockPeriodUnits, int cardClockFrequency)
        {
            int numberOfPointsToDrop = window.GetNumberOfPointsToDropFromUI();
            double[] finalData = normaliseAbsFFT(calculateAbsFFT(data), gateLengthInCardClockPeriodUnits);
            double[] freqs = new double[finalData.Length];
            for (int i = 0; i < freqs.Length; i++ )
            {
                freqs[i] = 0.000001 * i / (Convert.ToDouble(gateLengthInCardClockPeriodUnits - numberOfPointsToDrop) / Convert.ToDouble(cardClockFrequency));
            }
            window.PlotFFT(freqs, finalData);
        }

    }
}
