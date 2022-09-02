/* 
Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

int Ackermann (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}


Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Оба введенных значения должны быть неотрицательными числами.");
    return;
}

int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");

