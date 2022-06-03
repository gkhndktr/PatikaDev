using System;

namespace Proje2
{
    public class CardOperation
    {
        public static void Listing()
        {
            
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