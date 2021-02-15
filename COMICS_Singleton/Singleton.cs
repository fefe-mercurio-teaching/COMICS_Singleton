using System;

namespace COMICS_Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                
                return _instance;
            }
        }

        private Singleton()
        {
            Console.WriteLine("Ho creato l'oggetto Singleton");
        }

        public void Print() => Console.WriteLine("Ciao Mondo!");
    }
}