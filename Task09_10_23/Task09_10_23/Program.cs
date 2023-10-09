using System.Globalization;
using System.Text;

namespace Task09_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metod 1
            //restart:
            //Console.WriteLine("Metni daxil edin:");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //string result = "";
            //if (input.Length <= 0)
            //{
            //    Console.WriteLine("Sehv input daxil edibsiz");
            //    goto restart;
            //}
            //foreach (string word in words)
            //{
            //    result += Capitalize(word) + " ";
            //}
            //Console.WriteLine(result);

            //Metod 2
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            string formattedSentence = FormatSentence(input);
            Console.WriteLine("Formatlashdirilmish: " + formattedSentence);

        }

        //Metod 2
        public static string FormatSentence(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            input = input.Trim();
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }

            string[] words = input.Split(' ');

            if (words.Length == 0)
                return string.Empty;

            StringBuilder formattedSentence = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    formattedSentence.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ");
                }
            }

            formattedSentence.Length--;

            return formattedSentence.ToString();
        }

        //Metod 1
        static string Capitalize(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            chars[0] = char.ToUpper(chars[0]);

            return new string(chars);
        }
    }
}
