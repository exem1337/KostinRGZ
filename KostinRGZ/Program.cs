using System;

namespace KostinRGZ
{
    class Program
    {
        static double[] gaub1, gaub2, gaub3;
        static double[] y1, y2, y3;
        static void Main(string[] args)
        {
            gaub1 = createArray();
            //gaub2 = createArray();
            //gaub3 = createArray();
            y1 = fillYs(gaub1);
            //y2 = fillYs(gaub2);
            //y3 = fillYs(gaub3);

            double fi = calcFi(gaub1, y1);
            Console.WriteLine(fi);
        }

        static double calcFi(double[] gaubs, double[] y) => (1 / 3 * countSum(gaubs) - 1 / 3 * countSum(y)) / 3.25;
        
        static double[] fillYs(double[] gaubs)
        {
            double[] y = new double[3];
            for(int i = 0; i < 3; i++)
            {
                double a = ((1 / (4 * Math.Sqrt(2 * 3.14))));
                double b = Math.Pow(2.72,(-1 * (Math.Pow((gaubs[i] - 0.05), 2) / 2 * 16)));
                y[i] = Math.Pow(a, b);
            }
            return y;
        }

        static double countSum(double[] arr)
        {
            double sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double[] createArray()
        {
            Random rnd = new Random();
            double[] arr = new double[3];
            for(int i = 0; i < 3; i++)
            {
                arr[i] = rnd.Next(11, 19);
            }
            return arr;


            #region
            Console.WriteLine("да");
            #endregion
        }

    }
}
