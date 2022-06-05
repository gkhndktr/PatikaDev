using System;

namespace Proje2
{
    public class CardOperation
    {
        public static void Listing()
        {
            Console.WriteLine(" TODO Line");
            Console.WriteLine("************************");
            if(Board.ToDoList.Count > 0)
            {
                foreach(var card in Board.ToDoList)
                {
                    Console.WriteLine(card.Header);
                    Console.WriteLine(card.Content);
                    Console.WriteLine(card.Member);
                    Console.WriteLine(card.Size);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("BOŞ");
                Console.WriteLine();
            }

            Console.WriteLine(" IN PROGRESS Line");
            Console.WriteLine("************************");
            if(Board.InProgressList.Count > 0)
            {
                foreach(var card in Board.InProgressList)
                {
                    Console.WriteLine(card.Header);
                    Console.WriteLine(card.Content);
                    Console.WriteLine(card.Member);
                    Console.WriteLine(card.Size);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("BOŞ");
                Console.WriteLine();
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if(Board.DoneList.Count > 0)
            {
                foreach(var card in Board.DoneList)
                {
                    Console.WriteLine(card.Header);
                    Console.WriteLine(card.Content);
                    Console.WriteLine(card.Member);
                    Console.WriteLine(card.Size);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("BOŞ");
                Console.WriteLine();
            }

        }
        public static void AddCard()
        {
            Console.WriteLine("Please enter card heaer");
            string header = Console.ReadLine();

            Console.WriteLine("Please enter contents");
            string contents = Console.ReadLine();

            Console.WriteLine("Please enter person name");
            string name = Console.ReadLine();
            
            Console.WriteLine("Plese enter size of the card");
            string size = Console.ReadLine();
            
            Card newCard =new Card(header, contents, name, size);
            Console.WriteLine(newCard);

            Board.ToDoList.Add(newCard);
        }

        
    }
}