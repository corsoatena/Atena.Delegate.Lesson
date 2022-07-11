using Atena.Delegate.Lesson.Interfaces;
using System;
using static Atena.Delegate.Lesson.Program;

namespace Atena.Delegate.Lesson
{  
    public delegate void PersonalWalletAction(string s);
    public class Program
    {

        //public delegate void MyDelegate();
        //static MyDelegate delegateEnglish;
        //static MyDelegate delegateSpanish;
        //static InternationalWithdraw Prelievo;



        static PersonalWalletAction DatiSanitari; 
        static void Main(string[] args)
        {

            //Translation translation = new Translation();

            //delegateEnglish += translation.English;
            //delegateSpanish += translation.Spanish;


            //Office office1 = new Office(delegateSpanish);// -> solo inglese
            //Office office2 = new Office(delegateSpanish); // -> solo Francese


            //office1.Translate();
            //office2.Translate();



            //Bank intesa = new Bank("intesa");             
            //Prelievo += intesa.Withdraw; 


            //IInternationalBank citi = intesa;
            //citi.InternationalWithdraw(Prelievo); 


            /// Delegate  ===   un Tipo (Classe) Che  permette di incapuslare al suo interno 
            /// l'indirizzo di  di una una funzione  
            /// 
            PersonaWallet brunoWallet = new PersonaWallet();

           // DatiSanitari += brunoWallet.GetSituazioneSanitaria;
            AssicurazioneSanitaria Allianz = new AssicurazioneSanitaria(Notification);

            Allianz.WithDraw(10000); 
            Allianz.CancellazioneAssicurazione();


            ///CALLBACK     ->>> UNA FUNZIONE CHE VIENE ESEGUITA DA  UNA'ATTORE E RITORNA UN VALORE AL SUO PROPRIETARIO
        }
        static public void Notification(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    
    //public class Translation
    //{
    //    public void English() { Console.WriteLine("I'm translating in ENG"); }
    //    public void Spanish() { Console.WriteLine("I'm translating in SPANISH"); }
    //    public void French() { Console.WriteLine("I'm translating in FRENCH"); }
    //}
    //public class Office
    //{
    //    MyDelegate _translation { get; set; }
    //    public void Translate()
    //    {
    //        _translation();
    //    }
    //    public Office(MyDelegate translation)
    //    {
    //        _translation = translation;
    //    }
    //} 
    public class PersonaWallet
    {
         string _diploma;
         string _dichiarioneReddito;
         string _fedinaPenale;
         string _cartellaClinica = "Situazione sanitaria tutto OK";
        public string GetIstruzione()
        {
            return _diploma; 
        }
        public string GetReddito()
        {
            return _dichiarioneReddito;
        }
        public string GetSituzionePenale()
        {
            return _fedinaPenale;
        }
        public string GetSituazioneSanitaria() /// OVERWRITE
        {
            return _cartellaClinica;
        }
        public void GetSituazioneSanitaria(string s) // OVERLOADING 
        {
            Console.WriteLine("");
        }
        public void GetSituazioneSanitaria(int n) // OVERLOADING 
        {

        }
       
    }
    public class AssicurazioneSanitaria
    {

        Action<string> _notify; 
        public void WithDraw( decimal amount) // Solo una funzione e non un interno oggetto personale
        {
            Console.WriteLine(" creazione assicurazione in corso");
            Console.WriteLine("Prelievo eseguito! ");
            _notify("Prelevato: " + amount.ToString()+ " EURO");
        }
        public AssicurazioneSanitaria(Action<string> alertMe)
        {
            _notify = alertMe;
        }
        public void CancellazioneAssicurazione() // Solo una funzione e non un interno oggetto personale
        {
            Console.WriteLine("... cancellazione assicurazione in corso");
            _notify("....cancellazione eseguita! ");
        }
    }




}
