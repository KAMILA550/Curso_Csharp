namespace datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro","outubro"," novembro", "dezembro"};
                
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < meses.Length; i++)
            {
               Console.WriteLine("O mês de " + meses[i] + " tem " + dias[i] + " dias."); 
            }
             string[] semana = { "domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sábado" };

            foreach(string dia in semana)
            {
                Console.WriteLine(dia);
            }
        }   */
                  int[] numeros = { 1, -2, 3, 4, 5, -6, 7, 8, 9, -10 };
             
                Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());
            Console.WriteLine();
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine( numeros.Average());





        }
    }
                   
}
