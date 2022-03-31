using System;
using System.Collections.Generic;
using System.Windows.Input;
namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage();
            List<Contact> contactList = new List<Contact>();
            while(true)
            {
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Lütfen isim giriniz             :");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz          :");
                    string Surname = Console.ReadLine();
                    Console.WriteLine("Lütfen telefon numarası giriniz :");
                    string Number = Console.ReadLine();
                    Contact contact = new Contact(Name, Surname, Number);
                    contactList.Add(contact);
                    Console.WriteLine("Kişi kaydedilmiştir!");
                    Console.WriteLine(contact.Name);
                    Console.WriteLine(contact.Surname);
                    Console.WriteLine(contact.Number);
                    Manage();

                    break;
                case "2":
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string check = Console.ReadLine();
                    foreach(var item in contactList)
                    {
                        Console.WriteLine(item.Name);
                        if(item.Name == check || item.Surname == check)
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.Name);
                            string confirmation = Console.ReadLine();
                            if(confirmation == "y")
                            {
                             contactList.Remove(item);
                             Console.WriteLine("Kişi silinmiştir!");
                             Manage();
                             break;
                            }
                            else
                            {
                                Console.WriteLine("Program sonlandırılmıştır.");
                                Manage();
                                break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            string decision = Console.ReadLine();
                            if(decision == "1")
                            {
                                Console.WriteLine("Program sonlandırılmıştır.");
                                Manage();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tekrar deneyiniz!");
                                Manage();
                                break;
                            }
                        }
                    }

                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "5":
                    
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
        }
        }
        
        static void Manage()
        {
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("****************");
        }
    }
}