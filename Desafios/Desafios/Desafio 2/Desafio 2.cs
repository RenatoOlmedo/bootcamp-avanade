using System; 

class DIO {

    static void Main(string[] args) { 

    int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
                if (i%2 ==0)
                {
                    //System.Console.WriteLine(Math.Pow(i,2));  
                    {
                    int b = 2;          //escreva o seu código nos espaços em branco
                    double resultado = Math.Pow(i,b);
                    Console.WriteLine($"{i}^2 = {resultado}");
                }
            }
        }    
    }

}
