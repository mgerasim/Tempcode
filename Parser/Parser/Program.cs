using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    class Program
    {
        static int Razdel01(string[] disArray, int iStart)
        {
            int index = 0;
            Console.WriteLine("Часть: {0}", disArray[index]);
            index++;
            string dis;
            dis = disArray[index];
            int month = Convert.ToInt32(dis.Substring(0, 2));
            Console.WriteLine("Месяц: {0:00}", month);
            int srok = Convert.ToInt32(dis.Substring(2, 2));
            Console.WriteLine("Срок: {0:00}", srok);

            int Id = Convert.ToInt32(dis.Substring(4, 1));
            Console.WriteLine("Кодовая цифра: {0:0}", Id);

            index++;
            dis = disArray[index];
            int II = Convert.ToInt32(dis.Substring(0, 2));
            Console.WriteLine("Номер района: {0:00}", II);
            int iii = Convert.ToInt32(dis.Substring(2, 3));
            Console.WriteLine("Номер станции: {0:000}", iii);


            index++;
            dis = disArray[index];
            int PPP = Convert.ToInt32(dis.Substring(2, 3));
            if (PPP < 100)
            {
                PPP += 1000;
            }
            Console.WriteLine("Давление: {0:} гПа", PPP);


            index++;
            dis = disArray[index];
            int T0T0 = Convert.ToInt32(dis.Substring(0, 2));
            Console.WriteLine("Тепмпература: {0:00}", T0T0);
            int Ta0 = Convert.ToInt32(dis.Substring(2, 1));
            Console.WriteLine("Знак: {0:0}", Ta0);
            int D0D0 = Convert.ToInt32(dis.Substring(3, 2));
            Console.WriteLine("Дефицит точки росы: {0:0}", D0D0);



            index++;
            dis = disArray[index];
            int d0d0 = Convert.ToInt32(dis.Substring(0, 2));
            Console.WriteLine("От куда дует: {0:00}", d0d0);
            int f0f0f0 = Convert.ToInt32(dis.Substring(2, 3));
            Console.WriteLine("Скорость ветра: {0:0}", f0f0f0);            

            return index;
        }

        static void ParseTTAA(string rawString)
        {            
            char[] chTrim = { '=' };
            rawString = rawString.TrimEnd(chTrim);
            string[] disArray = rawString.Split(' ');
            int iStart = 0;
            Razdel01(disArray, iStart);
            
        }

        static void Parser(string rawString)
        {
            string rawType;
            rawType = rawString.Substring(0, 4);
            
            switch (rawType) 
            {
                case "TTAA": ParseTTAA(rawString);
                    return;
                default:
                    Console.WriteLine("Неизвестный код");
                    return;
            }
        }

        static void Main(string[] args)
        {
            string rawString = "TTAA 01001 23078 99026 42324 11007 00240 41545 12514 92782 31525 22006 85381 30320 25508 70750 34541 29011 50506 42750 29531 40653 52950 29033 30834 64548 28534 25944 66148 29033 20080 66347 29027 15253 68750 29025 10494 72950 29020 88266 66547 28533 77348 28534=";
            Console.WriteLine("Распознаем:");
            Console.WriteLine(rawString);
            Parser(rawString);

            Console.ReadLine();
        }
    }
}
