using System;
using System.Collections.Generic;
namespace Proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> TeamMembers = new Dictionary<string, string>();

            TeamMembers.Add("Gökhan", "1");
            TeamMembers.Add("Deniz", "2");
            TeamMembers.Add("Derya", "3");

            Card firstCard =new Card("Programming Language", "Learn C#", "Gökhan", "1");
            Card secondCard =new Card("Programming Language", "Learn C#", "Deniz", "1");
            Card thirdCard =new Card("Programming Language", "Learn C#", "Derya", "1");

            Board.ToDoList.Add(firstCard);
            Board.ToDoList.Add(secondCard);
            Board.ToDoList.Add(thirdCard);

            Console.WriteLine("Please choose one of below options to continue:)");
            Console.WriteLine("  *******************************************");
            Console.WriteLine("(1) Board Listing");
            Console.WriteLine("(2) Add a card to the board");
            Console.WriteLine("(3) Delete a cart from the board");
            Console.WriteLine("(4) Move a cart");

            string option = Console.ReadLine();

            Console.WriteLine(option);


            switch(option)
            {
                case "1":
                    CardOperation.Listing();
                    break;
                case "2":
                    CardOperation.AddCard();
                    break;
                case "3":
                    //CardOperation.Delete();
                    break;
                case "4":
                    //CardOperation.Move();
                    break;
            }
        }
    }
}
