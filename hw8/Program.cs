Console.WriteLine("Введите число, что бы программа определила все четные числа до него");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("{0} ", i);
    }
}


