using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll :   {total}");

            if(total >= 14) {
                Console.WriteLine("You win");
            } else if (total == 13) {
                Console.WriteLine("Draw");
            } else {
                Console.WriteLine("You lose");
            }
        }
    }
}
