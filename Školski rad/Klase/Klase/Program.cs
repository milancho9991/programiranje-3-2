internal class Program
{
    class Ucenik {
        public string ime;
        public string prezime;

        public void PrikaziIme() {
            Console.WriteLine("Moje ime je: " + ime + ", a prezime " + prezime);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Ucenik ucenik = new Ucenik();
        ucenik.ime = "Milan";
        ucenik.prezime = "Stojanovic";
        ucenik.PrikaziIme();
    }
}