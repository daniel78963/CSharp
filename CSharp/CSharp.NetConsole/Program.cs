using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.NetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "CBA";
            string[] _str = stringPermutation(s);
            Console.WriteLine("      ID#: {0:d}", _str);

            int[] a = { 6, 7, 3, 8 };
            int[] b = nextLarger(a);
            Console.WriteLine("      ID#: {0:d}", b);

            Dictionary<int, int> sums;
            var count = 0;
            //sums.TryGetValue(6, out count);

            int[] statues = { 6, 2, 3, 8 };
            int valueMake = MakeArrayConsecutive(statues);
            Console.ReadKey();

            int stairs = climbingStairs(5);
            Console.ReadKey();
        }

        public static string[] stringPermutation(string s)
        {
            var result = perms(s);
            return result.ToArray();
        }

        static SortedSet<string> perms(string s)
        {
            SortedSet<string> result = new SortedSet<string>();
            if (s.Length == 1)
            {
                result.Add(s);
            }
            else if (s.Length > 1)
            {
                var current = s.Substring(0, 1);
                var inner = perms(s.Substring(1));
                foreach (var str in inner)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        result.Add(str.Insert(i, current));
                    }
                }
            }
            return result;
        }

        //private TreeNode<t> nodeSet;
        ////BinaryNode
        //public static int sumtTree(TreeView<int> t, Dictionary<int,int> sums)
        //{
        //    if (t==null)
        //    {
        //        return 0;
        //    }
        //    var sumL = sumtTree(t.left, sums);
        //    var sumR = sumtTree(t.right, sums);
        //    var total = sumL + sumR + t.value;
        //    var count = 0;
        //    sums.TryGetValue(total, out count);
        //    sums[total] = count + 1;
        //    return total;
        //}

        public static int[] nextLarger(int[] a)
        {
            if (a.Length == 1)
            {

            }
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        b[i] = a[j];
                        break;
                    }
                    else
                    {
                        b[i] = -1;
                    }
                }

            }
            b[a.Length - 1] = -1;
            return b;
        }

        public static string[][] groupDishes(string[][] dishes)
        {
            var r = new SortedDictionary<string, SortedList<string, object>>(StringComparer.Ordinal);
            foreach (var d_item in dishes)
            {
                string dish = d_item[0];
                //r[].Add(dish, null);
            }

            return null;
        }

        public static int MakeArrayConsecutive(int[] statues)
        {
            int min = 20;
            int max = 0;
            for (int i = 0; i < statues.Length; i++)
            {
                if (min > statues[i])
                {
                    min = statues[i];
                }
                if (max < statues[i])
                {
                    max = statues[i];
                }
            }
            return (max - min - statues.Length + 1);
        }

        public static int climbingStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            int n_2 = 1;
            int n_1 = 2;
            int current = 0;
            for (int i = 2; i < n; i++)
            {
                current = n_2 + n_1;
                n_2 = n_1;
                n_1 = current;
            }
            return current;
        }
    }
}
