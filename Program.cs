// See https://aka.ms/new-console-template for more information'


int Jnumber = 1;
int userTurn;
int WrongTurn;
Random rnd = new Random();
//startup user instructions
Console.WriteLine("Welcome to the CTC!");
Console.WriteLine("You are almost late to class, and only 1 path through the school can");
Console.WriteLine("get you to class in time, but at each of the 10 junctions there are 3 ways to go!");
Console.WriteLine("If you make a wrong turn you will not make it to class in time and Mr.Martinez will give you a tardy.");
Console.WriteLine("If you sucessfly make it to class in time Mr.Martinez will give the class cookies.");
Console.WriteLine("Good luck studnet.");

// functions
static void ClearLine(){
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth)); 
    Console.SetCursorPosition(0, Console.CursorTop - 1);
}

//main loop
while (Jnumber <= 10)  {
    Console.WriteLine("");
    Console.WriteLine("you are on Junction #" + Jnumber);
    Console.WriteLine("3 halls lie ahead...");
    Console.WriteLine("only one will get you to class on time");
    Console.WriteLine("Which will you choose? (Type 1, 2, or 3)");
    userTurn = Convert.ToInt32(Console.ReadLine());

    if (userTurn > 3) {
        ClearLine();
        Console.WriteLine("that's not a hall, try again");
        Thread.Sleep(2000);
        Console.Clear();
    }
   
    WrongTurn = rnd.Next(1,3);
    if (userTurn == WrongTurn) {
        Console.WriteLine("You made a wrong turn and got a tardy :( ");
        break;
       
    }
    else {
        Jnumber = Jnumber +1;
        Console.WriteLine("you made the correct turn!");
        Thread.Sleep(2000);
        Console.WriteLine("Let's keep going");
        Thread.Sleep(2000);
        Console.Clear();
        
    }

    if (Jnumber > 10) {
        continue;
    }
}

//after loop, either win or loose
if (Jnumber > 10) {
    Console.WriteLine("You made it to class on time and got cookies! ");
    Console.Write("Press <Enter> to exit... ");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {}
}
else { 
    Console.WriteLine("Let's try again tommorow");
    Console.Write("Press <Enter> to exit... ");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {}
}

