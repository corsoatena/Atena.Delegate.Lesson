using Atena.Delegate.Lesson.Interfaces;
using System.Collections.Generic;

namespace Atena.Delegate.Lesson
{
    public abstract class IntermediarioFinanziarioCeFi : IFinancialServices
    {
        public List<Client> _clients;
        public List<Account> _accounts;

        public void CreateAccount(Person p)
        {

            Client c = new Client(p) { _AccountNumber = 1225555 };
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
        public void InternationalWithdraw(InternationalWithdraw InternationalBank)   /// International  ESTERO
        {
            InternationalBank();
        }
        public override void Withdraw() /// Nazionale  LOCAL
        {
            
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
