// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет
Console.WriteLine("Введите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());
if (a<0)
{
    a=a*(-1);
}
if (a<100)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else if (a>99)
{
    string b=Convert.ToString(a);
    Console.WriteLine(b[2]);
}
