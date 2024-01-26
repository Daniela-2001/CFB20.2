namespace aula20._2
{
    internal class Program
    {
        static void Main()
        {
            int[] num = new int[10];

            int i = 9;
            while(i>0)
            {
                num[i] = 0;
                Console.WriteLine(num[i]);
                i--;
            }

            Console.WriteLine("\nFim do loop");
        }
    }
}