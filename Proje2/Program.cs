using System;
using System.Collections.Generic;

namespace Proje2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Member firstMember = new Member("Gökhan", "Döktür", 1);
            Member secondMember = new Member("Deniz", "Döktür", 2);
            Member thirdMember = new Member("Derya", "Döktür", 3);

            MemberModel.distribution.Add(firstMember);
            MemberModel.distribution.Add(secondMember);
            MemberModel.distribution.Add(thirdMember);

            Card firstCard = new Card("Programming Language", "Learn C#", 1, 1);
            Card secondCard = new Card("Programming Language", "Learn C#", 2, 1);
            Card thirdCard = new Card("Programming Language", "Learn C#", 3, 1);

            Board.ToDoList.Add(firstCard);
            Board.ToDoList.Add(secondCard);
            Board.ToDoList.Add(thirdCard);
            
            StartApplication();
        }

        public static void StartApplication()
        {


            Console.WriteLine("Please choose one of below options to continue:)");
            Console.WriteLine("  *******************************************");
            Console.WriteLine("(1) Board Listing");
            Console.WriteLine("(2) Add a card to the board");
            Console.WriteLine("(3) Delete a cart from the board");
            Console.WriteLine("(4) Move a cart");

            string option = Console.ReadLine();

            Console.WriteLine(option);


            switch (option)
            {
                case "1":
                    CardOperation.Listing();
                    break;
                case "2":
                    CardOperation.AddCard();
                    break;
                case "3":
                    CardOperation.Delete();
                    break;
                case "4":
                    //CardOperation.Move();
                    break;
            }
        }
    }


}
