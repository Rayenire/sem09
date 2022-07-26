// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
int f(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return f(m - 1, 1);
    else return f(m - 1, f(m, n - 1));
        
}

int n = 3;
int m = 2;
f(n, m);

Console.WriteLine(f(n, m));