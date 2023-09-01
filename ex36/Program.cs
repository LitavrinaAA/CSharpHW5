// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

}
void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
int SumNumAtOddPositions(int[] array)
{
    int length = array.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
            System.Console.Write(array[i] + " + ");
        }
    }
    return sum;
}

int[] array = new int[new Random().Next(4, 10)];
FillArray(array);
PrintArray(array);
System.Console.WriteLine(" = " + SumNumAtOddPositions(array));