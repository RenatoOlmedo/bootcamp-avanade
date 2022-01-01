using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();

            //Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Subtrair);
            // op += Calculadora.Somar;

            // op.Invoke(10,10);
            //op(10,10);
            
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Pessoa p1 = new Pessoa("Renato ", "Olmedo");
            // p1.Apresentar();

            // Aluno a = new Aluno("Renato", "Olmedo", "ADS");
            // a.Apresentar();

            // Data d = new Data();
            // d.SetMes(2);
            // d.ApresentarMes();

            
        }
    }
}
