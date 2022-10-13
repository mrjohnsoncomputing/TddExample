namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var grandTotal = 0;
            var numbers = new Dictionary<string, string>();
            numbers.Add("1", "one");
            numbers.Add("2", "two");
            numbers.Add("3", "three");
            numbers.Add("4", "four");
            numbers.Add("5", "five");
            numbers.Add("6", "six");
            numbers.Add("7", "seven");
            numbers.Add("8", "eight");
            numbers.Add("9", "nine");

            var prefixes = new Dictionary<string, string>();
            prefixes.Add("2", "twen");
            prefixes.Add("3", "thir");
            prefixes.Add("4", "for");
            prefixes.Add("5", "fif");
            prefixes.Add("6", "six");
            prefixes.Add("7", "seven");
            prefixes.Add("8", "eigh");
            prefixes.Add("9", "nine");

            var suffixes = new Dictionary<string, string>();
            //suffixes.Add("0", "ty");
            suffixes.Add("1", "teen");
            for (int i = 2; i < 10; i++)
                suffixes.Add(i.ToString(), "ty");

            for (int i = 1; i < 10; i++)
            {
                var word = "";
                var number = i.ToString();
                var charCount = number.Length;
                if (charCount == 1)
                {
                    word = numbers[number];
                }
                else if (charCount == 2)
                {
                    var tens = number[0].ToString();
                    var units = number[1].ToString();
                    if (units == "0")
                    {
                        if (i == 10) word = "ten"; else word = prefixes[tens] + suffixes[tens];

                    }
                }
                else if (charCount == 3)
                { 
                    var hundreds = number[0].ToString();
                    var tens = number[1].ToString();
                    var units = number[2].ToString();

                    word += numbers[hundreds] + " hundred and ";
                }
                var total = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] != ' ')
                    {
                        total++;
                    }
                }
                grandTotal += total;
            }
            Console.WriteLine(grandTotal);
        }
    }
}