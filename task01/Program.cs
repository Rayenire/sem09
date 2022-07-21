void Factorial(int n)
{
    if (n != 0) 
    {
        Factorial(n - 1);
        Console.Write(n + " ");
    }
}

int n = 10;
Factorial(n);