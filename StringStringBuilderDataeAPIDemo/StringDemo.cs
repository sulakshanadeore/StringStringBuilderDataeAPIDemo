using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilderDataeAPIDemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s = "Welcome";
            int len=s.Length;
            Console.WriteLine(len);
            s = "  Welcome    ";
            len = s.Length;
            Console.WriteLine("Before Trim=" + len);
                         s=s.Trim();
            len=s.Length;
            Console.WriteLine("After Trim=" + len);
            Console.WriteLine("Substring=");
            string s1=s.Substring(0, 3);
            Console.WriteLine(s1);
            string s2 = s.Substring(4);
            Console.WriteLine(s2);
            int indexOfC=s.IndexOf('c');
            Console.WriteLine("Index of c");
            Console.WriteLine(indexOfC);
            string newStr = "Welcome, to Mphasis, C#";
            string[] sep = { "a", "," };
            //char[] sep = { ' ' };
            int cnt = 2;
            string[] result=newStr.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------String Builder Examples------------");
            //string---immutable
            //It means string cannot be changed once crated 
            string str = "Hello";
            str = "Hello from me";//creates new object on the heap, instead of changing the previous value of the string at the same memory location.

            //StringBuilder---mutable
            //StringBuilder--in the System.Text namespace
            StringBuilder b = new StringBuilder("Hello World ");
            b.Append("Mphasis");
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.Write(b[i]);
            //}
            var sb=b.ToString();
            Console.WriteLine(sb);
            Console.WriteLine("---------------");
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello ");
            sb1.AppendLine("World");
            sb1.AppendLine("Hello from C#");
            Console.WriteLine(sb1);
            Console.WriteLine("----------------");

            StringBuilder f1 = new StringBuilder("Your total bill amt= ");
            f1.AppendFormat("{0:C} ", 30);
            f1.AppendFormat("on todays date {0:d}",DateTime.Now.Date);
            Console.WriteLine(f1);

            Console.WriteLine("---------------B2-------------");
            StringBuilder b2 = new StringBuilder("Hello World");
            b2.Insert(5, ".NET");
            Console.WriteLine(b2);
            b2.Remove(4, 2);

            Console.WriteLine("After remvoing= " + b2);
            b2.Replace("NET", "C#");
            Console.WriteLine("After replacing= ");
            Console.WriteLine(b2);











            Console.ReadLine();

        }
    }
}
