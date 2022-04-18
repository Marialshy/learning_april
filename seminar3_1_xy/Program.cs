// в какую плоскость координат попадает точка x,y (вводится с клавиатуры)
Console.WriteLine("enter coordinates x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinates y:");
int y = Convert.ToInt32(Console.ReadLine());

int q = getQuadrant (x, y);
if (q==0) Console.WriteLine("This point is on a ax:");
else Console.WriteLine("This point is in quadrant #" + q);
int getQuadrant (int x, int y)
{
    if (x>0 && y>0)
        return 1;
    else if (x<0 && y>0) //можно записать как просто if () renurn; if.2() return2;... return end
        return 2;
    else if (x<0 && y<0)
        return 3;
    else if (x>0 && y<0)
        return 4;
    else
        return 0;
}