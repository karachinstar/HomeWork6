/*Задача 41: 
 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*/
int x = new Random().Next(0, 10);
Console.WriteLine($"Введите массив из {x} чисел (после каждого числа жмите ввод(Enter)): ");
int[] array = new int[x];
int count = 0;
for (int i = 0; i < x; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count++;
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 1)
    {
        Console.Write($"{array[i]}, ");
    }
    else
    {
        Console.Write($"{array[i]}");
    }
}
Console.Write($"] -> В данном массиве количество чисел больше нуля = {count}");

