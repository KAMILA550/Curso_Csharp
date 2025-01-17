using System.ComponentModel.Design;

namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("digite a primeira  nota final do aluno: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a segunda  nota final do aluno: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a terceira   nota final do aluno: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a quarta  nota final do aluno: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;






            if (nota_final >= 60)
            {
                if (nota_final >= 90)
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
