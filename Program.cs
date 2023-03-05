// ДЗ, урок 5

// 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
Console.WriteLine("");
int count = 0;
int[] array = {345, 897, 568, 234};
int length = array.Length;

for (int i = 0; i < array.Length; i++)
{
    if (i %2 == 0)
{
    Console.WriteLine("Количество четных чисел: " + count++ );
    count++;
}
 else
{
    Console.WriteLine();
}
}

*/





// 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// // Console.WriteLine("Введите размер массива: ");
// // int size= Convert.ToInt32(Console.ReadLine());
// // int[] array = new int[size];
// // //int[] GrtArray(int Oddposition);
// // //int SumOfOddPositionElements(int[] array)
// //  {
// //     int[] sum = 0;
// //     for (int i = 0; i < array.length; i += 2)
// //     {
// //         sum = sum + array[i];
// //     }
// //     Console.WriteLine($"всего {array.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
// //  }


/*
36.
int[] a = new int[4];
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите {i} = ");
    a[i] = int.Parse(Console.ReadLine());
}
int result = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 1 )
        result += a[i];
        
}
Console.WriteLine($"Сумма нечетных чисел = {result}");
*/








// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble().

/*
Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n];

for (int i = 0; i < n; i++)
{ 
    Console.Write($" Введите {i}й элемент: "); 
    array[i]= Convert.ToInt32(Console.ReadLine()); 
}
int min = 0;
int max = 0;

foreach (int i in array) // Поиск максимального и минимального значения
{
 if (min > i) 
    {
       min = i; 
    } 
 if (max < i)
    {
       max = i; 
    } 
}
//Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max}-{min}");
*/
