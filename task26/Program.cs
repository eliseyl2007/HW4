// int Quantity(int num);
// {
//     // if (num < 0) num = num * -1;
//     int count = 0;
//     while (num > 0 || num < 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Введите натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int quantity = Quantity(number);
// Console.WriteLine($"В числе {number} -> {quantity} знаков");

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
