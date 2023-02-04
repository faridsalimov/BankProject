using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class BankCard
    {
        public string? Bankname { get; set; }
        public string? Fullname { get; set; }
        public string? PAN { get; set; }
        public string? PIN { get; set; }
        public string? ExpireDate { get; set; }
        public decimal Balance { get; set; }

        Random random = new Random();

        private int cvc;

        public int CVC
        {
            get { return cvc; }
            set { cvc = random.Next(100, 999); }
        }

        public BankCard(string? bankname, string? fullname, string? pan, string? pin, string? expiredate, decimal balance)
        {
            Bankname = bankname;
            Fullname = fullname;
            PAN = pan;
            PIN = pin;
            ExpireDate = expiredate;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"BankName: {Bankname}\nFullName: {Fullname}\nPAN: {PAN}\nPIN: {PIN}\nBalance: {Balance}\nExperied Date: {ExpireDate}";
        }

        public void IncreaseBalance(decimal money)
        {
            Balance += money;
            Console.WriteLine($"Successfully added {money} AZN to the card!");
        }

        public void DecreaseBalance(decimal money)
        {
            if (Balance >= money)
            {
                Balance -= money;
            }

            else throw new Exception("There is not enough balance.\n");
        }
    }
}