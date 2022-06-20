using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Verilmiş n -ədədinin 3 - ə və 7 - ə bölünüb - bölünməməsini tapın.

            //Console.Write("Enter a Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());


            //task1(n);


            //2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

            Console.Write("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("one more:");
            int m = Convert.ToInt32(Console.ReadLine());

            task2(n, m);

            //3.Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.

            //int a = 1;
            //int b = 5;
            //int sum = 0;

            //task3(a, b, sum);

            // 4) Verilmish arrayin icindeki tek ededlerin cemini tapin.
            //int[] nums = { 1, 3, 4, 9, 5, 6, 7 };
            //int sum = 0;

            //task4(nums, sum);

            //5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

            //int[] nums = { 1, 2, 5, 6, 8, 11, 13, 12, 16, 26 };
            //int count = 0;

            //task5(nums, count);

            //6) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

            //int count = 0;
            //Console.Write("Sayı Girin : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //task6(n, count);
        }

        //1.Verilmiş n -ədədinin 3 - ə və 7 - ə bölünüb - bölünməməsini tapın.
        static void task1(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("divisible");
            }

            else
                Console.WriteLine("indivisible");
        }    
        //2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
        static void task2(int n , int m)
        {


            if (n % 2 == 0 && m % 2 == 0)
            {
                Console.WriteLine(n + m);
            }
            else
            {
                Console.WriteLine("not an even number");
            }

        }
        //3.Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.
        static void task3(int a , int b , int sum)
        {
            for (int i = a; i < b; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            Console.WriteLine(sum - a);

        }
        // 4) Verilmish arrayin icindeki tek ededlerin cemini tapin.
        static void task4(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    sum = sum + nums[i];
                }
            }
            Console.WriteLine(sum);
        }
        //5) Verilmish arrayin icindeki cut ededlerin sayini tapin.
        static void task5(int[] nums, int count)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        //6) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
        static void task6(int n, int count )
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    count++;
            }

            if (count != 0)
                Console.WriteLine("murekkebdir");
            else
                Console.WriteLine("sadedir");
            Console.ReadKey();
        }

    }
}
