//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
/*
int[] arr=GetArrayFromString ();
printArray(arr);
Console.WriteLine ($" -> {checkPlus(arr)}");



//Создание массива
int checkPlus (int[] arr)
{
    int res=0;
    for (int i=0;i<arr.Length;i++){
       if (arr[i]>0) res++;
    }
    return res;
}

//Создание массива
int[] GetArray(int size,int min,int max)
{
    int[] res= new int[size];
    for (int i=0;i<size;i++){
        res[i]=new Random().Next(min,max+1);
    }
    return res;
}

int[] GetArrayFromString()
{
    Console.Write ("Введите массив элементов через пробел (или просто Enter - 7 случайных чисел от -100 до 100):");
    string s= Console.ReadLine()!;
    if (s!="")
    {
        string[] tempStringArray=s.Split(" ");
        int[] res= new int[tempStringArray.Length];
        for (int i=0;i<tempStringArray.Length;i++)
        {
            res[i]=int.Parse(tempStringArray[i]);
        }
        return res;// почему то один return в конце за if ругается, что переменной нет, хотя она в if создастся точно (баг c#)
    } 
    else 
    {
        int[] res=GetArray(7,-100,100);
        return res;
    }
    
}

//Вывод массива
void printArray (int[] arr)
{
    Console.Write ($"[{String.Join(",",arr)}]");
}
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Введите коэффициенты первой прямой y=k1*x+b1.");
Console.Write ("k1=");
double k1= double.Parse(Console.ReadLine()!);
Console.Write ("b1=");
double b1= double.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите коэффициенты второй прямой y=k2*x+b2.");
Console.Write ("k2=");
double k2= double.Parse(Console.ReadLine()!);
Console.Write ("b2=");
double b2= double.Parse(Console.ReadLine()!);



if (check(k1,k2)) { 
    double x=(b2-b1)/(k1-k2);
    double y=(b2*k1-b1*k2)/(k1-k2);
    Console.WriteLine ($"Точка пересечения ({x};{y})");
}
bool check (double k1, double k2) {
    if (k1==k2)   
    {
        Console.WriteLine ("Не пересекаются!");
        return false;
    }
    return true;

}