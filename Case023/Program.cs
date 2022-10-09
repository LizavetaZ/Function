int InputValue(string message)
{
    Console.WriteLine(message);
    string val = Console.ReadLine();
    int a = int.Parse(val);
    return a;
}

int a = InputValue("Введите число");
if (a > 0)
{
    for (int i = 1; i<=a; i++)
    {
        Console.Write(Math.Pow(i,3) +",");
    }
}
else if (a<0)
{
    for (int i = a; i<0; i++)
    {
        Console.Write(Math.Pow(i,3) +",");
    }
}
else Console.WriteLine("ошибка");
