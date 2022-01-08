using System; 

class DIO {

    static void Main(string[] args) { 

     string str;
            while((str=Console.ReadLine())!= null)
            {
                if (int.Parse(str)>100 || int.Parse(str)<0 )
                {
                       
                }
                else          //Escreva o seu código nos espaços em branco
                { 
                    int x = int.Parse(str);
                    if (str != "0")
                    {
                    Console.WriteLine("vai ter duas!"); 
                    }
                    else
                    {
                        Console.WriteLine("vai ter copa!");
                    }
                }
            }

    }

}