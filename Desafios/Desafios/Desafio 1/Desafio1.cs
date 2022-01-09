using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int C = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= C; i++){
                int n = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(n-(int)Math.Sqrt(n));
            }

        }
    }
}