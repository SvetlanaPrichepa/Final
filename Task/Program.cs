// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] array = new string[9] {"мир", "путь", "hello", "5483", "res", "12548", "люб", "25", "2"};
string[] arrayNew = new string[array.Length];

void newArray(string[] array, string[] arrayNew)
{
int position = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayNew[position] = array[i];
        position++;
    }
}
}
void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
    Console.WriteLine();
}

newArray(array, arrayNew);
Console.WriteLine();
PrintArray(arrayNew);
