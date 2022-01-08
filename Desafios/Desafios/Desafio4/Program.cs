using System; 

class DIO {

    static void Main(string[] args) { 

            for (int i = 1; i <= 9; i = i +2)
            {
                for (int j = 7; j > 4; j--)
                {
                    Console.WriteLine($"I={i} j={j}");
                }
            }
    }

}