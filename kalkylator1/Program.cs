class program
{
    static void Main(string[] args)
    {
        string Gångerindex = "*";
        bool Körtid = true;
        List<string[]> Beräkningar = new List<string[]>();
        while (Körtid)
        {
            
            Console.WriteLine("Välkommen till kalkylatorn\n Välj vad du vill göra:\n" +
                "[1] Öppna kalkylatorn\n" +
                "[2] Hämta beräkningar\n" +
                "[3] Avsluta Kalkylatorn");
            if (Int32.TryParse(Console.ReadLine(), out int Meny))
            {
                switch (Meny)
                {

                }
            }
        }
    }
}
class Kalkylatorn
{
  static void Beräkning()
    {
    
    }
}