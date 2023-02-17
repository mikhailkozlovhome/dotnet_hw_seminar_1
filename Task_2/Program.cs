string inputValue;

Console.Write("Введите 1-е число: ");
inputValue = Console.ReadLine();
int number_1 = Convert.ToInt32(inputValue);

Console.Write("Введите 2-е число: ");
inputValue = Console.ReadLine();
int number_2 = Convert.ToInt32(inputValue);

Console.Write("Введите 3-е число: ");
inputValue = Console.ReadLine();
int number_3 = Convert.ToInt32(inputValue);

int max = number_1;

if (number_2 > max)
{
    max = number_2;
}

if (number_3 > max)
{
    max = number_3;
}

System.Console.WriteLine("Максимальное число равно: " + max);