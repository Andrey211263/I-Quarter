// Написать программу, которая из имеющегося массива формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Пример: 
// ["Hello","2","world",":-)"]

// метод вывода массива на экран
void ResultPrint(string[] result, int j)
{
Console.Write($"Наш массив [");
for (int i = 0; i < j-1; i++)
{
    Console.Write($"{result[i]}, ");
}
Console.Write($"{result[j-1]} ]");
}


//старт программы
Console.WriteLine("Задайте массив разделяя элементы запятыми:");
string text = Console.ReadLine();
string[] array = text.Split(',');

// string[] array = { "hello", "2", "world", ":-)" };

int count = array.Length;
string word;
string[] result = new string[count];
int lengthWord = 0;
int j = 0;

for (int i = 0; i < count; i++)
{
    word = array[i];
    lengthWord = word.Length;
    if (lengthWord <= 3)
    {
        result[j] = array[i];
        j++;
    }
    //Console.WriteLine($"{i} = {array[i]}");
}
//Console.WriteLine($"[{String.Join(",", (result))}]");


ResultPrint(result, j);