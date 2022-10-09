int value = InputValue("Введите число");
if (IsPalindrom(value))
Console.WriteLine("палиндром");
else
Console.WriteLine("что угодно, но не палиндром");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = (Math.Abs(int.Parse(value)));
    return a;
}

bool IsPalindrom (int value)
{
    string b = value.ToString();
    for (int i = 0; i < b.Length/2; i++)
        if (b[i] != b[b.Length-1-i])
            return false;
        return true;
}

