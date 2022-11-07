bool count = true;
int ka_preis;
string sorte;
do                          //Abfrage der Biersorte mit DAU-Sicherung
{
    Console.Write("\nBiersorte wählen.");
    Console.Write("\nPils(P), Hefeweizen(H), Kristall(K), Starkbier(S). ");
    sorte = Console.ReadLine();

    switch (sorte)
    {
        case "Pils":
        case "P":
        case "p":
            ka_preis = 16;
            sorte = "Pils";
            count = false;
            break;
        case "Hefeweizen":
        case "H":
        case "h":
            ka_preis = 18;
            sorte = "Hefeweizen";
            count = false;
            break;
        case "Kristall":
        case "K":
        case "k":
            ka_preis = 15;
            sorte = "Kristall";
            count = false;
            break;
        case "Starkbier":
        case "S":
        case "s":
            ka_preis = 25;
            sorte = "Starkbier";
            count = false;
            break;
        default:
            Console.WriteLine("Falsche Eingabe!"); 
            ka_preis = 1000;
            count = true;
            break;
    }
} while (count == true);

Console.WriteLine($"\nDer Preis für {sorte} ist {ka_preis} Euro pro Kasten.");

string wert;
bool dau_num=false;
int anzahl;

do                  //Abfrage der Anzahl der Kästen, mit einer DAU-Sicherung
{
    Console.Write("\nWie viele Kästen Bier? ");
    wert = Console.ReadLine();
    dau_num = int.TryParse(wert, out anzahl);

} while (dau_num==false);

Console.WriteLine("");
decimal r5 = 0.95m;
decimal r7 = 0.93m;
decimal r10 = 0.90m;
decimal end_preis;

if (anzahl >= 100)
{
    Console.WriteLine("Rabatt von 10%.\n");
    end_preis = anzahl * ka_preis * r10;
    Console.WriteLine($"Die {anzahl} Kästen {sorte} werden {end_preis} Euro kosten.\n");
}
else if (anzahl >= 50)
{
    Console.WriteLine("Rabatt von 7%.\n");
    end_preis = anzahl * ka_preis * r7;
    Console.WriteLine($"Die {anzahl} Kästen {sorte} werden {end_preis} Euro kosten.\n");

}
else if (anzahl >= 10)
{
    Console.WriteLine("Rabatt von 5%.\n");
    end_preis = anzahl * ka_preis * r5;
    Console.WriteLine($"Die {anzahl} Kästen {sorte} werden {end_preis} Euro kosten.\n");
}
else
{
    Console.WriteLine("kein Rabatt!");
    end_preis = anzahl * ka_preis;

    if (anzahl == 1)
    {
        Console.WriteLine($"Der Kasten {sorte} wird {end_preis} Euro kosten.\n");
    }
    else
    {
        Console.WriteLine($"Die {anzahl} Kästen {sorte} werden {end_preis} Euro kosten.\n");
    }
}





