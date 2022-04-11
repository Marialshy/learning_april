// является ли второе число квадратом первого?
Console.WriteLine("ввести число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = (number * number);

if (result == number2)
{
    Console.WriteLine("yes");
}
else
{
   Console.Write("no");
}