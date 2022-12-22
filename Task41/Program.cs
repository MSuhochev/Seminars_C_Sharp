/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода слова "stop"
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/


int CountPositiveNumbers()
{
    Console.WriteLine("Введите N чисел, для завершения ввода напишите stop: ");
    int count = 0;
    var num = String.Empty;
    while(num.ToLower() != "stop")
    {   
        num = Console.ReadLine();
        int.TryParse(num, out int i);
        if (i > 0)
        {
            count++;
        }
        
    }
    return count;
}
Console.WriteLine($"Значений больше 0 - {CountPositiveNumbers()}");
