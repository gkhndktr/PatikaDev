using System;
using System.Collections.Generic;
using System.Windows.Input;
namespace Proje1
{
    public static class ContactOperation
    {
        public static void Menu()
        {
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Uygulamadan Çıkış Yap");
            Console.WriteLine("****************");
        }
        public static void AddContact()
        {
            Contact contact = new Contact();
            ContactModel.contactList.Add(contact);
            Menu();
        }
        public static void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string check = Console.ReadLine();
            foreach(var contact in ContactModel.contactList)
            {
                if(contact.Name == check || contact.Surname == check)
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", contact.Name);
                    string confirmation = Console.ReadLine();
                    if(confirmation == "y")
                    {
                     ContactModel.contactList.Remove(contact);
                     Console.WriteLine("Kişi silinmiştir!");
                     Menu();
                     break;
                    }
                    else
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        Menu();
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
                        Menu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyiniz!");
                        Menu();
                        break;
                    }
                }
            }
       
        }
        public static void Update()
        {
            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string cName = Console.ReadLine();
            foreach(var uName in ContactModel.contactList)
            {
                if(uName.Name == cName || uName.Surname == cName)
                {
                    Console.WriteLine(" Lütfen güncellemek istediğiniz numarayı giriniz:");
                    string newNumber = Console.ReadLine();
                    Console.WriteLine("{0} isimli kişinin güncellenmesini onaylıyor musunuz ?(y/n)", uName.Name);
                    string uconfirmation = Console.ReadLine();
                    if(uconfirmation == "y")
                    {
                         uName.Number = newNumber;
                         Console.WriteLine("Kişi güncellenmiştir!");
                         Menu();
                         break;
                    }
                    else
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        Menu();
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi  sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string uDecision = Console.ReadLine();
                    if(uDecision == "1")
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        Menu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyiniz!");
                        Menu();
                        break;
                    }
                }
                
            }
        }
        public static void Listing()
        {
            Console.WriteLine("Telefon Rehberi");
            foreach(var item in ContactModel.contactList)
            {
                item.Yazdır();
            }
            Menu();
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

            Menu();
        }
        public static void WhatNext()
        {
            Console.WriteLine("(1) Yeni bir işlem yap");
            Console.WriteLine("(2) Uygulamadan Çık");
            Console.WriteLine("****************");
            string uDecision = Console.ReadLine();
            if(uDecision == "1")
            {
                Program.StartApplication();
            }
            else
            {
                Exit();
            }
        }
        public static void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}

