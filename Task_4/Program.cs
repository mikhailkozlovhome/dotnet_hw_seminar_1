string inputValue;
int count = 2;

Console.Write("Введите число: ");
inputValue = Console.ReadLine();
int number = Convert.ToInt32(inputValue);

while (count <= number)
{
    Console.Write(count + " ");
    count = count + 2;
}

