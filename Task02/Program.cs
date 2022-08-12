Console.WriteLine("Напишите число");
int numberA = Convert.ToInt32(Console.ReadLine());

void find()
{
    Console.WriteLine();
    Console.Write((numberA / 100) % 10);
}

find();
