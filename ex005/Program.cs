namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            double nota2= double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine($ a media do aulo e:{ media});
        }
    }
}
