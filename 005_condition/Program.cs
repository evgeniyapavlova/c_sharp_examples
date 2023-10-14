Console.Write("Input user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yes, it's Masha!");
}
else
{
    Console.Write("Hello, ");    
    Console.WriteLine(username);    
}