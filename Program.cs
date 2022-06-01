using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a firsts word!: ");
            string FirstWowrd = Console.ReadLine();
            int score1 = functioncounter(FirstWowrd);
            Console.WriteLine("Enter a firsts word!: ");
            string SecondWowrd = Console.ReadLine();
            int score2 = functioncounter(SecondWowrd);
            if (score1 > score2)
            {
                Console.WriteLine("First player win !!!");
            }
            else if (score1 < score2)
            {
                Console.WriteLine("Second player win !!!");
            }
            else
            {
                Console.WriteLine("Pobedila drujba!!!");
            }

        }

        static public int functioncounter(string word)
        {
            int[] points = {1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10};
            int scores = 0;
            int index = 0;
            string wordLower = word.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                if (wordLower[i] >= 97 && wordLower[i] <= 122)
                {
                    index = wordLower[i] - 97;
                    scores += points[index];
                }
            }

            return scores;
        }
        
        
       
    }
}