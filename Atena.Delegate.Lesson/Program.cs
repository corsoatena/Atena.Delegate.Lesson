using Atena.Delegate.Lesson.Interfaces;
using System;
using static Atena.Delegate.Lesson.Program;

namespace Atena.Delegate.Lesson
{  
    public delegate string PersonalWalletAction();
    public class Program
    {

        //public delegate void MyDelegate();
        //static MyDelegate delegateEnglish;
        //static MyDelegate delegateSpanish;
        //static InternationalWithdraw Prelievo;



        static PersonalWalletAction functionSanitaria; 
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
            functionSanitaria += brunoWallet.GetSituzioneSanitaria;
            AssicurazioneSanitaria Allianz = new AssicurazioneSanitaria();

            Allianz.RichiestaAssicurazione(functionSanitaria); 

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
        public string GetSituzioneSanitaria()
        {
            return _cartellaClinica;
        }
    }

    public class AssicurazioneSanitaria
    {

        public void RichiestaAssicurazione(PersonalWalletAction action) // Solo una funzione e non un interno oggetto personale
        {
            Console.WriteLine(action());
        }
    }




}
