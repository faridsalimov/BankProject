using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public BankCard? BankAccount { get; set; }

        public Client(int id, string? name, string? surname, int age, decimal salary, BankCard? bankaccount)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            BankAccount = bankaccount;
        }

        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name} \nSurname: {Surname} \nAge: {Age} \nSalary: {Salary} \n\nBankAccount:\n{BankAccount}";
        }
    }
}