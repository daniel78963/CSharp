using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encontrar números impares entre número min y n. top


            int l = -2;
            int r = 9;
            int min = l;

            List<int> numbersResult = new List<int>();
            int result = (l % 2);
            Console.WriteLine($"result {result}");
            Console.ReadKey();

            if ((l % 2) != 0)
            {
                min = l;
            }
            else
            {
                min++;
            }
            //numbersResult.Add(min);

            for (int i = min; i < r; i = i + 2)
            {
                numbersResult.Add(i);
            }

            if ((r % 2) != 0)
            {
                numbersResult.Add(r);
            }

            foreach (int i in numbersResult)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
