Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int find(int num)
{
  
if ((6 <=num) && (num <= 7))
{
    Console.WriteLine("Да");
}
else

    if ((0 < num) && (num < 6))
    {
        Console.WriteLine("Нет");
    }
    return(num);
}
find(num);