//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Console.Write("Какое количество слов вы бы хотели ввести для заполнения массива? ");

int numberWords = int.Parse(Console.ReadLine());

string[] array = new string[numberWords];


void FillArray()
{


    for (int i = 0; i < numberWords+1; i++)
    {
        Console.Write("Введите слово:    ");
        array[numberWords] = Console.ReadLine();

    }

}



FillArray();

