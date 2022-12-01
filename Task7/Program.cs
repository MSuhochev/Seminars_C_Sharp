//Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
//456 -> 6; 782 -> 2; 918 -> 8
Console.WriteLine("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
  Console.WriteLine("Третья цифра: " + NumberText[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}