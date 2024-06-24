int[] array = { 97, 45, 32, 65, 83, 23, 15 };
Console.WriteLine("Введите нужный элемент");
int right = 0, left = 0, number = 0;
int middle = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == middle)
    { 
        number = i;
        break;
    }
    else if (array[i] < middle)
    {
        left = middle - 1;
        number = -1;
        break;
    }
    else right = middle + 1;
}
Console.WriteLine(number);