Console.OutputEncoding = System.Text.Encoding.UTF8;


int pengar = 100;

    Console.WriteLine($"Du har {pengar}kr kvar du måste skaffa ett jobb😭");


    Console.WriteLine("Vilket föremål skulle du vilja tillförskaffa idag?🥺");
    Console.WriteLine("Val.1 En fin diamant ring👀");
    Console.WriteLine("Val.2 Simons bodypillow🤤");
    Console.WriteLine("Val.3 Ludvigs lurviga ludd💖");
    string jhonpork = "";   

    while   (jhonpork != "1" && jhonpork != "2" && jhonpork != "3")
      {
        jhonpork = Console.ReadLine();
      }
    



int prisjhonpork = 0;


if(jhonpork =="1")
{

    prisjhonpork = 20;
}
else if(jhonpork =="2")

{
    prisjhonpork =35;
}

else if(jhonpork=="3")
{
    prisjhonpork = 40;
}


Console.WriteLine("Hur många vill du köpa?");
string antal = Console.ReadLine();

int antalnum = 0;

bool success = int.TryParse(antal, out antalnum);


if (success == false)

{
Console.WriteLine("Hur många vill köpa med en siffra 😡");
}

if(success == true)
{
    Console.WriteLine("Okej det funkar bombaclatt");
}


Console.ReadLine();








// Console.WriteLine("Skriv in din ålder");
// string age = Console.ReadLine();

// int ageNum = 0;

// bool success = int.TryParse(age, out ageNum);

// if (success == false)
// {
//     Console.WriteLine("EN siffra bladclatt");
// }

// if(success == true)
// {
//     Console.WriteLine("Hurray bladclatt u passed");
// }

// if(ageNum > 18)
// {

// Console.WriteLine("Välkommen");
// }


// Console.ReadLine();