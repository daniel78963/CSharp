using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> logs = new List<string> { "30 99 sign in", "30 105 sign out", "40 30 sign in", "40 35 sign out" };
            int maxSpan = 5;
            int n = 7;
            string[] ids = new string[n];
            string[] timeIn = new string[n];
            string[] timeOut = new string[n];

            int i = 0;
            int index = 0;
            foreach (string item in logs)
            {
                string[] subs = item.Split(' ');
                //if (ids[i].Contains( subs[0]))
                //{
                //    //es pq ya es de salida pq ya lo metimos de entrada

                //}

                //validar si ya existe
                if (ids.Contains(subs[0]))
                {
                    //index = ids[]
                    //es pq ya es de salida pq ya lo metimos de entrada
                      index = Array.IndexOf(ids, subs[0]);
                }
                else
                {
                    ids[i] = subs[0];
                    index = i;
                }
                //saber el index
              

                if (subs[3] == "in")
                {
                    timeIn[index] = subs[1];
                }

                if (subs[3] == "out")
                {
                    timeOut[index] = subs[1];
                }

                Console.WriteLine(item);
                Console.WriteLine($"id:  {ids[i]} - timeIn: { timeIn[i]} - timeOut: { timeOut[i]} ");
                i++;
            }

            //foreach (int i in numbersResult)
            //{
            //    Console.WriteLine(i);
            //}


            Console.ReadKey();

        }
    }
}
