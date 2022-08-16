int number = new Random().Next(100, 1000);

int find(int number)
{
    Console.WriteLine(number);
    Console.Write((number % 100)/10);
    return(number);
}
find(number);