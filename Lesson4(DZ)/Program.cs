// Составить описание класса для определения одномерных массивов строк фиксированной длины. Предусмотреть контроль выхода за пределы массива, возможность обращения к отдельным строкам массива по индексам, выполнения операций поэлементного сцепления двух массивов с образованием нового массива, слияния двух массивов с исключением повторяющихся элементов, а также вывод на экран элемента массива по заданному индексу и всего массива.

//using Lesson4_DZ_;

////Console.Write("Введите массив: ");
////int a = int.Parse(Console.ReadLine()!);
////Console.WriteLine(a);
////StringArray stringArray1 = new StringArray(5);
////StringArray stringArray2 = new StringArray(5);
////stringArray1.Concatenate(stringArray1);
////stringArray2.Concatenate(stringArray2);

//////stringArray1.SetElement(6,);
//////stringArray2.SetElement(7,);

////stringArray1.GetElement(5);
////Console.Write("Введите элемент массива по индексу: ");
////int n = int.Parse(Console.ReadLine()!);
////stringArray1.PrintElement(n);

////stringArray1.PrintArray();
////stringArray2.PrintArray();



//StringArray massiv1 = new StringArray(5);
//StringArray massiv2 = new StringArray(5);

//massiv1.Contac();
//massiv2.Contac();

//massiv1.Sum();
//massiv2.Sum();

using Lesson4_DZ_;
using System;

class Program
{
    static void Main()
    {
        // Создание объекта класса StringArray
        StringArray array = new StringArray(5);

        // Заполнение массива
        array[0] = "строка1";
        array[1] = "строка2";
        array[2] = "строка3";
        array[3] = "строка4";
        array[4] = "строка5";

        // Вывод элемента массива по индексу
        int index = 2;
        Console.WriteLine($"Элемент с индексом {index}: {array[index]}");
       

        // Вывод всего массива
        array.PrintAll();


        // Объединение массивов
        string[] source = new string[] { "строка6", "строка7 ", "строка8 ", "строка9 ", "строка10" };
        string[] concatArray = array.Concat(source);
        Console.Write("Результат объединения массивов: ");
        for (int i = 0; i < concatArray.Length; i++)
        {
            Console.Write(concatArray[i]+" ");
        }
        Console.WriteLine();

        // Слияние массивов
        string[] unionArray = array.Union(source);
        Console.Write("Результат слияния массивов:");
        for (int i = 0; i < unionArray.Length; i++)
        {
            Console.Write(unionArray[i]+" ");
        }
        Console.ReadLine();
    }
}