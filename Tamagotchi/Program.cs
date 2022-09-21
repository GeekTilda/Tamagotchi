using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
Tamagotchi gotchi = new Tamagotchi();

System.Console.Write("Vad heter din Tamagotchi? ");
gotchi.name = Console.ReadLine();

while (gotchi.isAlive == true) {

    Console.Clear();
    gotchi.PrintList(); //SPECIELL
    System.Console.WriteLine();
    gotchi.PrintStats();
    System.Console.WriteLine("(1) Vill du lära " + gotchi.name + " ett nytt ord, (2) hälsa på " + gotchi.name + ", (3) mata " + gotchi.name + " eller göra ingenting? (annat)");
    string val = Console.ReadLine();

    if (val == "1") {
        gotchi.Teach(Console.ReadLine());

    }

    else if (val == "2") {
        gotchi.Hi();
    }

    else if (val == "3") {
        gotchi.Feed();
    }
    else {
        System.Console.WriteLine("Du gjorde ingenting! ");
    }
    gotchi.Tick();
    Console.ReadLine();
}

System.Console.WriteLine("DU DÖDADE " + gotchi.name + "!");