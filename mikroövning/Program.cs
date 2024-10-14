Console.OutputEncoding = System.Text.Encoding.UTF8;


int pengar = 100;

    Console.WriteLine($"Du har {pengar}kr kvar du måste skaffa ett jobb😭");


    Console.WriteLine("Vilket föremål skulle du vilja tillförskaffa idag?🥺");
    Console.WriteLine("Val.1 En fin diamant ring👀, 𝓽𝓳𝓾𝓰𝓸 𝓴𝓻𝓸𝓷𝓸𝓻");
    Console.WriteLine("Val.2 Simons bodypillow🤤, 𝓽𝓻𝓮𝓽𝓽𝓲𝓸 𝓯𝓮𝓶 𝓴𝓻𝓸𝓷𝓸𝓻");
    Console.WriteLine("Val.3 Ludvigs lurviga ludd💖, 𝓯𝔂𝓻𝓽𝓲𝓸 𝓴𝓻𝓸𝓷𝓸𝓻");
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


if( pengar < (prisjhonpork * antalnum)) {
    Console.WriteLine("DET GÅR INTE");
}
else {
pengar = pengar - prisjhonpork * antalnum;
}

Console.WriteLine($"Superb val min vän.\ndu har {pengar} kr kvar");

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