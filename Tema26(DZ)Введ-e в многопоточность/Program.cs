// Задание: Многозадачный счетчик
//Пояснение к выполнению:
//Это задание предполагает создание простого многозадачного приложения на C#.
//Вам нужно будет создать два потока: один для увеличения счетчика, а другой для уменьшения его значения.
//Основная цель - добиться параллельной работы этих потоков и обеспечить безопасное обновление общего ресурса, а именно, счетчика.
//Создайте класс счетчика, который будет представлять общий ресурс для обоих потоков. Этот класс должен содержать методы для увеличения и уменьшения значения счетчика, а также метод для получения текущего
//значения.
//Создайте два потока: один для увеличения счетчика и один для уменьшения.
//В методах каждого потока вызывайте методы счетчика для обновления значения.
//Обеспечьте синхронизацию доступа к счетчику так, чтобы потоки не могли перезаписать его значение одновременно.
//Выведите текущее значение счетчика на экран в каждом потоке.
//Запустите оба потока и следите за изменениями счетчика.

using System;
using System.Threading;


Counter counter = new Counter();

Thread incrementThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        counter.Increment();
        Thread.Sleep(400); 
    }
});

Thread decrementThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        counter.Decrement();
        Thread.Sleep(550); 
    }
});

incrementThread.Start();
decrementThread.Start();

incrementThread.Join();
decrementThread.Join();

Console.WriteLine($"Конечное значение счетчика: {counter.GetCount()}");

class Counter
{
    private int count;
    private readonly object _lock = new object(); 

    public void Increment()
    {
        lock (_lock) 
        {
            count++;
            Console.WriteLine($"Увеличение счетчика: {count}");
        }
    }

    public void Decrement()
    {
        lock (_lock) 
        {
            count--;
            Console.WriteLine($"Уменьшение счетчика: {count}");
        }
    }

    public int GetCount()
    {
        lock (_lock) // Блокируем доступ к ресурсу
        {
            return count;
        }
    }
}



