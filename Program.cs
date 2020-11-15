using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 a
            float a=0;
            int i32 = 10;
            double c=0;
            char d='2';
            //1 b
            Int64 i64 = i32;
            long t1 = i32;
            ulong ff = d;
            int io = (byte)c;
            c = (int)a;
            int b = (short)d;
            //1 c
            Object k = a;
            byte m = (byte)(float)k;
            //1 d
            var s = 7;
            var u = 7.8;
            //1 e
            int? x = null;
            // 2 a
            string g = "fgjhhhhhh oaoes oafpf";
            string l = "ffhhhhh";
            Console.WriteLine(g==l);
            // 2 b
            string h = string.Concat(g, l);
            Console.WriteLine(h);
            string p = string.Copy(l);
            Console.WriteLine(p);
            g = g.Substring(2,3);
                Console.WriteLine(g);
            string[] str = g.Split(' ');
            string str1 = g.Insert(2,l);
            Console.WriteLine(l.Remove(0, 3)); 

            // 2 c
            string str3 = "";
            string str4 = null;
            Console.WriteLine(string.IsNullOrEmpty(str3));
            Console.WriteLine(string.IsNullOrEmpty(str4));
            // 2 d
            StringBuilder str5 = new StringBuilder("GGGG", 50);
            str5.AppendFormat("FO{0}","rk");
            str5.Insert(0,"zyyy");
            str5.Remove(5, 6);
            //3 a
            int[,] arr =  { { 4,5,6}, {5,8,9 }, { 2,4,56} };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length/rows;
           for(int i =0;i<rows;i++)
            {
               for (int j=0;j<columns;j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();    
            }
            //3 b
            Console.WriteLine("   ");
            string[] strArr = { "234", "567", "890" };
            foreach (var q in strArr)
                Console.Write("    " + q);

            Console.WriteLine(strArr.Length);
            strArr[1] = "01";
            //3 c
            int[][] starr = new int[3][];
            starr[0] = new int[2];
            starr[1] = new int[3];
            starr[2] = new int[4];
            for (int i = 0; i < starr.Length; i++)
            {
                for (int j = 0; j < starr[i].Length; j++)
                {
                    starr[i][j] = Convert.ToInt32( Console.ReadLine());
                }
            }
            Console.WriteLine("Вывод зубчатого массива:");
            for (int i = 0; i < starr.Length; i++)
            {
                for (int j = 0; j < starr[i].Length; j++)
                {
                    Console.Write(starr[i][j]+"\t");
                }
                Console.WriteLine();
            }
            //3 d
            dynamic st = new string[]{ "234", "567", "890" };
            dynamic strrr = " jfhvsih";
            //4
            (int, string, char, string, ulong) g123 = (10, "",'0', ";klj", 10);

            Console.WriteLine(g123.Item1);
            Console.WriteLine(g123.Item2);
            Console.WriteLine(g123.Item3);
            Console.WriteLine(g123.Item4);
            Console.WriteLine(g123.Item5);


            Console.WriteLine(g123.Item1);
            Console.WriteLine(g123.Item3);
            Console.WriteLine(g123.Item4);


            var (tuple1, tuple2, tuple3, tuple4, tuple5) = g123;

            (int, string, char, string, ulong) g1234 = (10, "", '0', ";klj", 10);

            Console.WriteLine(g123.Equals(g1234) ? "equals" : "not equals");

           
            
        }
        
        (int,int, int, char) func()
        {
            string s = "uyfdfefwehf";
            int[] arr = new int[4] { 3, 5, 6, 8 };
            int min = arr[0];
            int max = arr[1];
            int sum = 0;
            foreach(var el in arr)
            {
                if (min > el)
                    min = el;

                if (max < el)
                    max = el;

                sum += el;

            }
            Console.WriteLine("MAX"+max+" MIN "+min+" SUM "+sum);
            return (min, max, sum, s[0]);
           
        }
    }
}
