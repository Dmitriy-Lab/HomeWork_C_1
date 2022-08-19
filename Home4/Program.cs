Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= N)
{
if (a % 2 == 0)
{
    Console.Write(a);
    Console.Write(" ");
}
a = a + 1;
}