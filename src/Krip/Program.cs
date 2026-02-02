using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krip
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Algorithm();
            bool prog = true;
            int r = 0;
            while (prog == true)
            {
                Console.WriteLine("Натиснiть “0” - щоб сформувати початковий стан НРЗ;" +
                    "\nнатиснiть “1” - щоб зашифрувати повiдомлення;" +
                    "\nнатиснiть “2” - щоб розшифрувати повiдомлення;" +
                    "\nнатиснiть “3” - щоб перевiрити статистичнi властивостi НРЗ;" +
                    "\nнатиснiть “4” - щоб перевiрити статистичнi властивостi алгоритму;" +
                    "\nнатиснiсть будь-який iнший символ - щоб завершити роботу.");
                r = int.Parse(Console.ReadLine());
                switch (r)
                {
                    case 0:
                        f.GenerateInitialState();
                        break;
                    case 1:
                        Console.WriteLine("Введiть повiдомлення, яке хочете зашифрувати: ");
                        f.Crypt(false);
                        break;
                    case 2:
                        Console.WriteLine("Введiть шифртекст, яке хочете розшифрувати: ");
                        f.Crypt(true);
                        break;
                    case 3:
                        f.Test(0);
                        break;
                    case 4:
                        f.Test();
                        break;
                    default:
                        prog = false;
                        break;
                }
            }
        }
    }
}
