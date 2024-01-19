namespace exerciseFileAddedFromInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"mytext";
            string[] ArrLines;

            Console.WriteLine("Adding a text file: \n");
            Console.WriteLine("--------------------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.WriteLine("Input how many lines u wish:");
            int n = int.Parse(Console.ReadLine());
            ArrLines = new string[n];
            Console.WriteLine($" Input {n} strings below: \n");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Input line {i+1}");
                ArrLines[i] = Console.ReadLine();
            }

            File.WriteAllLines(fileName, ArrLines);

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine("Here is the content of the added text lines:");

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }
    }
}
