/*
Задача: Суперсдвиг
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
(сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
*/
Console.Clear();
Console.Write("Введите колличество чисел в последовательности N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите сдвиг K: ");
int k = int.Parse(Console.ReadLine()!);

int[] array = new int[n];
int[] ResArray = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.WriteLine($"Последовательность чисел до сдвига: [{string.Join(", ",array)}]");
if (k > 0)
{
    for (int i = 0; i < n; i++)
    {
       if (i+k < n)
       {
        ResArray[i+k] = array[i];
        }
        else 
        ResArray[i+k-n] = array[i];
    }
}
else
{
    k = Math.Abs(k);
    for (int i = 0; i < n; i++)
    {
       if (i-k >= 0)
       {
        ResArray[i-k] = array[i];
        }
        else 
        ResArray[i-k+n] = array[i];
    }
}
Console.WriteLine($"Последовательность чисел после сдвига: [{string.Join(", ",ResArray)}]");