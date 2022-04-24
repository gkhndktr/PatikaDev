using System;
using System.Collections.Generic;
using System.Windows.Input;
namespace Proje1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Predefined contacts
            ContactModel.contactList.Add(new Contact("Zinedine", "Zidane", "555"));
            ContactModel.contactList.Add(new Contact("Christiano", "Ronaldo", "444"));
            ContactModel.contactList.Add(new Contact("Diego", "Maradona", "333"));
            ContactModel.contactList.Add(new Contact("Peter", "Schmeichel", "222"));
            ContactModel.contactList.Add(new Contact("Mahmut", "Tuncer", "111"));

            StartApplication();
        }
        
        public static void StartApplication()
        {
            ContactOperation.Menu();
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    ContactOperation.AddContact();
                    break;
                case "2":
                    ContactOperation.Delete();
                    break;
                case "3":
                    ContactOperation.Update();
                    break;
                case "4":
                    ContactOperation.Listing();
                    break;
                case "5":
                    ContactOperation.Search();
                    break;
                case "6":
                    ContactOperation.Exit();
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    ContactOperation.Menu();
                    break;
            }
        }
    }
}