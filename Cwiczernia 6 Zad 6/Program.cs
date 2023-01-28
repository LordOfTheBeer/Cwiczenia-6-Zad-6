namespace Cwiczernia_6_Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Jessica Rajczula";
            
            Console.WriteLine(tekst1);

            int gdzie_jest_spacja;
            
            gdzie_jest_spacja = tekst1.IndexOf(' ');
            
           // Console.WriteLine(gdzie_jest_spacja);

            tekst1 = tekst1.Insert(gdzie_jest_spacja, " Hermenegilda");
            
            Console.WriteLine(tekst1);

            tekst1 = tekst1.Remove(0, tekst1.IndexOf(' ') + 1);

            Console.WriteLine(tekst1);

            tekst1 = tekst1.Substring(0, 1) + tekst1.Substring(tekst1.IndexOf(' ') + 1, 1);

            Console.WriteLine(tekst1);
        }
    }
}