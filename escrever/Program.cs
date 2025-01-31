namespace escrever
{
    internal class Program
    {
        static void escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new string('*', tam);
            string textocentralizado = texto.PadLeft(tam -2).PadLeft(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textocentralizado);
            Console.WriteLine(linha);

        }



        static void Main(string[] args)
        {
            escrever("kamila gomes de araujo");
            Console.WriteLine();
            escrever("ola");
            Console.WriteLine();
            escrever("bom dia");
            Console.WriteLine();
        }
    }
}
