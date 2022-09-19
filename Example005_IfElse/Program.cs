Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же МАША! ");
        Console.WriteLine("");
}
else
{
    Console.WriteLine("Привет, " + username + "!");
    Console.WriteLine("");
}
