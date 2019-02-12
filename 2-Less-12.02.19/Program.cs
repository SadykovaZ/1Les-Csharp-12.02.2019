using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Less_12._02._19
{
    class Program
    {
        static void Main(string[] args)
        {
            exmpl07();
        }

        static void Exmpl01()
        {
           //1. создание сроки
            string s0;

            string s1 = "Hello";

            string s2 = null;

            string s3 = new string('-', 6);

            string s4 = new String(new char[] { 'h', 'e' });

        }

        static void exmpl02()
        {
           //2. сравнение строки
            string strA = "hello";
            string strB = "hello";

            if (strA == strB)
            {
            }
            else if (strA.Equals(strB))
            {
            }

            char ch1 = strA[1];

            //3. сравнение строк
            Console.WriteLine(string.Compare(strA, strB, true));

            Console.WriteLine(string.CompareOrdinal(strA, strB));

            Console.WriteLine(strA.CompareTo(strB));

            //4. конкатенация

            string strC = "Hello";
            string strD = "world";

            string result = strC = strD;
            result = string.Concat(strC,strD,"Test"); //передавать сколько угодно переменных

            

        }

        static void exmpl03()
        {
            //ищет в строке начало и конец строки
            string str = "4002 5524 5689 4526";

            if (str.StartsWith("4002"))
            {
                Console.WriteLine("Visa");
            }
            if (str.EndsWith("4526"))
            {
                Console.WriteLine("MC");
            }

        }

        static void exmpl04()
        {
            string str = "https://github.com/SadykovaZ?tab=repositories";

            if (str.IndexOf("?", 0)>0) //что искать и откуда начинать , введет поиск с начала
            {

            }

            else if(str.LastIndexOf("tab",0)>0)//введет поиск с конца
            {

            }

            string result = str.Substring(str.IndexOf("?", 0), str.Length- str.IndexOf("?", 0));
            Console.WriteLine(result);

            result = string.Format("a= {0:0.000 USD}", 563); //шаблон

            Console.WriteLine(result);

            Console.WriteLine("a = {0,6:0.##}",12.234);
            Console.WriteLine("Current time {0:hh.mm}", DateTime.Now);
        }

        static void exmpl05()
        {
            string str = "4002 5524 5689 4526";
            var arrStr = str.Split(' ');

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arrStr[i]);
            //}

            string result = string.Join("*", arrStr);
            Console.WriteLine(result);

            result = result + "*";

            result = str.Trim(' ');

            Console.WriteLine(result);

        }

        static void exmpl06()
        {
            string strA = "Almaty city, Kunayeva";

            Console.WriteLine(strA.Insert(0, "Delivery address "));

            strA = strA.Replace("city", "country").Replace("Kunayeva","Pushkina");
            Console.WriteLine(strA);

            Console.WriteLine(strA.Remove(0,10));
            //ToUpper() - верхний регистры
            //ToLower() - нижний регистры


        }

        static void exmpl07()
        {
            StringBuilder sb = new StringBuilder("Hello world");
            Console.WriteLine( sb.Length);
            Console.WriteLine(sb.Capacity);

            sb.Append("45621");
            Console.WriteLine(sb);

            //StringBuilder быстрее работатет чем string, ограничения в , поэтому используется string
        }
    }
}
