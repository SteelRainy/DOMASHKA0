 //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
 Console.WriteLine("Введите число");
int a =int.Parse(Console.ReadLine());
if (a % 2==1)
{
    Console.WriteLine("Нечётное число");
}
else 
{
    Console.WriteLine("Чётное число");
}
