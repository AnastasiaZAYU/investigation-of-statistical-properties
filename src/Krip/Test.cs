using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krip
{
    class Test
    {
        int N = 16;

        public bool X2sign(string s)
        {
            double alpha = 0.001;
            int n = s.Length;
            double Xa2 = 37.7;

            double X2 = 0;
            List<int> M = new List<int>(new int[N]);
            for (int i = 0; i < n; i++)
                M[Convert.ToInt32(s[i].ToString(), 16)]++;
            for (int i = 0; i < N; i++)
                X2 += Math.Pow(M[i], 2);
            X2 = X2 * N / n - n;

            if (X2 < Xa2) return true;
            return false;
        }

        public bool SeriesMaxLength(string s)
        {
            double alpha = 0.001;
            int n = s.Length;
            int Sa = Convert.ToInt32((Math.Log10(n * N / alpha) / Math.Log10(N)));

            int S = 0;
            for (int i = 0, j = 1; i < n - 1; i++, j = 1)
            {
                while (s[i] == s[i + j]) 
                {
                    j++;
                    if (i + j == n)
                        break;
                }
                if (S < j) S = j;
            }

            if (S <= Sa) return true;
            return false;
        }

        public bool X2bigram(List<int> l, string s)
        {
            int N2 = (int)Math.Pow(N, 2);
            double alpha = 0.01;
            int k = l.Count;
            double za = 2.33;
            double Xa2 = Math.Pow(Math.Sqrt(2 * (N2 - 1) - 1) + za, 2) / 2;

            double X2 = 0;
            List<int> M = new List<int>(new int[N2]);
            for (int i = 0; i < l.Count; i++)
                M[l[i]]++;
            for (int i = 0; i < N2; i++)
                X2 += Math.Pow(M[i], 2);
            X2 = X2 * N2 / k - k;

            if (X2 < Xa2) return true;
            return false;
        }

        public bool NumberSeries(string s)
        {
            double alpha = 0.01;
            int n = s.Length;
            double Ga = 2.58;

            int Gn = 1;
            for (int i = 0; i < n - 1; i++) 
                if (s[i] != s[i + 1]) Gn++;
            double MGn = (n - 1) * (1 - 1 / Convert.ToDouble(N)) + 1;
            double DGn = (n - 1) * (N - 1) / Math.Pow(N, 2);
            double G = Math.Abs((Gn - MGn) / Math.Sqrt(DGn));

            if (G < Ga) return true;
            return false;
        }

        public bool PlaceSign(string s)
        {
            double alpha = 0.01;
            int n = s.Length;
            double Xa2 = 30.6;

            double T = 0;
            List<int> Rv = new List<int>(new int[N]);
            for (int j = 0; j < N; j++)
            {
                char v = Convert.ToChar(Convert.ToString(j, 16).ToUpper());
                for (int i = 0; i < n; i++)
                    if (s[i] == v) Rv[j] += i;
            }
            for (int i = 0; i < N; i++) 
                T += Math.Pow(Rv[i] / Convert.ToDouble(n) - (n + 1) / Convert.ToDouble(2 * N), 2);
            T *= 3 * N / Convert.ToDouble(n);

            if (T < Xa2) return true;
            return false;
        }

        public bool Inversion(string s)
        {
            double alpha = 0.01;
            int n = s.Length;
            double Ia = 2.58;

            int In = 0;
            for (int i = 0; i < n; i += 2) 
                if (s[i] < s[i + 1]) In++;
            double MIn = n / 2 * (0.5 - 1 / Convert.ToDouble(2 * N));
            double DIn = n / 2 * (0.25 - 1 / (4 * Math.Pow(N, 2)));
            double I = Math.Abs((In - MIn) / Math.Sqrt(DIn));

            if (I < Ia) return true;
            return false;
        }
    }
}
