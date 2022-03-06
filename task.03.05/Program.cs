using System;

namespace mertebe.sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ededin nece mertebeli oldugunu tapmaq

            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count += 1;
            }
            Console.WriteLine(count);










            //sozun daxilindeki a herfinin sayi

            //string word = "Azerbaycanliyam";
            //int say = 0;
            //foreach (char item in word)
            //{
            //    if (item == 'a' || item == 'A')
            //    {
            //        say++;
            //    }
            //}
            //Console.WriteLine(say);








            //3 ebolunen ededlerin cemi

            //int[] arr = { 3, 6, 8, 10, 32, 45, 51 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 == 0)

            //        sum += arr[i];
            //}
            //Console.WriteLine(sum);



        }
    }
}
