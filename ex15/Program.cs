namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genro;

            Console.WriteLine("Digite o gênero: ");
            genro = Console.ReadLine().ToUpper();

            while(genro != "F" && genro != "M")
            {
                Console.WriteLine("Digite o gênero: ");
                genro = Console.ReadLine();
            }
            Console.WriteLine("bem vindos(a)");
        } 

    }
}
