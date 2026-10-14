namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            string input=Console.ReadLine();
            int count = 0;
            for(int i=0; i<input.Length; i++)
            {
                if (input[i] == 'a') 
                    count++;
            }
            Console.WriteLine(count);
            //finds the count of 'a' sybol in the input
        }
    }
}
