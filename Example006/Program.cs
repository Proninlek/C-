Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "ксюша")
{
    Console.WriteLine ("Ооооо, это же Ксюша-Хрюша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine (username);
}