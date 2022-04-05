//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Console.Write("Какое количество строк вы бы хотели ввести для заполнения массива? ");

int numberWords = int.Parse(Console.ReadLine());

string[] array = new string[numberWords];
string[] collection = new string[numberWords];

int index = 0;
int count = 0;

void FillArray()
{
    int numberWords = array.Length;

    while (index < numberWords)
    {
        Console.Write("Введите строку: ");
        array[index] = Console.ReadLine();
        if (array[index] == string.Empty)
        {
            Console.Write("Вероятно, вы ввели строку некорректно. ");
            Console.Write("Введите строку: ");
            array[index] = Console.ReadLine();
        }
        index++;
    }

}

void AssortedArray()
{

    for (int i = 0; i < numberWords; i++)
    {
        if (array[i].Length <= 3)
        {
            collection[count] = array[i];
            count++;
        }

    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


FillArray();
AssortedArray();
Console.WriteLine("Итоговый массив из строк, длина которых меньше или равна 3 символа: ");
PrintArray(collection);
