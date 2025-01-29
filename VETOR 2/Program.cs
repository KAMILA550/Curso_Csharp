using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace VETOR_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Maria", "João", "José", "Pedro", "Ana", "Carlos", "Antônio", "Francisco", "Paulo", "Luiz" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                    Console.WriteLine(nomes[i] + ",");
            }
           else
            {
                Console.WriteLine(nomes[i] + ".");
            }

        }
    }
}
