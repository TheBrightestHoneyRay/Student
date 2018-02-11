using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string ar = File.ReadAllText(@"C:\Users\Acer\Desktop\MAMI2.txt");
            string[] num = ar.Split(' ');
            int maxi = int.Parse(num[0]);
            int mini = int.Parse(num[0]);
            for(int i = 0; i < num.Length; i++)
            {
                int a = int.Parse(num[i]);
                if (a > maxi)
                    maxi = a;
                if (a < mini)
                    mini = a;
            }
            string res = "Maximum = " + maxi + " Minimum = " + mini;
            File.WriteAllText(@"C:\Users\Acer\Desktop\MAMI.txt", res);
            Console.ReadKey();
        }

    }
}
