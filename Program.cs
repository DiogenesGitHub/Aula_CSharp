using System.Diagnostics.Contracts;

namespace Aprendento_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIAR A VARIAVEL QUE VAI RECEBER A ESCOLHA DO CLIENTE
            int select = 0;
            bool confirm = false;

            //CRIA UM MENU PARA QUE O CLIENTE ESCOLHA O QUE DESEJA FAZER
            Console.WriteLine("||        || ||||||| ||     || ||   ||");
            Console.WriteLine("||||    |||| ||      ||||   || ||   ||");
            Console.WriteLine("|| ||  || || ||||||| ||  || || ||   ||");
            Console.WriteLine("||  ||||  || ||      ||    ||| ||   ||");
            Console.WriteLine("||   ||   || ||||||| ||     || |||||||");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("| Exemplo de CRUP em memorio          |");
            Console.WriteLine("| 1 - Cadastrar Pesssoa               |");
            Console.WriteLine("| 2 - Editar Pessoa                   |");
            Console.WriteLine("| 3 - Deletar Pessoa                  |");
            Console.WriteLine("| 4 - Consultar Pessoa                |");
            Console.WriteLine("| 5 - Consultar Lista                 |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("Digito o numero da opção que você deseja:");

            //RECUPERA OS DADOS QUE O CLIENTE ESCOLHEU
            select = int.Parse(Console.ReadLine());

            //CONFIRME QUE O CLIENTE ESCOLHE O QUE DESEJAVA
            Console.WriteLine($"Você escolhe a opção: {0}", select);
            Console.WriteLine("Confirma (Y/N)");

            //VERIFIQUE SE A RESPOTA DO CLIENTE FOI Y - SIM OU N - NÃO
            if (Console.ReadLine().ToUpper() == "Y")
            {
                confirm = true;
            }

            //A CONFIRMAÇÃO SENDO POSITIVA UTILIZE A SWITCH PARA TRATRAR AS ESCOLHAS
            if (confirm)
            {
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Você escolheu cadastrar uma pessoa.");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu editar uma pessoa.");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu deletar uma pessoa.");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu consultar uma pessoa.");
                        break;
                    case 5:
                        Console.WriteLine("Você escolheu consultar a lista.");
                        break;
                    default:
                        Console.WriteLine("Você não esconlheu uma opção valida.");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Você não escolheu a opção corretar por favor reinicio o programa.");
            }
        }
    }
}