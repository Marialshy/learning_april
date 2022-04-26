// сумма числе от 1 до n

int naturalSum (int a)
{
    int sum = 0;
    if (a<1) return 0;
    else
    {
        for(int i =1; i<=a; i++)
        {
            sum += i; // sum = sum +i то же что и sum+=i
        }
        return sum;
    }
}

Console.Write("enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sum: " + naturalSum(num));