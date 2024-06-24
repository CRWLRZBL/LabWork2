int[] array = { 97, 45, 32, 65, 83, 23, 15 };
Console.WriteLine("Введите значение искомого элемента");

int position = -1;
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        position = i + 1;
        break;
    }
}
Console.WriteLine($"Позиция = {position}");



