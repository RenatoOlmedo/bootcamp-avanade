namespace cursoPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos e recebo {Salario}");
        }
    }
}