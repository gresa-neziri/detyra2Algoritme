using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detyra2_AA
{
    class DivFree
    {
        public static int counter = 0;
        public const int mod = 1000000007;
        public static int[] arr_extender(int[] base_array, int new_element)
        {
            int[] new_array = new int[base_array.Length + 1];
            for (int i = 0; i < base_array.Length; i++)
            {
                new_array[i] = base_array[i];
            }
            new_array[base_array.Length] = new_element;

            return new_array;
        }
        public static int dfcount(int n, int k)
        {
            List<int[]> lst = new List<int[]>();
            List<int[]> lst_array = new List<int[]>();

            if (n < 1 || n > 50000 || k < 1 || k > 50000)
                throw new Exception("N dhe K duhet te jene mes 1 dhe 50000");

            //mbushja me elementet baze prej 1-k
            for (int a = 1; a <= k; a++)
            {
                lst_array.Add(new int[1] { a });
            }

            for (int b = 2; b <= n; b++)
            {
                foreach (var item in lst_array)
                {
                    if (item.Length == b - 1)
                    {
                        for (int x = 1; x <= k; x++)
                        {
                            if (item[item.Length - 1] <= x || item[item.Length - 1] % x != 0)
                            {
                                lst.Add(arr_extender(item, x));
                            }
                        }
                    }
                }
                lst_array.AddRange(lst);
            }
            if (n == 1)
            {
                counter = k;
            }
            foreach (var item in lst)
            {
                if (item.Length == n)
                    counter++;
            }
            lst_array.Clear();
            lst.Clear();

             return counter % mod ;
        }
       
    }
}
