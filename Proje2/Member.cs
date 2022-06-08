using System;
using System.Collections.Generic;

namespace Proje2
{
    public class Member
    {
        private string firstName;
        private string lastName;
        private int id;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }
        public Member(string firstname, string lastname, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }



    }
    public static class MemberModel
    {
        public static List<Member> distribution = new List<Member>();
    }
}