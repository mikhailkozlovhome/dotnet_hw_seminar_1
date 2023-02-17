string inputValue;

Console.Write("Введите число: ");
inputValue = Console.ReadLine();
int number = Convert.ToInt32(inputValue);

if (number % 2 == 0) 
{
    System.Console.WriteLine($"Число {number} четное.");
}
else
{
    System.Console.WriteLine($"Число {number} нечетное.");
}
