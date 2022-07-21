void f(int n, int m)
{
    if (n != (m - 1))
    {
        f(n - 1, m);
        Console.Write(n + " ");
    }
}

int n = 10;
int m = 3;
f(n, m);
