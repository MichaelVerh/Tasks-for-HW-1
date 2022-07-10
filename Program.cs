// Написать программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int first=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second=Convert.ToInt32(Console.ReadLine());
if (first>second)
{
    Console.WriteLine($"число {first} большее, а число {second} - меньшее");
}
else
{
    Console.WriteLine($"число {first} меньшее, а число {second} - большее");
}