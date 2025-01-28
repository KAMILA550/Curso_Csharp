namespace senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "1234"; // senha correta
            string senhaDigitada; // senha digitada pelo usuário
            int tentativas = 0; // contador de tentativas

            // loop para solicitar a senha ao usuário

            do
            {
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++; // incrementa o contador de tentativas

                // verifica se a senha digitada é diferente da senha correta 
                if (senhaDigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!!");
                    Console.WriteLine(" você tem mais " + (3 - tentativas) + " tentativas"); 
                    Console.ReadKey(); 
                }
                else if(senhaDigitada != senha && tentativas ==3 )
                {
                    Console.WriteLine("Senha incorreta! seu acesso foi bloqueado");
                    return;
                }
            } while (senhaDigitada != senha);

            Console.Clear();
            Console.WriteLine("Senha correta! - Tentativas: " + tentativas );
        }    
}
    }    
