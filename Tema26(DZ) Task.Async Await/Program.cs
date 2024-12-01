//Тема 26. Домашнее задание. Tasks. Async Await

// Создайте простой асинхронный метод, результат выполнения которого ожидается во вторичном потоке.
//К примеру, пусть это будет простой метод, возвращающий факториал переданного числа
//Так как факториал считается в цикле, притормозите каждую итерацию цикла на 250мс
//Результат выводить во вторичном потоке
//В главном потоке, в цикле выводить секунды с задержкой от 1 до 10.


Console.Write("Введите число для вычисления факториала: ");
int number = int.Parse(Console.ReadLine()!);

Task<long> factorialTask = CalculateFactorialAsync(number);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Секунда: {i}");
    await Task.Delay(1000); 
}

long result = await factorialTask;
Console.WriteLine($"Факториал числа {number}: {result}");
    
static async Task<long> CalculateFactorialAsync(int number)
{
    long result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
        await Task.Delay(250); 
    }
    return result;
}