Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (b > max) max = b;
if (a == max) min = b;

Console.WriteLine(" ");
Console.Write("Большее число = ");
Console.WriteLine(max);

Console.Write("Меньшее число = ");
Console.WriteLine(min);