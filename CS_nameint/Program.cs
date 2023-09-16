Console.WriteLine("ВВедите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("а, это снова ты ");
}
else
{
    Console.Write("Прив ");
    Console.WriteLine(username);
}
