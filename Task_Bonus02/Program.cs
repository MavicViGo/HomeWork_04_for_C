/*
Задача: Гипотеза Гольдбаха
Требуется написать программу, производящую согласно утверждению Гольдбаха,
разложение заданного чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, 
требуется найти пару, содержащую наименьшее простое число.
*/
Console.Clear();
Console.Write("Введите четное число от 4 до 998, N: ");
int n = int.Parse(Console.ReadLine()!);
int[] Numbers = new int[n];
while (n < 4 || n > 998 || n % 2 !=0)
{
Console.WriteLine("Ошибка!\nВведите четное число от 4 до 998, N:");
n = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < n; i++ )
{
    Numbers[i] = i+1;
}

for (int i = 3; i < n; i++)
    if (Numbers[i] % 2 == 0)
    Numbers[i] = 0;
for (int i = 4; i < n; i++)
    if (Numbers[i] % 3 == 0)
    Numbers[i] = 0;
for (int i = 6; i < n; i++)
    if (Numbers[i] % 5 == 0)
    Numbers[i] = 0;
for (int i = 8; i < n; i++)
    if (Numbers[i] % 7 == 0)
    Numbers[i] = 0;
for (int i = 12; i < n; i++)
    if (Numbers[i] % 11 == 0)
    Numbers[i] = 0;
for (int i = 14; i < n; i++)
    if (Numbers[i] % 13 == 0)
    Numbers[i] = 0; 
for (int i = 18; i < n; i++)
    if (Numbers[i] % 17 == 0)
    Numbers[i] = 0; 
for (int i = 20; i < n; i++)
    if (Numbers[i] % 19 == 0)
    Numbers[i] = 0;   
for (int i = 24; i < n; i++)
    if (Numbers[i] % 23 == 0)
    Numbers[i] = 0;  
for (int i = 32; i < n; i++)
    if (Numbers[i] % 31 == 0)
    Numbers[i] = 0;          
Numbers[0] = 0;
//Console.WriteLine($"[{string.Join(", ",Numbers)}]"); //Проверочный вывод массива с выбитыми простыми числами
int SimpleN = 0;
for (int i = 0; i < n; i++)
    if(Numbers[i] != 0)
    SimpleN++;

int[] SimpleNumbers = new int[SimpleN];
int j = 0;
for (int i = 0; i < n; i++)
    if (Numbers[i] != 0)
    {
    SimpleNumbers[j] = Numbers[i];
    j++;
    }
//Console.WriteLine($"[{string.Join(", ",SimpleNumbers)}]"); //Схлопнул нулевые элементы

Console.WriteLine($"Все возможные вариации разбиения числа {n} на сумму двух простых чисел:");
for (int i = 0; i <= SimpleNumbers.Length/2; i++)
{
    bool tr = false;
    int temp1 = SimpleNumbers[i];
    int temp2 = n - temp1;
    int leng = SimpleNumbers.Length;
    for(int m = 0; m < leng; m++)
    {
        if(temp2 == SimpleNumbers[m])
        tr = true;
    }
    if (tr == true)
    {
    Console.WriteLine($"{temp1}, {temp2}"); //Вывод всех вариаций разбиения по данному условию
    //return; //Если выводить пару с минимальным простым числом
    }
}
