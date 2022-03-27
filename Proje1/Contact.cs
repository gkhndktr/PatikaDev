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


        public Contact(string name)
        {
            this.Name = name;

        }

        public void Yazdır(string name)
        {
            Console.WriteLine("{0} kaydedilmiştir.", this.Name);
        }

    }


}