// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
void FillArray(double[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.Next(100, 1000) + rnd.NextDouble(), 2);
    }

}
void PrintArray(double[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

double[] array = new double[new Random().Next(4, 10)];
FillArray(array);
PrintArray(array);
System.Console.Write(array.Max());
System.Console.Write(" - ");
System.Console.Write(array.Min());
System.Console.Write(" = " + (Math.Round(array.Max() - array.Min(), 2)));
