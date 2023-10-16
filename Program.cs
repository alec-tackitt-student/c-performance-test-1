// See https://aka.ms/new-console-template for more information'
int RoomNumber = 1;
int userRoom;
int GhostRoom;
Random rnd = new Random();
//startup user instructions
Console.WriteLine("Welcome to Alec's haunted house!");
Console.WriteLine("You must make it through all 10 sets of doors to survive!!");
Console.WriteLine("though behind 1 door there is a Ghost!, if you go through the one with");
Console.WriteLine("the ghost you will loose.");

// functions
static void ClearLine(){
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth)); 
    Console.SetCursorPosition(0, Console.CursorTop - 1);
}

void Entrypoint() {
    Console.WriteLine("");
    Console.WriteLine("you are on room #" + RoomNumber);
    Console.WriteLine("3 doors lie ahead...");
    Console.WriteLine("There's a ghost behind one.");
    Console.WriteLine("Which will you choose? (Type 1, 2, or 3)");
    userRoom = Convert.ToInt32(Console.ReadLine());

    if (userRoom > 3) {
        ClearLine();
        Console.WriteLine("that's not a door, try again");
        Thread.Sleep(2000);
        Console.Clear();
        Entrypoint();
    }
    else {
        DoorChoice();
    }
}

void DoorChoice() {
    GhostRoom = rnd.Next(1,3);
    if (userRoom == GhostRoom) {
        Console.WriteLine("ghost");
    }
    else {
        RoomNumber = RoomNumber +1;
        Console.WriteLine("pass");
        Thread.Sleep(2000);
        Console.WriteLine("Let's keep going");
        Thread.Sleep(2000);
        Console.Clear();
        Entrypoint();
    }
}

//Start function loop
Entrypoint(); 

