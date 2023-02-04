using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class User
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public BankCard? BankCard { get; set; }

        public User(string? name, string? surname, BankCard? bankCard)
        {
            Name = name;
            Surname = surname;
            BankCard = bankCard;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nBankCard: {BankCard.PAN}\n";
        }
    }
}