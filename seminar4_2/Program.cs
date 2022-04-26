//вывести на экран массив из 8 элементов с рандомынми числами 0 или 1
int []array= new int [8];
for (int i = 0; i< array.Length; i++)
{
    array[i]=new Random().Next(0,2);
    Console.Write(array [i]+ ",");
}
//Console.Write(PrintArray(array)) - написав при помощи метода PrintArray;

