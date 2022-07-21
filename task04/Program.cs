int f(int a, int b)
{
    if (b == 0)
        return 1;
    return f(a, b - 1) * a;   
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(f(a, b));
