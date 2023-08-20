
// Задача: Написать программу, которая
// из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Вводим и печатаем массив

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string[] array = new string[length];
for (int i = 0; i < length; i++)
{
    Console.Write($"Введите элемент массива {i}: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine($"Заданный массив: [{String.Join("; ", array)}]");

// Считаем длинну нового массива

int length2 = 0;
for (int i = 0; i < length; i++)
{
    if (array[i].Length <= 3)
    {
        length2++;
    }
}

// Запополням и печатем массив

string[] secondArray = new string[length2];
int j = 0;
for (int i = 0; i < length; i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[j] = array[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join("; ", secondArray)}]");
Console.WriteLine();

