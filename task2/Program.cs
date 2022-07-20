//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Enter num1: ");
  int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter num2: ");
  int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
  Console.WriteLine(+num1);  
}
else
{
    Console.WriteLine(+num2);  
}

