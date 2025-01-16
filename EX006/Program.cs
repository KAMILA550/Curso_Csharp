namespace EX006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media, n1, n2;

            Console.WriteLine("digite a primeira nota: ");
                n1 = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine(" digite a segunda nota:");
            n2 = Convert.ToDouble (Console.ReadLine());
            media = (n1 + n2) / 2;
            Console.WriteLine( " a media é: {0}", media ); 
        }
    }
}
