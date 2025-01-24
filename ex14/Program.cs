namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLineint num = Convert.ToInt32(Console.ReadLine());
" digite um numero: "); 
            for (int i = 1; i <= 10; i++)
            {
              Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

            }
    }
}
