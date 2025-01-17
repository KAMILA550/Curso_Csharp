using System.ComponentModel.Design;

namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 50;
            string resultado;

            if (nota_final >= 60)
            {
                resultado = " aprovado";
            }
            else if (nota_final >= 40)
            {
                resultado = "recuperaçao";
            }
            else
            {
                resultado = "reprovado";
            }




            Console.WriteLine("o aluno foi {0}.", resultado);
        }
    }
}
