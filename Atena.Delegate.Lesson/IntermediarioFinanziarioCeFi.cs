using Atena.Delegate.Lesson.Interfaces;
using System;
using System.Collections.Generic;

namespace Atena.Delegate.Lesson
{
    public abstract class IntermediarioFinanziarioCeFi : IFinancialServices
    {
        public List<Client> _clients;
        public List<Account> _accounts;

        public void CreateAccount(Person p)
        {
            long number = new Random().Next(10000,1000000);
            Client c = new Client(p) { _AccountNumber = number };
            _clients.Add(c);
        }
        // public abstract void CreateAccount2(Person p);
        public IntermediarioFinanziarioCeFi()
        {
            _clients = new List<Client>();
        }
        public abstract void Withdraw();
        public abstract void Deposit();
        public abstract void CheckAccount();
    }
    public class Bank : IntermediarioFinanziarioCeFi, IInternationalBank
    {
        string _name;
        public Bank(string Name)
        {
            _name = Name;
        }
        public void InternationalWithdraw(InternationalWithdraw Withdraw)   /// International  ESTERO
        {
            Withdraw(); 
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Stai prelevando all'estero!");
            Console.ResetColor();
        }
        public override void Withdraw() /// Nazionale  LOCAL
        {
            System.Console.WriteLine($"Sto prelevando con la mia banca {_name}");
        }

        public override void Deposit() { }
        public override void CheckAccount() { }
    }
    //public class CeEX : IntermediarioFinanziarioCeFi
    //{
    //    public override void Withdraw() { }
    //    public override void Deposit() { }
    //    public override void CheckAccount() { }
    //}
    //public class Broker : IntermediarioFinanziarioCeFi
    //{
    //    public override void Withdraw() { }
    //    public override void Deposit() { }
    //    public override void CheckAccount() { }
    //}
}
