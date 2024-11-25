
////Asynk awiait

//await PrintTask();
//await PrintAsynk();
//Console.WriteLine("Основной поток");
//await PrintNameAsynk("Arin");
//await PrintNameAsynk("Tom");
//await PrintNameAsynk("Sam");

//Account account = new Account();
//account.Added += PrintAsync;
//account.Put(500);
//await Task.Delay(2000);

//var task = PrintAsyncTask("Hello");
//Console.WriteLine("Основная программа");
//await task;
//int n1 = await SquareAsync(6);
//int n2 = await SquareAsync(7);
//Console.WriteLine($"{6}^2={n1}\n{n2}^2={n2}");

//var result = await Addasync(7, 9);
//Console.WriteLine(result);

//первый способ вызова
//await PrintAsyncTask("first");
//await PrintAsyncTask("second");
//await PrintAsyncTask("third");


//второй способ
//var t1 = PrintAsyncTask("first");
//var t2 = PrintAsyncTask("second");
//var t3 = PrintAsyncTask("third");
//await t1;
//await t2;
//await t3;
//await Task.WhenAll(t1,t2,t3);///ожидает завершения всех задач

//await Task.WhenAny(t1,t2,t3);
//Console.WriteLine("Hello");

var t1 = SquareAsync(5);
var t2 = SquareAsync(9);
var t3 = SquareAsync(3);

//int[] mas = await Task.WhenAll(t1, t2, t3);
await Task.WhenAny(t1,t2,t3);

Console.WriteLine(t1.Result);
Console.WriteLine(t2.Result);
Console.WriteLine(t3.Result);

//foreach (int i in mas)
//    Console.WriteLine(i);
Console.WriteLine("Ждал");
async void PrintAsync(object? obj,string mes)
{
    await Task.Delay(1000);
    Console.WriteLine();
}
//async Task <int>SquareAsync(int n)
//{
//    await Task.Delay(1000);
//    Console.WriteLine(mes);
//}

ValueTask<int>Addasync(int a,int b)
{
    return new ValueTask<int>(a + b);
}

async Task<int>SquareAsync(int n)
{
    await Task.Delay(0);
    return n * n;
}

async Task PrintAsyncTask(string mes)
{
    await Task.Delay(1000);
    Console.WriteLine(mes);

}
void Print()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello");
}
//async Task PrintAsynk()
//{
//    await Task.Delay(3000);
//    Console.WriteLine("Hello asynk");
//}
async Task PrintTask()
{
    Console.WriteLine("Начало метода...");
    await Task.Run(() => Print());
    Console.WriteLine("Конец метода....");
}
async Task PrintNameAsynk(string name)
{
    await Task.Delay(3000);
    Console.WriteLine(name);
}

class Account
{
    int sum = 0;
    public event EventHandler<string>? Added;
    public void Put(int sum)
    {
        this.sum += sum;
        Added?.Invoke(this, $"На счет поступило {sum} $");
    }        
}

