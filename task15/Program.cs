Console.WriteLine("Введите число от 1 до 7, обозначающее день недели");
int a=Convert.ToInt32(Console.ReadLine());
if (a<1 || a>7)
{
    Console.WriteLine("Ошибка ввода");
}
else if (a<5)
{
    Console.WriteLine("Данный день недели не является выходным днем");
}
else
{
    Console.WriteLine("Данный день недели является выходным днем");
}