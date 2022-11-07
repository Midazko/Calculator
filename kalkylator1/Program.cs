using System;
public class Kalkylator // Klass programmet.
{
    static void Main(string[] args) // Main metoden för programmet.
    {
        bool Körtid = true;
        List<string> Beräkningar = new List<string>(); // Jag deklarerar en lista för "Beräkningar" Som jag kommer att använda för att skriva ut historiska beräkningar.
        while (Körtid) // Min körtids loop.
        {
            Console.Clear();
            Console.Write("Välkommen till kalkylatorn!\n\nVälj vad du vill göra:\n" +
                "[1] Öppna kalkylatorn\n" +
                "[2] Hämta beräkningar\n" +
                "[3] Avsluta Kalkylatorn\n\n" + 
                "Skriv: ");
            if (Int32.TryParse(Console.ReadLine(), out int Meny))  // Ser till att inmatningen blir korrekt av användaren för att undvika crash.
            {
                switch (Meny) // Switch-sats För att skapa en meny där användaren kan välja vad dem vill göra.
                {
                    case 1: // Case 1 består av miniräknaren
                        Console.Clear();
                        Console.Write("Var god skriv in din beräkning: ");
                        string Svar = Console.ReadLine();

                        if (Svar.Contains("*"))
                            Gångermetod(Beräkningar, Svar); // Här kommer alla mina metoder som jag gjorde längre ner.

                        else if (Svar.Contains("+"))
                        {
                            Plusmetod(Beräkningar, Svar);
                        }

                        else if (Svar.Contains("-"))
                        {
                            Minusmetod(Beräkningar, Svar);
                        }

                        else if (Svar.Contains("/"))
                        {
                            Divisonmetod(Beräkningar, Svar);
                        }
                        else
                        {
                            Console.WriteLine("Ange en giltig beräkning!"); 
                            Tillbaka();
                        }
                        break;

                    case 2: // Case 2 skriver ut använderans historsika beräkningar.
                        Beräkningmetod(Beräkningar);
                        break;

                    case 3: // Case 3 stänger av programmet.
                        Console.WriteLine("Hej då!");
                        Körtid = false;
                        break;
                }
            }
            else // Detta händer ifall användaren skulle göra en felaktig inmatning vid menyn.
            {
                Console.Clear();
                Console.WriteLine("Du måste ange en siffra!");
                Tillbaka();
            }
        }
    }
    static void Gångermetod(List<string> Beräkningar, string Svar) // Jag skapade en metod för varje uträckning så att jag slapp repeterande kod i main metoden.
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
            if (double.IsNaN(produkt)) // Om svaret blir felaktigt så berättar consolen det för användaren.
            {
                Console.WriteLine("\nOgiltig inmatning!");
                Tillbaka();
            }
            else // Här kommer den ge användaren valet att kunna skriva ut historiska beräkningar.
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

    static void Plusmetod(List<string> Beräkningar, string Svar) // repeterande kod.
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

    static void Minusmetod(List<string> Beräkningar, string Svar) // repeterande kod.
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

    static void Divisonmetod(List<string> Beräkningar, string Svar) // repeterande kod.
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
    static void Beräkningmetod(List<string> Beräkningar) // Här kommer min beräkningsmetod som skriver ut alla beräkningar användaren har gjort.
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
        else if (Beräkningar.Count == 0) // om användaren inte gjort en inmatning så berättar consolen det.
        {
            Console.Clear();
            Console.WriteLine("Du måste göra en beräkning först!");
            Tillbaka();
        }
    }

    static void Tillbaka() // Använde ett tillbaka metod för att undvika repeterande kod i main metoden.
    {
        Console.WriteLine("\nTryck på enter för att gå tillbaka!"); 
        Console.ReadLine();
    }
}
