using System; 

class DIO {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());
        if ((x + 1)%2 == 0)
        {
            System.Console.WriteLine(x+1);
        }
        else
        {
            System.Console.WriteLine(x+2);
        }
    }

}