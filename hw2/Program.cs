Console.WriteLine("Введите два числа, что бы программа определила большее из них");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(numberA > numberB) max = numberA;
if(numberB > numberA) max = numberB;

Console.WriteLine($"Число {max} является найбольшим");
