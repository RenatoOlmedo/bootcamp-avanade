using System; 

class DIO {

    static void Main(string[] args) { 

        double c = 0; 
        double S = 0;
        for (int i = 1; i <= 100; i++)
        { 
            c = (1.0/i);
            S = S + c;
        }
        var x=Math.Round(S,2);
        Console.WriteLine(x);
       
    }

}