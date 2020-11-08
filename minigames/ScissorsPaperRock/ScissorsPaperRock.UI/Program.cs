using ScissorsPaperRock.BL;
using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;

namespace ScissorsPaperRock.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = ConfigureUser();
            Computer computer = ConfigureComputer();

            Console.WriteLine("Welcome to Scissors Paper Rock a shitty game i made because i was bored");

            // game loop
            while(true)
            {
                Console.WriteLine("How many rounds do you want to play?");
                string input = Console.ReadLine();
                try
                {
                    int rounds = int.Parse(input);

                    for(int i = 0; i < rounds; i++)
                    {
                        Console.WriteLine("Enter 1 for scissors, 2 for paper, and 3 for rock.");
                        string moveInput = Console.ReadLine();
                        int move = int.Parse(moveInput);

                        user.GetPlayerMove(move);
                        Console.WriteLine($"You chose {user.CurrentPlayerMove.GetType().Name}");
                        Random rnd = new Random();
                        computer.GetPlayerMove(rnd.Next(1,3));
                        Thread.Sleep(1000);
                        Console.WriteLine($"The computer chose {computer.CurrentPlayerMove.GetType().Name}\n");
                    }
                    break;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static User ConfigureUser()
        {   
            User user = new User();
            user.AddMove(new Scissors());
            user.AddMove(new Paper());
            user.AddMove(new Rock());

            foreach (IMove move in user.MovesPlayerCanMake)
            {
                switch (move.NumericalValue)
                {
                    case 1:
                        move.MoveThatCurrentMoveWillLoseTo = new Rock();
                        break;

                    case 2:
                        move.MoveThatCurrentMoveWillLoseTo = new Scissors();
                        break;

                    case 3:
                        move.MoveThatCurrentMoveWillLoseTo = new Paper();
                        break;
                }
            }
            return user;
        }

        public static Computer ConfigureComputer()
        {
            Computer computer = new Computer();
            computer.AddMove(new Scissors());
            computer.AddMove(new Paper());
            computer.AddMove(new Rock());

            foreach (IMove move in computer.MovesPlayerCanMake)
            {
                switch (move.NumericalValue)
                {
                    case 1:
                        move.MoveThatCurrentMoveWillLoseTo = new Rock();
                        break;

                    case 2:
                        move.MoveThatCurrentMoveWillLoseTo = new Scissors();
                        break;

                    case 3:
                        move.MoveThatCurrentMoveWillLoseTo = new Paper();
                        break;
                }
            }
            return computer;
        }
    }
}