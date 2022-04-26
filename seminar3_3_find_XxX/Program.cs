// выводит квадраты от 1 до числа n, полученного с клавиатуры
Console.WriteLine("enter number");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
getsq (n);
void getsq (int n)
{
    while (count<=n)
    {
        int newn = count;
        count = count*count;
        Console.Write(""+ count +", ");
        count = newn + 1;
    }
}