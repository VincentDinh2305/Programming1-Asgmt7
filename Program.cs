using System;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            Array.Reverse(numbers);
            FourOne(numbers);            
        }

        static void FourOne(int[] toFour)
        {
            foreach (var x in toFour)
            {
                Console.Write($"{x}  ");
            }
        }      

    }
}
