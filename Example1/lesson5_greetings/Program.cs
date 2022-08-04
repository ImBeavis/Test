Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("Ураа, это же Андрей!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}