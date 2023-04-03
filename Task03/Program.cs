Console.Write("Введите первое число: ");
int oneNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int twoNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(oneNumber > max)
{
    max = oneNumber;
}
if(twoNumber > max)
{
    max = twoNumber;
}
if(threeNumber > max)
{
    max = threeNumber;
}

Console.WriteLine($"max = {max}");
