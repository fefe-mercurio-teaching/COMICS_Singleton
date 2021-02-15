namespace COMICS_Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Singleton.Instance.Print();

            AltraClasse altraClasse = new AltraClasse();
            
            Singleton.Instance.Print();
        }
    }
}