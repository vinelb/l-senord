


// Skriver ut krven för koden
Console.WriteLine("Kraven för koden, den får inte vara tom, längre än 7 och kortare än 20");
Console.WriteLine("Välj Kod:");
String Kod = Console.ReadLine();
bool kör = true;
// Detta är en while loop som kommer köras till att de olika kraven är uppfyllda och då slutas den 
while (kör)
{   //Varje gång en kod skrivs in som inte uppfyller kraven så kommer kod längden återställas
    int KodLängd = Kod.Length;
    
    // Här gör de att koden inte kan vara tom, den returnerar att man ska försöka igen
    if (string.IsNullOrEmpty(Kod))
    {
        Console.WriteLine("Koden kan inte vara tom, försök igen");
        Kod = Console.ReadLine();
    }
    // Detta är ett krav som gör att koden inte kan vara mindre eller likamed 7
    else if (KodLängd <= 7)
    {
        Console.WriteLine("Koden är för kort, välj annan kod:");
        Kod = Console.ReadLine();
    }
    // Om koden är längre än 20 kommer det skrivas ut att koden är för lång och att man ska försöka igen
    else if (KodLängd > 20)
    {
        Console.WriteLine("Koden är för lång, försök igen:");
        Kod = Console.ReadLine();
    }
    // Denna gör att, ifall alla kraven är uppfyllda så kommer while loopen sluta och de kommer stå att du har valt en kod
    else
    {
        Console.WriteLine("Vald kod:" + " " + Kod);
        kör = false;
    }
}



