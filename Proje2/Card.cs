using System;

namespace Proje2
{
    class Card
    {
        
        private string header;
        private string content;
        private string member;
        private string size;

        public string Header{
            get{return this.header;}
            set{this.header = value;}
        }
        public string Content{
            get{return this.content;}
            set{this.content = value;}
        }
        public string Member{
            get{return this.member;}
            set{this.member = value;}
        }
        public string Size{
            get{return this.size;}
            set{this.size = value;}
        }

        public Card(string header, string content, string member, string size)
        {
            this.Header = header;
            this.Content = content;
            this.Member = member;
            this.Size = size;

        }
    }
}