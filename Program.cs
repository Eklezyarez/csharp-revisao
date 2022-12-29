using Syste;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "0"){
                switch (opcaoUsuario)
                {
                    case "1":
                        // Adcionar aluno
                    break;

                    case "2":
                        // Listar alunos
                    break;

                    case "3":
                        // calcular media geral
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

         

            opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOcaoUsuario(){

            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }


    }
    
}
