using System;
using System.Collections.Generic;
using System.Windows.Input;
namespace Proje1
{
    public static class ContactOperation
    {
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için seçiminizi yapınız!");
            Console.WriteLine("(1) Yeni Numara Kaydet");
            Console.WriteLine("(2) Varolan Numarayı Sil");
            Console.WriteLine("(3) Varolan Numarayı Güncelle");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yap");
            Console.WriteLine("(6) Uygulamadan Çıkış Yap");
            Console.WriteLine("****************");
        }
        public static void AddContact()
        {
            Contact contact = new Contact();
            ContactModel.contactList.Add(contact);
            Program.StartApplication();
        }
        public static void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string check = Console.ReadLine();

            for(int i = 0 ; i < ContactModel.contactList.Count ; i ++)
            {
                var contact = ContactModel.contactList[i];
                if(contact.Name == check || contact.Surname == check)
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", contact.Name);
                    string confirmation = Console.ReadLine();
                    if(confirmation == "y")
                    {
                     ContactModel.contactList.Remove(contact);
                     Console.WriteLine("Kişi silinmiştir!");
                     Program.StartApplication();
                     break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edilmiştir!");
                        Program.StartApplication();
                        break;
                    }
                    
                }
                else if(i == ContactModel.contactList.Count -1)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string decision = Console.ReadLine();
                    if(decision == "1")
                    {
                        Console.WriteLine("Silme işlemi iptal edilmiştir!");
                        Program.StartApplication();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyiniz!");
                        ContactOperation.Delete();
                        break;
                    }
                }
            }
       
        }
        public static void Update()
        {
            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string check = Console.ReadLine();
            for(int i = 0 ; i < ContactModel.contactList.Count ; i ++)
            {
                var contact = ContactModel.contactList[i];
                if(contact.Name == check || contact.Surname == check)
                {
                    Console.WriteLine(" Lütfen güncellemek istediğiniz numarayı giriniz:");
                    string newNumber = Console.ReadLine();
                    Console.WriteLine("{0} isimli kişinin güncellenmesini onaylıyor musunuz ?(y/n)", contact.Name);
                    string uconfirmation = Console.ReadLine();
                    if(uconfirmation == "y")
                    {
                         contact.Number = newNumber;
                         Console.WriteLine("Kişi güncellenmiştir!");
                         Program.StartApplication();
                         break;
                    }
                    else
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        Program.StartApplication();
                        break;
                    }
                    
                }
                else if(i == ContactModel.contactList.Count -1)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi  sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string uDecision = Console.ReadLine();
                    if(uDecision == "1")
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        Program.StartApplication();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyiniz!");
                        Update();
                        break;
                    }
                }
                
            }
        }
        public static void Listing()
        {
            Console.WriteLine("Telefon Rehberi");
            foreach(var contact in ContactModel.contactList)
            {
                contact.Yazdır();
            }
            Program.StartApplication();
        }
        public static void Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string sDecision = Console.ReadLine();
            if(sDecision == "1")
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                string scheck = Console.ReadLine();
                foreach(var item in ContactModel.contactList)
                {
                    if(item.Name == scheck || item.Surname == scheck)
                    {
                        item.Yazdır();                             
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                string snum = Console.ReadLine();
                foreach(var item in ContactModel.contactList)
                {
                    if(item.Number == snum)
                    {
                        item.Yazdır();                                 
                    }
                }
            }
            Program.StartApplication();
        }

        public static void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}

