string inputValue;

Console.Write("Введите 1-е число: ");
inputValue = Console.ReadLine();
int number_1 = Convert.ToInt32(inputValue);

Console.Write("Введите 2-е число: ");
inputValue = Console.ReadLine();
int number_2 = Convert.ToInt32(inputValue);

if (number_1 == number_2)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    if (number_1 < number_2)
    {
        System.Console.WriteLine($"Число {number_2} больше числа {number_1}");
    }
    else
    {
        System.Console.WriteLine($"Число {number_1} больше числа {number_2}");
    }
}


