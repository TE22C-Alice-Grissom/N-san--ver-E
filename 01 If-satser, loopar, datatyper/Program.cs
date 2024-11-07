// if (6 >= 3)
// {
//     Console.WriteLine("Hello, Word!");
// }
// Console.ReadLine();


// Console.WriteLine("Type your name and password");
// string name = Console.ReadLine();
// string password = Console.ReadLine();


// if (name == "noname" && password == "nopass")
// {
//     Console.WriteLine("Welcome");
// }
// else 
// {
//     Console.WriteLine("Wrong username or password");
// }
// Console.ReadLine();

// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World");
// }
// Console.ReadLine();


// while (false)
// {
//     string password = Console.ReadLine();
//     if (password == "MII BOOMMBBAAA")
//     {
//         break;
//     }
// }

// string pass ="";
// while (pass != "MII BOOMMBBAAA")
// {
//     pass = Console.ReadLine();
// }


// for (int i = 0; i < 5; i++)
// {
//     string point = Console.ReadLine();
//     int numbers ;
//     bool success = int.TryParse(point, out numbers);

//     if(numbers > 5)
//     {
//         Console.WriteLine("Högre än 5");

//     }
// }



// int number;
// bool success = false;

// while (success != true)
// {
//     string num = Console.ReadLine();
//     success = int.TryParse(num, out number);
// }


Random random = new Random();
int tal = Random.Shared.Next(1, 100);

Console.WriteLine("Gissa siffran!");
Console.WriteLine("Jag har valt en siffra mellan 1 och 100!");
// läsa in en siffra från användaren
// tryparse

if (gissningen < tal)
{
    Console.WriteLine("Högre");
}
else if (gissningen > tal)
{
    Console.WriteLine("Längre");
}


Console.ReadLine();
