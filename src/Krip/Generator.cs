using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krip
{
    class Functions
    {
        LongOperation op = new LongOperation();
        List<int> p0 = new List<int> { 168, 67, 95, 6, 107, 117, 108, 89, 113, 223, 135, 149, 23, 240, 216, 9, 109, 243, 29, 203, 201, 77, 44, 175, 121, 224, 151, 253, 111, 75, 69, 57, 62, 221, 163, 79, 180, 182, 154, 14, 31, 191, 21, 225, 73, 210, 147, 198, 146, 114, 158, 97, 209, 99, 250, 238, 244, 25, 213, 173, 88, 164, 187, 161, 220, 242, 131, 55, 66, 228, 122, 50, 156, 204, 171, 74, 143, 110, 4, 39, 46, 231, 226, 90, 150, 22, 35, 43, 194, 101, 102, 15, 188, 169, 71, 65, 52, 72, 252, 183, 106, 136, 165, 83, 134, 249, 91, 219, 56, 123, 195, 30, 34, 51, 36, 40, 54, 199, 178, 59, 142, 119, 186, 245, 20, 159, 8, 85, 155, 76, 254, 96, 92, 218, 24, 70, 205, 125, 33, 176, 63, 27, 137, 255, 235, 132, 105, 58, 157, 215, 211, 112, 103, 64, 181, 222, 93, 48, 145, 177, 120, 17, 1, 229, 0, 104, 152, 160, 197, 2, 166, 116, 45, 11, 162, 118, 179, 190, 206, 189, 174, 233, 138, 49, 28, 236, 241, 153, 148, 170, 246, 38, 47, 239, 232, 140, 53, 3, 212, 127, 251, 5, 193, 94, 144, 32, 61, 130, 247, 234, 10, 13, 126, 248, 80, 26, 196, 7, 87, 184, 60, 98, 227, 200, 172, 82, 100, 16, 208, 217, 19, 12, 18, 41, 81, 185, 207, 214, 115, 141, 129, 84, 192, 237, 78, 68, 167, 42, 133, 37, 230, 202, 124, 139, 86, 128 };
        List<int> p1 = new List<int> { 206, 187, 235, 146, 234, 203, 19, 193, 233, 58, 214, 178, 210, 144, 23, 248, 66, 21, 86, 180, 101, 28, 136, 67, 197, 92, 54, 186, 245, 87, 103, 141, 49, 246, 100, 88, 158, 244, 34, 170, 117, 15, 2, 177, 223, 109, 115, 77, 124, 38, 46, 247, 8, 93, 68, 62, 159, 20, 200, 174, 84, 16, 216, 188, 26, 107, 105, 243, 189, 51, 171, 250, 209, 155, 104, 78, 22, 149, 145, 238, 76, 99, 142, 91, 204, 60, 25, 161, 129, 73, 123, 217, 111, 55, 96, 202, 231, 43, 72, 253, 150, 69, 252, 65, 18, 13, 121, 229, 137, 140, 227, 32, 48, 220, 183, 108, 74, 181, 63, 151, 212, 98, 45, 6, 164, 165, 131, 95, 42, 218, 201, 0, 126, 162, 85, 191, 17, 213, 156, 207, 14, 10, 61, 81, 125, 147, 27, 254, 196, 71, 9, 134, 11, 143, 157, 106, 7, 185, 176, 152, 24, 50, 113, 75, 239, 59, 112, 160, 228, 64, 255, 195, 169, 230, 120, 249, 139, 70, 128, 30, 56, 225, 184, 168, 224, 12, 35, 118, 29, 37, 36, 5, 241, 110, 148, 40, 154, 132, 232, 163, 79, 119, 211, 133, 226, 82, 242, 130, 80, 122, 47, 116, 83, 179, 97, 175, 57, 53, 222, 205, 31, 153, 172, 173, 114, 44, 221, 208, 135, 190, 94, 166, 236, 4, 198, 3, 52, 251, 219, 89, 182, 194, 1, 240, 90, 237, 167, 102, 33, 127, 138, 39, 199, 192, 41, 215 };
        List<int> p2 = new List<int> { 147, 217, 154, 181, 152, 34, 69, 252, 186, 106, 223, 2, 159, 220, 81, 89, 74, 23, 43, 194, 148, 244, 187, 163, 98, 228, 113, 212, 205, 112, 22, 225, 73, 60, 192, 216, 92, 155, 173, 133, 83, 161, 122, 200, 45, 224, 209, 114, 166, 44, 196, 227, 118, 120, 183, 180, 9, 59, 14, 65, 76, 222, 178, 144, 37, 165, 215, 3, 17, 0, 195, 46, 146, 239, 78, 18, 157, 125, 203, 53, 16, 213, 79, 158, 77, 169, 85, 198, 208, 123, 24, 151, 211, 54, 230, 72, 86, 129, 143, 119, 204, 156, 185, 226, 172, 184, 47, 21, 164, 124, 218, 56, 30, 11, 5, 214, 20, 110, 108, 126, 102, 253, 177, 229, 96, 175, 94, 51, 135, 201, 240, 93, 109, 63, 136, 141, 199, 247, 29, 233, 236, 237, 128, 41, 39, 207, 153, 168, 80, 15, 55, 36, 40, 48, 149, 210, 62, 91, 64, 131, 179, 105, 87, 31, 7, 28, 138, 188, 32, 235, 206, 142, 171, 238, 49, 162, 115, 249, 202, 58, 26, 251, 13, 193, 254, 250, 242, 111, 189, 150, 221, 67, 82, 182, 8, 243, 174, 190, 25, 137, 50, 38, 176, 234, 75, 100, 132, 130, 107, 245, 121, 191, 1, 95, 117, 99, 27, 35, 61, 104, 42, 101, 232, 145, 246, 255, 19, 88, 241, 71, 10, 127, 197, 167, 231, 97, 90, 6, 70, 68, 66, 4, 160, 219, 57, 134, 84, 170, 140, 52, 33, 139, 248, 12, 116, 103 };
        List<int> p3 = new List<int> { 104, 141, 202, 77, 115, 75, 78, 42, 212, 82, 38, 179, 84, 30, 25, 31, 34, 3, 70, 61, 45, 74, 83, 131, 19, 138, 183, 213, 37, 121, 245, 189, 88, 47, 13, 2, 237, 81, 158, 17, 242, 62, 85, 94, 209, 22, 60, 102, 112, 93, 243, 69, 64, 204, 232, 148, 86, 8, 206, 26, 58, 210, 225, 223, 181, 56, 110, 14, 229, 244, 249, 134, 233, 79, 214, 133, 35, 207, 50, 153, 49, 20, 174, 238, 200, 72, 211, 48, 161, 146, 65, 177, 24, 196, 44, 113, 114, 68, 21, 253, 55, 190, 95, 170, 155, 136, 216, 171, 137, 156, 250, 96, 234, 188, 98, 12, 36, 166, 168, 236, 103, 32, 219, 124, 40, 221, 172, 91, 52, 126, 16, 241, 123, 143, 99, 160, 5, 154, 67, 119, 33, 191, 39, 9, 195, 159, 182, 215, 41, 194, 235, 192, 164, 139, 140, 29, 251, 255, 193, 178, 151, 46, 248, 101, 246, 117, 7, 4, 73, 51, 228, 217, 185, 208, 66, 199, 108, 144, 0, 142, 111, 80, 1, 197, 218, 71, 63, 205, 105, 162, 226, 122, 167, 198, 147, 15, 10, 6, 230, 43, 150, 163, 28, 175, 106, 18, 132, 57, 231, 176, 130, 247, 254, 157, 135, 92, 129, 53, 222, 180, 165, 252, 128, 239, 203, 187, 107, 118, 186, 90, 125, 120, 11, 149, 227, 173, 116, 152, 59, 54, 100, 109, 220, 240, 89, 169, 76, 23, 127, 145, 184, 201, 87, 27, 224, 97 };

        public List<int> h(List<int> s1, List<int> s2, List<int> x)
        {
            List<int> res = Phi(Xor(x, s1));
            while (res.Count < s2.Count)
                res.Insert(0, 0);
            res = Xor(s2, res);
            return res;
        }

        public List<int> f(List<int> s1, List<int> s2, List<int> x)
        {
            List<int> res = s1.ToList();
            res.AddRange(s2);
            res = Xor(x, Psi(res));
            return res;
        }

        public List<int> Phi(List<int> u)
        {
            List<List<int>> x = new List<List<int>>();
            List<int> v = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                List<int> y = new List<int>();
                List<int> p = Substitution(i % 4);
                for (int j = 0; j < 4; j++)
                    y.Add(p[u[8 * j + i]]);
                switch (i / 2)
                {
                    case 0: break;
                    case 1:
                        y.Add(y[0]);
                        y.RemoveAt(0);
                        break;
                    case 2:
                        for (int l = 0; l < 2; l++)
                        {
                            y.Add(y[0]);
                            y.RemoveAt(0);
                        }
                        break;
                    default:
                        for (int l = 0; l < 3; l++)
                        {
                            y.Add(y[0]);
                            y.RemoveAt(0);
                        }
                        break;
                }
                x.Add(y);
            }
            List<int> d = new List<int> { 1, 1, 5, 1, 8, 6, 7, 4 };
            string mod = "100011101";
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    string l = Convert.ToString(x[i][j], 2);
                    string w = Convert.ToString(d[i], 2);
                    string s0, s = "", nul = "";
                    bool flag = false;
                    for (int r = w.Length - 1; r >= 0; r--)
                    {
                        if (w[r] == '1')
                        {
                            s0 = l + nul;
                            if (flag)
                            {
                                while (s.Length < s0.Length)
                                    s = "0" + s;
                                s = Eor(s0, s);
                                s = s.TrimStart('0');
                                if (s.Length == 0)
                                    s = "0";
                            }
                            else s = s0;
                            flag = true;
                        }
                        nul += "0";
                    }
                    while (s.Length > 8) 
                    {
                        string m = mod;
                        while (m.Length < s.Length)
                            m += "0";
                        s = Eor(s, m);
                        s = s.TrimStart('0');
                        if (s.Length == 0)
                            s = "0";
                    }
                    v.Add(Convert.ToInt32(s, 2));
                }
                d.Add(d[0]);
                d.RemoveAt(0);
            }
            return v;
        }

        public List<int> Psi(List<int> u)
        {
            List<List<int>> x = new List<List<int>>();
            List<int> v = new List<int>();
            List<int> p = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                List<int> y = new List<int>();
                p = Substitution(i % 4).ToList();
                for (int j = 0; j < 8; j++)
                    y.Add(p[u[8 * j + i]]);
                for (int t = 0; t < i; t++)
                {
                    y.Insert(0, y.Last());
                    y.RemoveAt(y.Count - 1);
                }
                x.Add(y);
            }
            List<int> d = new List<int> { 1, 1, 5, 1, 8, 6, 7, 4 };
            string mod = "100011101";
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    string l = Convert.ToString(x[i][j], 2);
                    string w = Convert.ToString(d[i], 2);
                    string s0, s = "", nul = "";
                    bool flag = false;
                    for (int r = w.Length - 1; r >= 0; r--)
                    {
                        if (w[r] == '1')
                        {
                            s0 = l + nul;
                            if (flag)
                            {
                                while (s.Length < s0.Length)
                                    s = "0" + s;
                                s = Eor(s0, s);
                                s = s.TrimStart('0');
                                if (s.Length == 0)
                                    s = "0";
                            }
                            else s = s0;
                            flag = true;
                        }
                        nul += "0";
                    }
                    while (s.Length > 8)
                    {
                        string m = mod;
                        while (m.Length < s.Length)
                            m += "0";
                        s = Eor(s, m);
                        s = s.TrimStart('0');
                        if (s.Length == 0)
                            s = "0";
                    }
                    v.Add(Convert.ToInt32(s, 2));
                }
                d.Add(d[0]);
                d.RemoveAt(0);
            }
            for (int i = 0; i < v.Count; i++)
            {
                p = Substitution(i % 4).ToList();
                v[i] = p[v[i]];
            }
            for (int i = 0; i < 32; i++)
            {
                v[32] = Convert.ToInt32(Eor(AddNull(Convert.ToString(v[0], 2)), AddNull(Convert.ToString(v[32], 2))), 2);
                v.RemoveAt(0);
            }
            return v;
        }

        public List<int> Const(int i, List<int> Kl, List<int> Kr, List<int> Kal, List<int> Kar, List<int> Kbl, List<int> Kbr)
        {
            List<int> K = new List<int>();
            switch(i+1)
            {
                case 1: K = Kl.ToList();break;
                case 2: K = Kr.ToList();break;
                case 3: K = Kbl.ToList();break;
                case 4: K = Kbr.ToList();break;
                case 5: K = Shift(Kal, 15);break;
                case 6: K = Shift(Kar, 15);break;
                case 7: K = Xor(Kl, Shift(Kbl, 15));break;
                case 8: K = Xor(Kr, Shift(Kbr, 15));break;
                case 9: K = Shift(Kal, 30);break;
                case 10: K = Shift(Kar, 30);break;
                case 11: K = Shift(Kbl, 30);break;
                case 12: K = Shift(Kbr, 30);break;
                case 13: K = Xor(Kl, Shift(Kal, 45));break;
                case 14: K = Xor(Kr, Shift(Kar, 45));break;
                case 15: K = Shift(Kbl, 45);break;
                case 16: K = Shift(Kbr, 45);break;
                case 17: K = Shift(Kal, 60);break;
                case 18: K = Shift(Kar, 60);break;
                case 19: K = Shift(Kl, 60);break;
                case 20: K = Shift(Kr, 60);break;
                case 21: K = Xor(Kal, Shift(Kbl, 77));break;
                case 22: K = Xor(Kar, Shift(Kbr, 77));break;
                case 23: K = Shift(Kbl, 77);break;
                case 24: K = Shift(Kbr, 77);break;
                case 25: K = Shift(Kal, 94);break;
                case 26: K = Shift(Kar, 94);break;
                case 27: K = Xor(Kl, Shift(Kr, 94));break;
                case 28: K = Xor(Kr, Shift(Kl, 94));break;
                case 29: K = Xor(Kal, Shift(Kar, 111));break;
                case 30: K = Xor(Kar, Shift(Kal, 111));break;
                case 31: K = Xor(Kbl, Shift(Kbr, 111));break;
                default: K = Xor(Kbr, Shift(Kbl, 111));break;
            }
            return K;
        }

        private List<int> Shift(List<int> U, int n)
        {
            string u = "";
            for (int i = 0; i < U.Count; i++)
                u += AddNull(Convert.ToString(U[i], 2));
            u = u.Substring(u.Length - n, n) + u.Substring(0, u.Length - n);
            U = bittobyte(u);
            return U.ToList();
        }

        public List<int> Substitution(int n)
        {
            switch(n)
            {
                case 0: return p0;
                case 1: return p1;
                case 2: return p2;
                default: return p3;
            }
        }

        public List<int> Generators(int size)
        {
            return BBS(size);
        }

        private List<int> BBS(int size)
        {
            Random R = new Random();
            List<int> p = op.Input("D5BBB96D30086EC484EBA3D7F9CAEB07");
            List<int> q = op.Input("425D2B9BFDB25B9CF6C416CC6E37B59C1F");
            List<int> n = op.LongMul(p, q);
            List<int> m = op.LongM(n);
            List<int> x = new List<int>();
            List<int> r = op.Rand(R.Next(2, p.Count / 2));
            r.Add(1);
            for (int i = 0; i < size; i++)
            {
                r = op.LongMod(op.LongMul(r, r), n, m);
                x.Add(r[0]);
                if (i == size - 1 && x.Last() == 0)
                    i -= 1;
            }
            if (x.Count != size)
                x.RemoveAt(size);
            return x;
        }

        public string AddNull(string s)
        {
            while (s.Length < 8)
                s = "0" + s;
            return s;
        }

        public string Eor(string a, string b)
        {
            string c = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i]) c += "0";
                else c += "1";
            }
            return c;
        }

        public List<int> Xor(List<int> a, List<int> b)
        {
            string s;
            List<int> c = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                s = Eor(AddNull(Convert.ToString(a[i], 2)), AddNull(Convert.ToString(b[i], 2)));
                c.Add(Convert.ToInt32(s, 2));
            }
            return c;
        }

        public List<int> bittobyte(string s)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < s.Length; i += 8) 
                res.Add(Convert.ToInt32(s.Substring(i, 8), 2));
            return res;
        }


    }
}
