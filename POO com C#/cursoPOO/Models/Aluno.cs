namespace cursoPOO.Models
{
    public class Aluno : Pessoa
    {
        public int nota { get; set; }

        public override void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos e sou um aluno de nota {nota}");
        }
    }
}