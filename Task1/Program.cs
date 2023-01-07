// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write ("Ввеси первое число: ");
int numA = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Ввести второе число: ");
int numB = Convert.ToInt32 (Console.ReadLine ());

if (numA > numB)
{
    Console.Write ("Большим из этих чисел является - ");
    Console.WriteLine (numA);
}
else if (numA == numB)
{
    Console.Write ("Эти числа равны");
}
else
{
    Console.Write ("Большим из этих чисел является - ");
    Console.WriteLine (numB);
}