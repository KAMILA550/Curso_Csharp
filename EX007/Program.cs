using System.ComponentModel.Design;

namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 100;
            string resultado;

            if (nota_final >= 60)
            {
                if (nota_final >= 90 )
                {
                    resultado = " aprovado com louvor";

                }
             else
                {
                   resultado = "aprovado";
                }
                if (nota_final >= 40)
                {
                    resultado = "recuperação";
                }
                 
            }
          
       
            else
            {
                resultado = "reprovado";
            }




            Console.WriteLine( "nota do aluno: {0} - resultado: {1}", nota_final , resultado);
        }
    }
}
