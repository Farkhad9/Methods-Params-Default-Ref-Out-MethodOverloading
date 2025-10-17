using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MethodPractice.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region second codes

            //Console.WriteLine(SumOfArrayElements(new int[] { 2, 4, 6 }));

            // Console.WriteLine(RemoveSpace(" Salam Genc le r "));
            //var result = AddElementToArray(new int[] { 22,89,61},34);
            // foreach (var end in result)
            // {
            //     Console.WriteLine(end);
            // }

            //PrintArrayElements("lorem", "ipsum", "lo", "rem");
            //Console.WriteLine(Summa(13));
            //method overloading 
            //metodun imzasi
            // Summa(2, 3);
            #endregion
            //int num = 12;
            //int num2 = num;
            //num2 = 55;
            //Console.WriteLine(num);
            //int[] numbers1 = { 1, 2, 30 };
            //int[]  numbers2 = numbers1;
            // numbers2[0] = 10;
            //Console.WriteLine(numbers1[0]);

            //string word1 = "lorem";//immutable
            //string NewWord = "";
            //NewWord += 'm';
            //NewWord += 'e';
            //ref,out
            //int[] array = { 11, 22 };
            //ChangeArray(array);
            //Console.WriteLine(array[0]);
            //int num = 12;
            //ChangeNum(ref num);
            //Console.WriteLine(num);

            //int[] array = { 33, 54 };
            //int num = 87;
            //AddElementToArray(ref array, num);
            //foreach (int item in array) 
            //{
            //    Console.WriteLine(item); 

            //int num = 15;
            //Pow(ref num);
            //Console.WriteLine(num);

            //PrintHello();

            //PrintNameAndSurname("Farkhad", "Ismiyev");

            //Console.WriteLine(SummTwoElements(1, 5));

            //Console.WriteLine(SumThreeElements(2, 3, 4));
            //Console.WriteLine(CompareTwoElements(22,3));
         }
        #region firstrecord
        private static int SumThreeElements(int k, int h, int c)
        {
           return SummTwoElements(k,h) + c;
        }

        private static int SummTwoElements(int a, int b)
        {
            return a + b;
        }
        public static bool CompareTwoElements(double num1, double num2)
        {
            if (num1 > num2)
                return true;

          return false;
        }
        

        public static void PrintHello()
        {
            Console.WriteLine("Helloo");
        }


        public static void PrintNameAndSurname(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
        #endregion

        private static void Pow( ref int num)
        {
            num = num * num;
            
        }

        public static int[] AddElementToArray(ref int[] array, int num)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            newArray[newArray.Length - 1] = num;
            array = newArray;
            return array;

        }
        private static void ChangeNum(ref int n)
        {
            n = 151;
            Console.WriteLine(n);
        }


        private static void ChangeArray(int[] numbers)
        {
            numbers[0] = 111;
            Console.WriteLine(numbers[0]);
        }

      

        #region SecondCodesInRecord
        public static int SumOfArrayElements(int[] arary)
        {
            int summa = 0;
            foreach (int numbers in arary)
                summa += numbers;
            return summa;
        }


        public static string RemoveSpace(string word)
        {
            string newWord = "";
            foreach (char letter in word)
            {
                if (letter != ' ')
                    newWord += letter;
            }
            return newWord;

        }
        public static int[] AddElementToArray(int[] numbers, int num)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
                newNumbers[i] = numbers[i];
            newNumbers[newNumbers.Length - 1] = num;
            return newNumbers;

        }
        public static void PrintArrayElements(string word, params string[] names)
        {
            foreach (string name in names)
                Console.WriteLine(name);



        }
        #endregion

        public static int Summa(int a = 32, int b = 3)
        {
            return a + b;
        }


        public static int Summa (int a, int b, int k, int l)
        {
            return a + b + k + l;
        }
        public static int Summa (int o, int e, int c)
        {
            return o + e + c;
        }





    }

}
