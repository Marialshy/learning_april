// для числа в диапазоне 100-999 преобразует из трехзначного в двузначное (удаляя среднюю цифру)
int n = new Random().Next(100,1000);
int digit1 = n %10;
int digit3 = n /100;
int result = digit3*10 + digit1;

Console.WriteLine("Для числа "+ n +" двузначное число "+ result +"");
