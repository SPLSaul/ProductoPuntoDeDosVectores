using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoPuntoDeDosVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
             a = Console.ReadLine().Split().Select(int.Parse).ToArray();
             b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * b[i];
            }
            Console.WriteLine(a.Sum());
            Console.ReadKey();
        }
    }
}
