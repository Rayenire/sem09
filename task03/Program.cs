﻿int f(int n)
{
    if (n == 0)
        return 0;
    return f(n / 10) + n % 10;   
}

int n = 546;
Console.Write(f(n));
