using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Bank
    {
        public static Client[] clients;
        public static void ShowCardBalance(BankCard card) { Console.WriteLine(card.Balance); }
    }
}
