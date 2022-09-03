// //This is a comment to my code

//rakenuds küsib kasutaja sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
string userName;

userName = Console.ReadLine();

Console.WriteLine("Hello " + userName + "!");  
//string interpolation

Console.WriteLine($"Hello, {userName}!");