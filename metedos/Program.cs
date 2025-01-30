using System.Runtime.Serialization;

namespace metedos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            saudacao("kamila"); // chamando o metodo saudaçao

            soma(10, 20); // 
        }

        static void saudacao(string nome)
        {
            Console.WriteLine($"Olá{nome}, seja bem vindo!");
        }

        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
            Console.WriteLine(" a soma de {0} + {1} é igual a {2}.", a, b, resultado);
            Console.WriteLine("a soma de " + a + " + " + b + " é igual a " + resultado + ".");
        }
    }   }
