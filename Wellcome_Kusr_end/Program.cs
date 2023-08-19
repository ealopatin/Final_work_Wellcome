
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

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] array = new string[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Введите элемент массива {i}: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");



int length2 = 0;

for (int i = 0; i < length; i++)

{
    if (array[i].Length <= 3)
    {
        length2 ++;
    }
}

Console.WriteLine(length2);

// string[] secondArray = new string[length2];


// Console.WriteLine($"Массив: [{String.Join("; ", secondArray)}]");
