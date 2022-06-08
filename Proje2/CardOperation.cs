using System;

namespace Proje2
{
    public class CardOperation
    {
        public static void Listing()
        {
            Console.WriteLine(" TODO Line");
            Console.WriteLine("************************");
            if (Board.ToDoList.Count > 0)
            {
                foreach (var card in Board.ToDoList)
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
            if (Board.InProgressList.Count > 0)
            {
                foreach (var card in Board.InProgressList)
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
            if (Board.DoneList.Count > 0)
            {
                foreach (var card in Board.DoneList)
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
            Program.StartApplication();
        }
        public static void AddCard()
        {
            Console.WriteLine("Please enter card heaer");
            string header = Console.ReadLine();

            Console.WriteLine("Please enter contents");
            string contents = Console.ReadLine();

            Console.WriteLine("Please enter member ID");
            int memberId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Plese enter size of the card");
            int size = Int32.Parse(Console.ReadLine());

            Card newCard = new Card(header, contents, memberId, size);
            Console.WriteLine(newCard);

            Board.ToDoList.Add(newCard);

            Program.StartApplication();
        }
        public static void Delete()
        {
            Console.WriteLine("Please provide card header for delete transaction!");

            string header = Console.ReadLine();
            bool found = false;
            foreach(var card in Board.ToDoList.ToArray())
            {
                if(card.Header == header)
                {
                    Board.ToDoList.Remove(card);
                    found = true;
                    Console.WriteLine("Card with header {0} is successfully deleted", header);
                }
            }
            foreach(var card in Board.InProgressList.ToArray())
            {
                if(card.Header == header)
                {
                    Board.ToDoList.Remove(card);
                    found = true;
                    Console.WriteLine("Card with header {0} is successfully deleted", header);
                }
            }
            foreach(var card in Board.DoneList.ToArray())
            {
                if(card.Header == header)
                {
                    Board.ToDoList.Remove(card);
                    found = true;
                    Console.WriteLine("Card with header {0} is successfully deleted", header);
                }
            }
            
            if(!found)
            {
                Console.WriteLine("No result is found with the provided header! Please select an option to continue.");
                Console.WriteLine("1- Abort delete progress");
                Console.WriteLine("2- Try again");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    Program.StartApplication();
                }
                else
                {
                    Delete();
                }
            }

        }


    }
}