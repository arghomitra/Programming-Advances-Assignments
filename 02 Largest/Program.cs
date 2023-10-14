namespace _02_Largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split(" ");
           int[] numbers = new int[input.Length];
           for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

           Random random = new Random();
            bool shuffel = true;
            int count = 0;
            
            while (count != 36)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (random.NextDouble() < 0.5)
                        {
                            int temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }





                    }
                }

            }
            string largest = 0;
            foreach (int i in numbers)
            {
                Console.Write(i);
            }

        }
    }
}