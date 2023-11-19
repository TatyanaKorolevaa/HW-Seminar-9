// Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEvenNumbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (m%2 == 0)
    {
        System.Console.Write($"{m}\t");
    }
    PrintEvenNumbers(m + 1, n);
    
}

int m = ReadInt("Введите натуральное число: ");
int n = ReadInt("Введите натуральное число: ");
while (n < 1 || m < 1)
{
    Console.Write("Одно из чисел не натуральное. Повторите ввод. ");
    Console.WriteLine();
    m = ReadInt("Введите число больше 0: ");
    n = ReadInt("Введите число больше 0: ");
}
if (m > n) 
{
   int temp = m;
    m = n;
    n = temp;
}

PrintEvenNumbers(m, n);