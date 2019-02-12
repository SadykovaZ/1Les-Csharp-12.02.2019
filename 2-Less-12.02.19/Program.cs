using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Less_12._02._19
{
    class Program
    {
        static string str = "{'PIN':'2288','BRAND':'NGK','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21943','PARNR':'0000000000','KEYZAK':'MOV0000075','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'135.50','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'2288','BRAND':'NGK','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21943','PARNR':'0000000000','KEYZAK':'MOV0000086','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'142.00','WAERS':'RUB','DLVDT':'20170601181500','ANALOG':'','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'2288','BRAND':'NGK','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21943','PARNR':'0000000000','KEYZAK':'MOV0000073','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'100.0','PRICE':'138.00','WAERS':'RUB','DLVDT':'20170529181500','ANALOG':'','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 241 235 751','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21939','PARNR':'0000000000','KEYZAK':'MOV0000073','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'100.0','PRICE':'77.00','WAERS':'RUB','DLVDT':'20170529181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 241 235 751','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21939','PARNR':'0000000000','KEYZAK':'MOV0000086','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'79.50','WAERS':'RUB','DLVDT':'20170601181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 241 235 751','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21939','PARNR':'0000000000','KEYZAK':'MOV0000075','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'75.50','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 241 235 751','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21939','PARNR':'0000000000','KEYZAK':'MOV0003701','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'77.50','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z101','BRAND':'BERU','NAME':'свеча зажигания!\\ MB Sprinter/Vito 2.0/2.3 95-06, VW LT 2.3 96>','ARTID':'21940','PARNR':'0000111848','KEYZAK':'0000007743','RVALUE':'87','RDPRF':'1','MINBM':'1.000','VENSL':'85.0','PRICE':'265.50','WAERS':'RUB','DLVDT':'20170605181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z101','BRAND':'BERU','NAME':'свеча зажигания!\\ MB Sprinter/Vito 2.0/2.3 95-06, VW LT 2.3 96>','ARTID':'21940','PARNR':'0000243470','KEYZAK':'0000027909','RVALUE':'10','RDPRF':'1','MINBM':'1.000','VENSL':'90.0','PRICE':'59.00','WAERS':'RUB','DLVDT':'20170605181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z101','BRAND':'BERU','NAME':'свеча зажигания!\\ MB Sprinter/Vito 2.0/2.3 95-06, VW LT 2.3 96>','ARTID':'21940','PARNR':'0000067395','KEYZAK':'0000004405','RVALUE':'10','RDPRF':'1','MINBM':'1.000','VENSL':'91.0','PRICE':'59.50','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'101000054AD','BRAND':'VAG','NAME':'свеча зажигания!\\ Audi, VW','ARTID':'21942','PARNR':'0000163677','KEYZAK':'0000015039','RVALUE':'161','RDPRF':'1','MINBM':'1.000','VENSL':'93.0','PRICE':'502.00','WAERS':'RUB','DLVDT':'20170605181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'101000054AD','BRAND':'VAG','NAME':'свеча зажигания!\\ Audi, VW','ARTID':'21942','PARNR':'0000107322','KEYZAK':'0000006716','RVALUE':'1','RDPRF':'1','MINBM':'1.000','VENSL':'73.0','PRICE':'249.00','WAERS':'RUB','DLVDT':'20170605181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'101000054AD','BRAND':'VAG','NAME':'свеча зажигания!\\ Audi, VW','ARTID':'21942','PARNR':'0000093931','KEYZAK':'0000004180','RVALUE':'20','RDPRF':'1','MINBM':'1.000','VENSL':'95.0','PRICE':'292.00','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null}{'PIN':'Z129','BRAND':'BERU','NAME':'свеча зажигания!\\ Audi A6/A8 4.2/4.8 98-05, Peugeot 306 1.6 00-02','ARTID':'21944','PARNR':'0000087685','KEYZAK':'0000004225','RVALUE':'2','RDPRF':'1','MINBM':'1.000','VENSL':'92.0','PRICE':'301.00','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z129','BRAND':'BERU','NAME':'свеча зажигания!\\ Audi A6/A8 4.2/4.8 98-05, Peugeot 306 1.6 00-02','ARTID':'21944','PARNR':'0000172366','KEYZAK':'0000018013','RVALUE':'40','RDPRF':'10','MINBM':'1.000','VENSL':'74.0','PRICE':'318.00','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 242 240 587','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW 316i-840i, Opel Astra, Omega 1.6-4.0 87>','ARTID':'21945','PARNR':'0000000000','KEYZAK':'MOV0000075','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'266.00','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 242 240 587','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW 316i-840i, Opel Astra, Omega 1.6-4.0 87>','ARTID':'21945','PARNR':'0000000000','KEYZAK':'MOV0000086','RVALUE':'6','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'279.50','WAERS':'RUB','DLVDT':'20170601181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'0 242 240 587','BRAND':'BOSCH','NAME':'свеча зажигания!\\ BMW 316i-840i, Opel Astra, Omega 1.6-4.0 87>','ARTID':'21945','PARNR':'0000000000','KEYZAK':'MOV0000073','RVALUE':'1','RDPRF':'1','MINBM':'1.000','VENSL':'100.0','PRICE':'271.50','WAERS':'RUB','DLVDT':'20170529181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z14','BRAND':'BERU','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21946','PARNR':'0000000000','KEYZAK':'MOV0000075','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'126.50','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z14','BRAND':'BERU','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21946','PARNR':'0000000000','KEYZAK':'MOV0000112','RVALUE':'6','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'132.50','WAERS':'RUB','DLVDT':'20170601181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z14','BRAND':'BERU','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21946','PARNR':'0000000000','KEYZAK':'MOV0000086','RVALUE':'6','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'132.50','WAERS':'RUB','DLVDT':'20170601181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'Z14','BRAND':'BERU','NAME':'свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98','ARTID':'21946','PARNR':'0000000000','KEYZAK':'MOV0000073','RVALUE':'8','RDPRF':'1','MINBM':'1.000','VENSL':'100.0','PRICE':'129.00','WAERS':'RUB','DLVDT':'20170529181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'RFC58LZ2E','BRAND':'EYQUEM','NAME':'свеча зажигания!\\ BMW 316i-840i, Opel Astra, Omega 1.6-4.0 87-94','ARTID':'21947','PARNR':'0000000000','KEYZAK':'MOV0000073','RVALUE':'1','RDPRF':'1','MINBM':'1.000','VENSL':'100.0','PRICE':'135.50','WAERS':'RUB','DLVDT':'20170529181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},{'PIN':'RFC58LZ2E','BRAND':'EYQUEM','NAME':'свеча зажигания!\\ BMW 316i-840i, Opel Astra, Omega 1.6-4.0 87-94','ARTID':'21947','PARNR':'0000000000','KEYZAK':'MOV0000075','RVALUE':'>20','RDPRF':'1','MINBM':'1.000','VENSL':'98.0','PRICE':'132.50','WAERS':'RUB','DLVDT':'20170602181500','ANALOG':'X','MSG':null,'PriceTenge':0,'PriceRub':0.0,'ArtificialPrice':null,'ShowArtificialByDefault':false,'SupplierId':0,'Delivery':null,'DeliveryEx':0,'DeliveryGu':0,'Vkorg':null,'Kunnr':null},";
        static void Main(string[] args)
        {
            //var arrStr = str.Split(new String[] { "}," }, StringSplitOptions.None);
            //string outStr = "";
            //for (int i = 0; i < arrStr.Length; i++)
            //{
            //    if (!string.IsNullOrWhiteSpace(arrStr[i]))
            //    {
            //        var result = arrStr[i].Replace("{", "").Split(new String[] { "','" }, StringSplitOptions.None);
            //        for (int j = 0; j < result.Length; j++)
            //        {
            //            var t = result[j].Replace("'", "").Split(':');

            //            if (t[0] == "PIN")
            //            {
            //                outStr = string.Concat(outStr, string.Format("PIN: # {0} \n", t[1]));
            //            }

            //            else if (t[0] == "NAME")
            //            {
            //                outStr = string.Concat(outStr, string.Format("Name: {0} \n", t[1]));
            //            }

            //            else if (t[0].Equals("PRICE"))
            //            {
            //                outStr = string.Concat(outStr, string.Format("Price: {0:0.000} \n", t[1]));
            //            }
            //        }

            //        outStr = string.Concat(outStr, "\n--------------------\n");


            //    }

            //    Console.WriteLine(outStr);
            //}
            example09();
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
            result = string.Concat(strC, strD, "Test"); //передавать сколько угодно переменных



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

            if (str.IndexOf("?", 0) > 0) //что искать и откуда начинать , введет поиск с начала
            {

            }

            else if (str.LastIndexOf("tab", 0) > 0)//введет поиск с конца
            {

            }

            string result = str.Substring(str.IndexOf("?", 0), str.Length - str.IndexOf("?", 0));
            Console.WriteLine(result);

            result = string.Format("a= {0:0.000 USD}", 563); //шаблон

            Console.WriteLine(result);

            Console.WriteLine("a = {0,6:0.##}", 12.234);
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

            strA = strA.Replace("city", "country").Replace("Kunayeva", "Pushkina");
            Console.WriteLine(strA);

            Console.WriteLine(strA.Remove(0, 10));
            //ToUpper() - верхний регистры
            //ToLower() - нижний регистры


        }

        static void exmpl07()
        {
            StringBuilder sb = new StringBuilder("Hello world");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);

            sb.Append("45621");
            Console.WriteLine(sb);

            //StringBuilder быстрее работатет чем string, ограничения в , поэтому используется string
        }

        static void Lab01()
        {
            string str = "1234567889012345678890123456788901234567889012345678890123456788901234567 8890123456788901234567889012345678890";            long sum = 0;            for (int i = 0; i < str.Length; i++)
            {
                sum += Convert.ToInt64(str[i]);
            }            Console.WriteLine("sum = {0}",sum);
        }

        static void Lab02()
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];


            Random rnd = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(0, 20);
                Console.WriteLine("{0} ", A[i]);
            }
            Console.WriteLine("");
            double max = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    B[i, j] = rnd.NextDouble();
                    
                    if (B[i, j] > max)
                        max = B[i, j];
                    Console.WriteLine("{0} ", B[i,j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Max a = {0}", A.Max());
            Console.WriteLine("Max b = {0}", max);
        }

        static void exampl08()
        {
            //первая и последняя буква в слове совпадает
            string str = "fjf tdt";

            string[] arr = str.Replace(",","").Replace(".","").Split(' ');
            int count = 0;
            foreach(string word in arr)
            {
                if (word[0] == word[word.Length - 1])
                    count++;

            }
            Console.WriteLine("count: {0}", count);


        }

        static void example09()
        {
            //наибольшее кол во идущих подряд одинаковых символов

            string str = "наибольшее кол во идущих подряд одинаковых символов";
            int count = 0;
            int max = 0;
            string maxletter;
            string letter="";
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i].Equals(str[i + 1]))
                {
                    count++;
                    letter = str[i].ToString();

                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                        maxletter = letter;

                    }
                    count = 0;
                }
            }


        }



    }
}
