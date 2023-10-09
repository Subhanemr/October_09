namespace Task09_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            restart:
            Console.WriteLine("Metni daxil edin:");
            string input = Console.ReadLine().ToLower().Trim();
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            if (input.Length <= 0)
            {
                Console.WriteLine("Sehv input daxil edibsiz");
                goto restart;
            }
            foreach (string word in words)
            {
                result += Capitalize(word) + " ";
            }
            Console.WriteLine(result);
        }
        static string Capitalize(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            chars[0] = char.ToUpper(chars[0]);

            return new string(chars);
        }
    }
}