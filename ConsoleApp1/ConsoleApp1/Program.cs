using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Cases
            //camel case
            //int avgStudentPoint

            //pascal case
            //int AvgStudnetPoint

            //snake case
            //int avg_student_point

            //kebab case
            //int avg-student-point
            #endregion

            int number = 4;

            if (number>0)
            {
                Console.WriteLine("musbetdir");
            }
            else if(number<0)
            {
                Console.WriteLine("menfidir");
            }
            else 
            {
                Console.WriteLine("sifirdir");
            }


            int weekDay = 4;

            //if(weekDay == 1)
            //{
            //    Console.WriteLine("Bazar ertesi");
            //}
            //else if(weekDay == 2)
            //{
            //    Console.WriteLine("Cersenbe axsami");
            //}
            //else if(weekDay == 3)
            //{
            //    Console.WriteLine("Cersenbe");
            //}
            //else if(weekDay == 4)
            //{
            //    Console.WriteLine("Cume axsami");
            //}
            //else if (weekDay == 5)
            //{
            //    Console.WriteLine("Cume");
            //}
            //else if (weekDay == 6)
            //{
            //    Console.WriteLine("Senbe");
            //}
            //else if (weekDay == 7)
            //{
            //    Console.WriteLine("Bazar");
            //}
            //else
            //{
            //    Console.WriteLine("Heftenin gunu yanlisdir");
            //}


            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume axsami");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("Heftenin gunu yanlisdir!");
                    break;

            }




            int[] numbers = { 10, 7,34, 56, 33,98 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]%2==0)
            //        Console.WriteLine(numbers[i]);
            //}

            int index = 0;

            while (index<numbers.Length)
            {
                if(numbers[index]%2==0)
                    Console.WriteLine(numbers[index]);

                index++;
            }

            //string input = Console.ReadLine();

            //while(input != "salam")
            //{
            //     input = Console.ReadLine();
            //}

            string input;
            do
            {
                input = Console.ReadLine();

            } while (input!="salam");

            Console.WriteLine("Poses bitdi");


            Console.WriteLine("items:");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Yasi daxil edin:");
            var ageStr = Console.ReadLine();
            byte age = Convert.ToByte(ageStr);

            int bornYear = 2022 - age;
            Console.WriteLine(bornYear);

        }
    }
}
