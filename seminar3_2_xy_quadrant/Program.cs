// есть номер квадранта, по нему определить диапазон
Console.WriteLine("enter quadrant number");
int q = Convert.ToInt32(Console.ReadLine());
if (q>0 && q<5) Console.WriteLine("diapason for x,y:");
else Console.WriteLine("enter number 1-4");
getdiapason (q);
void getdiapason (int q)
{
    if (q==1) Console.WriteLine("x>0 && y>0");
    else if (q==2) Console.WriteLine("x<0 && y>0");//для типа функции void не нужен return тк такой тип итак не возвращает ничего
    else if (q==3) Console.WriteLine("x<0 && y<0");
    else if (q==4) Console.WriteLine("x>0 && y<0");
    else Console.WriteLine("0");
}

//через string можно тоже
// string result = getdiapason (a)

// string getdiapason (int q) и в функции описываем ...

//void getdiapason (int q)
//{
   // if (q==1)
       // {
          //  Console.WriteLine("x>0 && y>0");
           // return;
        //}
//}