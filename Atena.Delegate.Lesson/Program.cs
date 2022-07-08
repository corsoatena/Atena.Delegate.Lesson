using Atena.Delegate.Lesson.Interfaces;
using System;
using static Atena.Delegate.Lesson.Program;

namespace Atena.Delegate.Lesson
{
    public class Program
    {

        public delegate void MyDelegate();

        static MyDelegate delegateEnglish;
        static MyDelegate delegateSpanish;
        static InternationalWithdraw Prelievo;
        static void Main(string[] args)
        {
            
            Translation translation = new Translation();

            delegateEnglish += translation.English;
            delegateSpanish += translation.Spanish;


            Office office1 = new Office(delegateSpanish);// -> solo inglese
            Office office2 = new Office(delegateSpanish); // -> solo Francese


            office1.Translate();
            office2.Translate();



            Bank intesa = new Bank(); // 
            Prelievo += intesa.Withdraw; 

            Bank citi = new Bank();
            citi.InternationalWithdraw(Prelievo); 


            /// Delegate  ===   un Tipo (Classe) Che  permette di incapuslare al suo interno 
            /// l'indirizzo di  di una una funzione 


        } 

    }
    public class Translation
    {
        public void English() { Console.WriteLine("I'm translating in ENG"); }
        public void Spanish() { Console.WriteLine("I'm translating in SPANISH"); }
        public void French() { Console.WriteLine("I'm translating in FRENCH"); }
    }
    public class Office
    {
        MyDelegate _translation { get; set; }
        public void Translate()
        {
            _translation.Spanish();
            _translation.English();
            _translation.French();
        }
        public Office(MyDelegate translation)
        {
            _translation = translation;
        }
    }





}
