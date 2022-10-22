using System;
public class Kalkylator
{
    static void Main(string[] args)
    {
        string Gångerindex = "*";
        string Plusindex = "+";
        string Minusindex = "-";
        string Divisionindex = "/";
        bool Körtid = true;
        List<string> Beräkningar = new List<string>();
        while (Körtid)
        {
            Console.Clear();
            Console.Write("Välkommen till kalkylatorn!\n\nVälj vad du vill göra:\n" +
                "[1] Öppna kalkylatorn\n" +
                "[2] Hämta beräkningar\n" +
                "[3] Avsluta Kalkylatorn\n\n" + 
                "Skriv: ");
            if (Int32.TryParse(Console.ReadLine(), out int Meny))
            {
                switch (Meny)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Vad god skriv in din beräkning: ");
                        string Svar = Console.ReadLine();

                        if (Svar.Contains(Gångerindex))
                            Gångermetod(Beräkningar, Svar);

                        else if (Svar.Contains(Plusindex))
                        {
                            Plusmetod(Beräkningar, Svar);
                        }

                        else if (Svar.Contains(Minusindex))
                        {
                            Minusmetod(Beräkningar, Svar);
                        }

                        else if (Svar.Contains(Divisionindex))
                        {
                            Divisonmetod(Beräkningar, Svar);
                        }
                        else
                        {
                            Console.WriteLine("Ange en giltig beräkning!");
                            Tillbaka();
                        }
                        break;

                    case 2:
                        Beräkningmetod(Beräkningar);
                        break;

                    case 3:
                        Console.WriteLine("Hej då!");
                        Körtid = false;
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du måste ange en siffra!");
                Tillbaka();
            }
        }
    }
    static void Gångermetod(List<string> Beräkningar, string Svar)
    {
        int gångerIndex = Svar.IndexOf("*");
        string tal1Text = Svar[..gångerIndex];
        string tal2Text = Svar[(gångerIndex + 1)..];
        double tal1 = double.Parse(tal1Text);
        double tal2 = double.Parse(tal2Text);
        double produkt = tal1 * tal2;
        string Svaret = Convert.ToString(Svar + " = " + produkt);
        try
        {
            if (double.IsNaN(produkt))
            {
                Console.WriteLine("\nOgiltig inmatning!");
                Tillbaka();
            }
            else
            {
                Console.WriteLine("\n" + Svaret);
                Beräkningar.Add(Svaret);
                Console.Write("\nOm du vill se dina historiska beräkningar, skriv [1] annars tryck vad som helst: ");
                string Visa = Console.ReadLine();
                if (Visa == "1")
                {
                    Beräkningmetod(Beräkningar);
                }            
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Herregud vad händer?!?!?!?!?");
            Tillbaka();
        }
    }

    static void Plusmetod(List<string> Beräkningar, string Svar)
    {
        int plusindex = Svar.IndexOf("+");
        string tal1Text = Svar[..plusindex];
        string tal2Text = Svar[(plusindex + 1)..];
        double tal1 = double.Parse(tal1Text);
        double tal2 = double.Parse(tal2Text);
        double produkt = tal1 + tal2;
        string Svaret = Convert.ToString(Svar + " = " + produkt);
        try
        {
            if (double.IsNaN(produkt))
            {
                Console.WriteLine("\nOgiltig inmatning!");
                Tillbaka();
            }
            else
            {
                Console.WriteLine("\n" + Svaret);
                Beräkningar.Add(Svaret);
                Console.Write("\nOm du vill se dina historiska beräkningar, skriv [1] annars tryck vad som helst: ");
                string Visa = Console.ReadLine();
                if (Visa == "1")
                {
                    Beräkningmetod(Beräkningar);
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Herregud vad händer?!?!?!?!?");
            Tillbaka();
        }
    }

    static void Minusmetod(List<string> Beräkningar, string Svar)
    {
        int minusindex = Svar.IndexOf("-");
        string tal1Text = Svar[..minusindex];
        string tal2Text = Svar[(minusindex + 1)..];
        double tal1 = double.Parse(tal1Text);
        double tal2 = double.Parse(tal2Text);
        double produkt = tal1 - tal2;
        string Svaret = Convert.ToString(Svar + " = " + produkt);
        try
        {
            if (double.IsNaN(produkt))
            {
                Console.WriteLine("\nOgiltig inmatning!");
                Tillbaka();
            }
            else
            {
                Console.WriteLine("\n" + Svaret);
                Beräkningar.Add(Svaret);
                Console.Write("\nOm du vill se dina historiska beräkningar, skriv [1] annars tryck vad som helst: ");
                string Visa = Console.ReadLine();
                if (Visa == "1")
                {
                    Beräkningmetod(Beräkningar);
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Herregud vad händer?!?!?!?!?");
            Tillbaka();
        }
    }

    static void Divisonmetod(List<string> Beräkningar, string Svar)
    {
        int divisonindex = Svar.IndexOf("/");
        string tal1Text = Svar[..divisonindex];
        string tal2Text = Svar[(divisonindex + 1)..];
        double tal1 = double.Parse(tal1Text);
        double tal2 = double.Parse(tal2Text);
        double produkt = tal1 / tal2;
        string Svaret = Convert.ToString(Svar + " = " + produkt);
        try
        {
            if (double.IsNaN(produkt))
            {
                Console.WriteLine("\nOgiltig inmatning!");
                Tillbaka();
            }
            else
            {
                Console.WriteLine("\n" + Svaret);
                Beräkningar.Add(Svaret);
                Console.Write("\nOm du vill se dina historiska beräkningar, skriv [1] annars tryck vad som helst: ");
                string Visa = Console.ReadLine();
                if (Visa == "1")
                {
                    Beräkningmetod(Beräkningar);
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Herregud vad händer?!?!?!?!?");
            Tillbaka();
        }
    }
    static void Beräkningmetod(List<string> Beräkningar)
    {
        if (Beräkningar.Count > 0)
        {
            Console.Clear();
            Console.WriteLine("Här är dina beräkningar: ");
            for (int i = 0; i < Beräkningar.Count; i++)
            {
                Console.Write(Beräkningar[i] + "\n");

            }
            Tillbaka(); ;
        }
        else if (Beräkningar.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Du måste göra en beräkning först!");
            Tillbaka();
        }
    }

    static void Tillbaka() 
    {
        Console.WriteLine("\nTryck på enter för att gå tillbaka!"); 
        Console.ReadLine();
    }
}
