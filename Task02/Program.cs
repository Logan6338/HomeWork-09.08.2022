//Console.WriteLine("Напишите число");
//int numberA = Convert.ToInt32(Console.ReadLine());

//void find()
//{
//    Console.WriteLine();
//    Console.Write((numberA / 100) % 10);
//}

///find();

Console.WriteLine("Напишите число");
int n = Convert.ToInt32(Console.ReadLine());

int find(int n)
{
    int[] array = new int[n];

    for (int i = 2; i <= n; i++)
    {
        array[i - 1] = i * i;
    }
    return n;
}