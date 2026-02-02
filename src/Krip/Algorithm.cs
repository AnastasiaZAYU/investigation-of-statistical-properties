using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krip
{
    class Algorithm
    {
        LongOperation op = new LongOperation();
        Functions f = new Functions();
        Test t = new Test();
        List<int> s0 = new List<int>();
        List<int> s1 = new List<int>();
        List<int> x = new List<int>();
        List<int> y = new List<int>();

        public void Test()
        {
            int count = 0;
            double n = 0;
            for (int i = 0; i < 20; i++)
            {
                count = 0;
                List<int> k = f.Generators(32);
                for (int j = 0; j < 100; j++)
                {
                    GenerateInitialState(k);
                    x = f.Generators(512);
                    y = Crypt(x.ToList(), s0.ToList(), s1.ToList());
                    string seq = op.Output(y);
                    if (seq.Length % 2 != 0) 
                        seq = "0" + seq;
                    if (t.X2sign(seq) && t.SeriesMaxLength(seq) && t.X2bigram(y, seq)
                        && t.NumberSeries(seq) && t.PlaceSign(seq) && t.Inversion(seq))
                        count++;
                }
                Console.WriteLine("Детермiнант = {0}", count / 100.0);
                n += count / 100.0;
            }
            Console.WriteLine("Вибiркове математичне сподiвання = {0}", n / 20.0);
        }

        public void Test(int count)
        {
            double n = 0;
            for (int i = 0; i < 20; i++)
            {
                count = 0;
                List<int> k = f.Generators(32);
                Console.WriteLine("Значення ключа: {0}", op.Output(k));
                for (int j = 0; j < 100; j++)
                {
                    GenerateInitialState(k);
                    List<int> s = s0.ToList();
                    s0.AddRange(s1);
                    string seq = op.Output(s);
                    if (seq.Length % 2 != 0)
                        seq = "0" + seq;
                    if (t.X2sign(seq) && t.SeriesMaxLength(seq) && t.X2bigram(s, seq) 
                        && t.NumberSeries(seq) && t.PlaceSign(seq) && t.Inversion(seq))
                        count++;
                }
                Console.WriteLine("Детермiнант = {0}", count / 100.0);
                n += count / 100.0;
            }
            Console.WriteLine("Вибiркове математичне сподiвання = {0}", n / 20.0);
        }

        public void Crypt(bool flag)
        {
            if(flag)
            {
                op.Print(y);
                List<int> t = new List<int>();
                t = Crypt(y.ToList(), s0.ToList(), s1.ToList());
                Console.WriteLine("Розшифроване повiдомлення: ");
                op.Print(t);
                if (op.LongCmp(x, t) == 0)
                    Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
            else
            {
                x = f.Generators(512);
                op.Print(x);
                y = Crypt(x.ToList(), s0.ToList(), s1.ToList());
                Console.WriteLine("Шифртекст: ");
                op.Print(y);
            }
        }

        public List<int> Crypt(List<int> c, List<int> a0, List<int> b1)
        {
            List<int> s = new List<int>();
            List<int> w = new List<int>();
            for (int i = 0; i < c.Count; i += 32) 
            {
                List<int> a = a0.ToList();
                List<int> b = b1.ToList();
                w.AddRange(f.f(b, a, c.GetRange(i, 32)));
                s = b.ToList();
                b = f.h(b, a, c.GetRange(i, 32));
                a = s.ToList();
            }
            return w;
        }

        public void GenerateInitialState()
        {
            GenerateInitialState(f.Generators(32));
        }

        public void GenerateInitialState(List<int> k)
        {
            List<int> C1 = op.InputRev("A09E667F3BCC908B2FB1366EA957D3E3ADEC17512775099DA2F590B0667322A9");
            List<int> C2 = op.InputRev("B67AE8584CAA73B25742D7078B83B8925D834CC53DA4798C720A6486E45A6E24");
            List<int> C3 = op.InputRev("C6EF372FE94F82BE73980C0B9DB906821044ED7E744E4A3F0D8D423A1831D2A4");
            List<int> C4 = op.InputRev("54FF53A5F1D36F1CEA7E61FC37A20D54A77FE7B78415DFC8E34A6FE8E2DF92A4");
            List<int> C5 = op.InputRev("54FF53A5F1D36F1CEA7E61FC37A20D54A77FE7B78415DFC8E34A6FE8E2DF92A4");
            List<int> C6 = op.InputRev("B05688C2B3E6C1FDBD99E6FF3C90BDC4DBC64712A5BB168767E27C3CF76C8E72");

            List<int> c = f.Generators(16);
            string k1 = "", k2 = "", c1 = "", c2 = "";
            for (int i = 0, j = 16; i < 16; i++, j++)
            {
                k1 += f.AddNull(Convert.ToString(k[i], 2));
                k2 += f.AddNull(Convert.ToString(k[j], 2));
                c1 += f.AddNull(Convert.ToString(c[i], 2));
                c2 += f.Eor(c1.Substring(8 * i, 8), "11111111");
            }

            List<int> Kl = f.bittobyte(f.Eor(k1, c2) + f.Eor(f.Eor(k1, k2), c1));
            List<int> Kr = f.bittobyte(f.Eor(f.Eor(k1, k2), c2) + f.Eor(k2, c2));

            List<int> U1 = f.h(Kl, Kr, C1);
            List<int> U2 = Kl.ToList();
            List<int> U = U1.ToList();
            U1 = f.h(U1, U2, C2);
            U2 = U.ToList();

            U = Kr.GetRange(16, 16);
            U.AddRange(Kl.GetRange(0, 16));
            U1 = f.Xor(U1, U);
            U = Kl.GetRange(16, 16);
            U.AddRange(Kr.GetRange(0, 16));
            U2 = f.Xor(U2, U);

            List<int> Kal = f.h(U1, U2, C3);
            List<int> Kar = U1.ToList();
            U = Kal.ToList();
            Kal = f.h(Kal, Kar, C4);
            Kar = U.ToList();

            U = U2.GetRange(16, 16);
            U.AddRange(U1.GetRange(0, 16));
            List<int> U0 = U1.GetRange(16, 16);
            U0.AddRange(U2.GetRange(0, 16));
            U1 = f.Xor(Kal, U);
            U2 = f.Xor(Kar, U0);

            List<int> Kbl = f.h(U1, U2, C5);
            List<int> Kbr = U1.ToList();
            U = Kbl.ToList();
            Kbl = f.h(Kbl, Kbr, C6);
            Kbr = U.ToList();

            U1 = Kl.ToList();
            U2 = Kr.ToList();

            for (int i = 0; i < 32; i++)
            {
                U = U1.ToList();
                U1 = f.h(U1, U2, f.Const(i, Kl, Kr, Kal, Kar, Kbl, Kbr));
                U2 = U.ToList();
            }
            s0 = U1.ToList();
            s1 = U2.ToList();
        }
    }
}
