//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int GetNumbFiveDigit()
{
    int numb = 0;
    while (numb < 9999 || numb > 99999)
    {
       Console.WriteLine("Введите пятизначное число!");
       numb = Convert.ToInt32(Console.ReadLine());  
    }
    return numb;
}

void TestPalindrom(int number)
{  
    int n1 = number / 10000;
    int n5 = number % 10;
    int n2 = (number / 1000) % 10;
    int n4 = (number / 10) % 10;
    if((n1 == n5) && (n4 == n2))
            {
                Console.WriteLine("Это число " + number + " палиндром");
            }
            else
            {
                Console.WriteLine("Это число " + number + " не палиндром");
            }
}
   
int number = GetNumbFiveDigit();
TestPalindrom(number);