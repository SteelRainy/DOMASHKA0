// /*
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// */


 Console.WriteLine ("Введите первое число: ");
 int a = int.Parse (Console.ReadLine());
 Console.WriteLine ("Введите второе число: ");
 int b = int.Parse (Console.ReadLine());

bool Chto0 = a > b;
bool Chto1 = a < b;

if (Chto0)
{
    Console.WriteLine ($"Число {a} большее, число {b} меньшее. ");
}
 else
 {
    Console.WriteLine ($"Число {a} большее, число {b} меньшее. ");
 }
 