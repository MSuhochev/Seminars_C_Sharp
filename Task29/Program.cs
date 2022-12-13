/*Задача 29:    Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран. Данные вводятся с консоли пользователем*/

int[] array = new int[8];
Console.WriteLine("Введите первое число массива:");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число массива:");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число массива:");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвёртое число массива:");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое число массива:");
array[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите шестое число массива:");
array[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите седьмое число массива:");
array[6] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите восьмое число массива:");
array[7] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Array[{string.Join(".", array)}]");
