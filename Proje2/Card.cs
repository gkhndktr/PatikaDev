using System;

namespace Proje2
{

    public class Card
    {

        private string header;
        private string content;
        private int member;
        private SizeEnum size;

        public string Header
        {
            get { return this.header; }
            set { this.header = value; }
        }
        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }
        public int Member
        {
            get { return this.member; }
            set
            {
                var list = MemberModel.distribution;
                int totalCount = list.Count;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == value)
                    {
                        this.member = value;
                        break;
                    }
                    else if (i == totalCount - 1)
                    {
                        Console.WriteLine("You have provided invalid user information. Please try again!");
                    }
                }

            }
        }
        public SizeEnum Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public Card(string header, string content, int member, int size)
        {
            this.Header = header;
            this.Content = content;
            this.Member = member;
            this.Size = (SizeEnum)size;

        }
        public enum SizeEnum
        {
            XS,
            S,
            M,
            L,
            XL
        }
    }
}