using System;

namespace revisao
{
    class Program
    {
        Aluno[] alunos = new Aluno[5];
        static void Main(string[] args)
        {
            string op = opcaoUsuario();

            while (op.ToUpper() != "X")
            {
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");     
                        Aluno a = new Aluno();
                        a.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");     
                        a.Nota = decimal.Parse(Console.ReadLine());

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                op = opcaoUsuario();
            }
        }

        private static string opcaoUsuario()
        {
            Console.WriteLine("---------Menu---------");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine("----------------------");

            string op = Console.ReadLine();
            Console.WriteLine();
            return op;
        }
    }
}
