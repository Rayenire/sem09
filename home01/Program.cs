// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"sum = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int m = 6;
int n = 2;
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
PrintSum(m, n, temp = 0);