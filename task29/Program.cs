// Задача 29: Напишите программу,
//  которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Массив рандомных восьми числе");

int New = 8;

int[] arrayRan = new int[New];

Random rnd = new Random();

for(int i = 0 ; i < array.Length; i++);
{
    arrayRan[i] = rnd.Next(1, 101);
    
   Console.WriteLine(arrayRan[i] + " ");
} 

