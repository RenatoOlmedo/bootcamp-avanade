using System;

namespace AppCrudSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                 switch (opcaoUsuario)
                 {
                    case "1":
                        ListarSerie();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                        VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                 }
                 opcaoUsuario = ObterOpcaoUsuario();
            }
           
        }
        private static string ObterOpcaoUsuario(){
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Séries a seu dispor!");
            System.Console.WriteLine("Informe a opção desejada:");

            System.Console.WriteLine("1- Listar séries");
            System.Console.WriteLine("2- Inserir uma nova série");
            System.Console.WriteLine("3- Atualizar série");
            System.Console.WriteLine("4- Excluir série");
            System.Console.WriteLine("5- Visualizar série");
            System.Console.WriteLine("C- Limpar tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        } 
    }
}
