//Задача 1. Создайте анонимный метод, который принимает два аргумента(числа) и возвращает их сумму. Затем создайте делегат, который может вызывать этот анонимный метод, и используйте его для выполнения сложения чисел.
//Задача 2. Создайте массив строк и отфильтруйте его с использованием лямбда-выражения. Отфильтруйте строки, чтобы получить только те,которые начинаются с определенной буквы (например, "A").
//Задача 3. Создайте массив делегатов, представляющих различные математические операции (сложение, вычитание, умножение, деление).Запросите у пользователя числа и операцию, которую он хочет выполнить.Затем используйте массив делегатов, чтобы выполнить выбранную операцию с введенными числами.

//Задача 1
//SumDelegate sum = delegate (int x, int y)
//{
//    return x + y;
//};
//int result = sum(5, 3);
//Console.WriteLine("Сумма чисел: " + result);
//delegate int SumDelegate(int a, int b);

//Задача 2
//string[] words = { "Apple", "Banana", "Orange", "Avocado", "Apricot", "Pear" };
//char startingLetter = 'A';
//Console.WriteLine($"Строки, начинающиеся с буквы '{startingLetter}':");
//var filteredWords = words.Where(word => word.StartsWith(startingLetter.ToString(), StringComparison.OrdinalIgnoreCase));
//foreach (var word in filteredWords)
//{
//    Console.WriteLine(word);
//}


//Задача 3
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Выберите операцию:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");

int choice = Convert.ToInt32(Console.ReadLine());

if (choice < 1 || choice > 4)
{
    Console.WriteLine("Неверный выбор операции.");
    return;
}

MathOperation[] operations = {
            (x, y) => x + y, // сложение
            (x, y) => x - y, // вычитание
            (x, y) => x * y, // умножение
            (x, y) => x / y  // деление
        };

double result = operations[choice - 1](num1, num2);
Console.WriteLine($"Результат операции: {result}");
delegate double MathOperation(double x, double y);


