using System;

namespace Proje1
{
    public class Contact : IContact
    {
        private string name;
        private string surname;
        private string number;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }
        public string Number
        {
            get { return number; }
            set { this.number = value; }
        }

        public Contact(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }

        
        public Contact()
        {
            Console.WriteLine("Lütfen isim giriniz             :");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string number = Console.ReadLine();

            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            
            Console.WriteLine("Kişi kaydedilmiştir!");
        }
        
        public void Yazdır()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim: {0}",this.Name);
            Console.WriteLine("Soyisim: {0}",this.Surname);
            Console.WriteLine("Numara: {0}",this.Number);
            Console.WriteLine("-");
        }

    }


}