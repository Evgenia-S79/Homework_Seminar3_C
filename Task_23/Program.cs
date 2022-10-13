// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber ()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32 (Console.ReadLine());
}

void GetCubeNumb (int numb)
{
    int index = 1;
    while (index <= numb)
    {
        Console.Write(Math.Pow (index,3)+ " ");
        index ++;
    }
}

GetCubeNumb(GetNumber());