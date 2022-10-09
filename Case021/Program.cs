int x1 = InputValue("Введите координаты x1");
int y1 = InputValue("Введите координаты y1");
int z1 = InputValue("Введите координаты z1");
int x2 = InputValue("Введите координаты x2");
int y2 = InputValue("Введите координаты y2");
int z2 = InputValue("Введите координаты z2");

Console.WriteLine("Расстояние = " +Distance(x1,x2,y1,y2,z1,z2)); 

double Distance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double S = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
    return S;
}


int InputValue(string message)
{
    Console.WriteLine(message);
    string val = Console.ReadLine();
    int a = int.Parse(val);
    return a;
}

