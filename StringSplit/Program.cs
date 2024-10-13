namespace StringSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char separator = ' ';
            string Text = "Съешь ещё этих мягких французских булок, да выпей чаю.";
            string[] words = Text.Split(separator);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
