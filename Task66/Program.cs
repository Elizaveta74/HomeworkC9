/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

long CalcSum(int m, int n)
{
    if (m > n)
    {
       return 0; 
    } 
    else
    {
        return m + CalcSum(m + 1, n);
    } 
}


Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
long sum = CalcSum(m, n);
Console.WriteLine($"Сумма значений натуральных чисел от {m} до {n} = {sum}");
