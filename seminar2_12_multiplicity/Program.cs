// ввести 2 числа, если первое не кратно второму, то вывести остаток деления
Console.WriteLine("Проверка двух чисел на кратность: если первое не кратно второму, то вывести остаток деления");
Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1%number2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток деления = " + number1%number2 + "");
}
//Convert.ToInt32 - перевод в целое число;

