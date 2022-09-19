// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[25];
        Random rnd = new Random();
        long sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-10, 25);
            sum = sum + array[i];

            Console.WriteLine("Сумма = {0}", sum);
        }

        
    }
}

