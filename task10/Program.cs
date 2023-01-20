// напишите программу, которая принимает на вход 3хзначное число
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());
if (a<0)
{
    a=a*(-1);
}
if (a<100 || a>999)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
   int a2=(a%100)/10;

Console.WriteLine(a2); 
}




