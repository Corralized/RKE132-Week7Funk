
Console.WriteLine("Are you going or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye(); // esilekutsuv funksioon
}
   



static void PrintHello() // funktsioon / meetod
{
    Console.WriteLine("Hallo, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}