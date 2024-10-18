        Console.OutputEncoding = System.Text.Encoding.UTF8;

int pengar = 100;

Console.WriteLine($"Du har {pengar} kr kvar, du MÅSTE skaffa ett extra jobb 😭");

Console.WriteLine("Vad vill du köpa idag?");
Console.WriteLine(".1 / En fin diamant ring 👀 , 20 riksdaler");
Console.WriteLine(".2 / Simon läckra öron snibbar 🤤 , 50 riksdaler");
Console.WriteLine(".3 / Privat programmerings lektioner av Kevin😳, 100 riksdaler");

string val = Console.ReadLine();


int priset = 0;
if (val == "1") priset = 20;
else if (val == "2") priset = 50;
else if (val == "3") priset = 100;

Console.WriteLine("Hur många vill du köpa?");
int antal = int.Parse(Console.ReadLine());


int helkostnad = pengar * antal;


if (helkostnad > pengar)
{
    Console.WriteLine("Du har tyvärr inte råd med detta😂 ");
}

else 

{
    pengar -= helkostnad;
      Console.WriteLine($"Superb val min vän! Du har {pengar}kr kvar.");
}

Console.WriteLine("Tryck Enter för att stänga av");




Console.ReadLine();



























