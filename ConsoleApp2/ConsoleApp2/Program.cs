using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region task1

            //Verilmis siyahidaki en boyuk ededi tapan proqram

            //int[] numbers = { 45, 3, 23, 6 };
            //int[] numbers = new int[5];

            //numbers[0] = 55;
            //numbers[1] = 36;

            int[] numbers = new int[6] { 10, 45, 77, 33, 25, 66 };

            int biggest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (biggest < numbers[i])
                {
                    biggest = numbers[i];
                }
            }

            Console.WriteLine(biggest);
            #endregion


            //Verilmis ededler siyahisindaki 3ve 7e bolunen ededlerin ededi
            //ortasini tapan proqram yazirsiniz

            #region task2

            double[] numbers2 = { 45, 10, 50, 66, 21, 42 };

            double sum = 0;
            int count = 0;

            for(int i = 0; i < numbers2.Length; i++)
            {
                if(numbers2[i]%3==0 && numbers2[i] % 7 == 0)
                {
                    sum += numbers2[i];
                    count++;
                }
            }

            if(count == 0)
                Console.WriteLine("3-e ve 7-e bolunen yoxdur!");
            else
            {
                double result = sum / count;
                Console.WriteLine(result);
            }

            //byte num = 45;
            //int a = num;

            //double b = a;


            //int num1 = 45;
            //double num2 = 2;

            //double r = num1 / num2;

            string name = "Hello, P227!";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            #endregion

            #region task3
            //Verilmis yazidaki a herflerinin sayini tapan proqram
            //yazini console - dan daxil edirsiniz

            Console.WriteLine("Yazini daxil edin:");
            string text = Console.ReadLine();

            int letterCounter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                    letterCounter++;
            }

            //string output = text+ " sozundeki a herflerinin sayi: " + letterCounter;

            Console.WriteLine(text + " sozundeki a herflerinin sayi: " + letterCounter);

            #endregion

            #region task4
            //Daxil edilmis yazida 1 reqeminin olub olmamasini tapan proqram

            Console.WriteLine("Metni daxil edin:");
            string text2 = Console.ReadLine();

            bool has1 = false;
            for (int i = 0; i < text2.Length; i++)
            {
                if(text2[i] == '1')
                {
                    has1 = true;
                    break;
                }
            }

            if(has1)
                Console.WriteLine("Daxil edilmis metnde 1 deyeri var");
            else
                Console.WriteLine("Daxil edilmis metnde 1 deyeri yoxdur!");


            //Verilmis yazinin icerisinde reqem olub olmadigini tapan proqram
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };


            #endregion

        }
    }
}
