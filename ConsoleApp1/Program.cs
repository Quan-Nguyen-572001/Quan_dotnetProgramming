using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prob1
            /*
            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("This is positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine("This is negative number");
            }
            else
            {
                Console.WriteLine("This is number 0");
            }
            */

            //prob2
            /*
            Console.Write("Input your string: ");
            string str1 = Console.ReadLine();
            int count = 0;
            foreach (char c in str1)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} vowels in the string \"{str1}\"");
            Console.ReadLine(); 
        
    
        static bool IsVowel(char c)
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    return true;
                default:
                    return false;
            }
        }
        */

            //prob3
            /*
            Console.Write("Input number: ");
            string inp = Console.ReadLine();
            string[] numblist = inp.Split(' ');
            List<int> numbers = new List<int>();
            foreach (string s in numblist)
            {
                int number;
                if (int.TryParse(s, out number))
                {
                    if (!numbers.Contains(number))
                    {
                        numbers.Add(number);
                    }
                }
            }
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            */

            //prob4
            /*
            Console.Write("Input your string: ");
            string inputStr = Console.ReadLine();
            string[] words = inputStr.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
            KeyValuePair<string, int> maxWord = wordCount.OrderByDescending(kvp => kvp.Value).First();
            Console.WriteLine($"the word that appeared the most is \"{maxWord.Key}\" and it appears {maxWord.Value}");
            Console.ReadLine();
            */

            //prob5
            /*
            Console.Write("input numbers: ");
            string input = Console.ReadLine();

            string[] inputs = input.Split(' ');
            int[] numbers = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (!int.TryParse(inputs[i],out numbers[i]))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
            Array.Sort(numbers);
            Console.WriteLine("Sort number is: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            */

            //prob6
            /*
            Console.WriteLine("Input a String: ");
            string input = Console.ReadLine();

            string result = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
                else
                {
                    result += char.ToUpper(c);
                }
            }
            Console.WriteLine("Result is: ");
            Console.WriteLine(result);
            */

            //prob7
            Console.WriteLine("Input a number: ");
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"Binary representation of {number}: {binary}");
        }
    }
}
