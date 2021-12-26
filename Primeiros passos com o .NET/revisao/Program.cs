using System;

namespace revisao
{
    class Program
    {      
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int i = 0;
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
                           
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            a.Nota = nota;
                        }
                        else{
                            throw new ArithmeticException("O valor da nota deve ser decimal");
                        }
                        alunos[i] = a;
                        i++;

                        break;
                    case "2":
                        foreach(var j in alunos){
                            if(!string.IsNullOrEmpty(j.Nome)){
                                Console.WriteLine($"Nome do Aluno:{j.Nome} Nota do Aluno:{j.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal soma = 0;
                        int nrAluno = 0;
                        for (int z=0; z<alunos.Length; z++){
                            if(!string.IsNullOrEmpty(alunos[z].Nome)){
                                soma = soma + alunos[z].Nota;
                                nrAluno++;
                            }     
                        }
                        Console.WriteLine("A média geral é:"+ (soma/nrAluno));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine();
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

            string op1 = Console.ReadLine();
            return op1;
        }
    }
}
