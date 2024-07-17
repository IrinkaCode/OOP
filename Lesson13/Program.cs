// 
using Lesson13;
using System.Collections;

//Person person = new Person { Name = "Alice", Age = 25 };
//Console.WriteLine(person.Name);
//Console.WriteLine(person.Age);
//Person copyPerson = (Person)person.Clone();
//copyPerson.Name = "Boris";
//Console.WriteLine(copyPerson.Name);
//Console.WriteLine(copyPerson.Age);


//string[] peoples = ["Tom", "Sam", "jerry", "Bob"];
//IEnumerator peopleEnumerator = peoples.GetEnumerator();
//while (peopleEnumerator.MoveNext())
//{
//    string item = (string)peopleEnumerator.Current;
//    Console.WriteLine(item);
//}
//peopleEnumerator.Reset();

//Week week = new Week();
//foreach (var day in week)
//{
//    Console.WriteLine(day);
//}

//Range range = 1..4;
//int[] mas = { 7, 4, 8, 2 };
//int[] masRange = mas[range];
//foreach (var item in mas) Console.Write(item+",");
//Console.WriteLine();

//Numbers numbers = new Numbers();
//foreach (var item in numbers)
//{
//    Console.Write(item+",");
//}


Del delegat = (x) =>
{
    Console.WriteLine(x);
};
delegat ("6");

MesHello mes = () =>
{
    Console.WriteLine("Hello");
};
mes();

//Operation operation = delegate (int x, int y)
//{
//    return x + y;
//};
//Console.WriteLine(operation(6,7));

Operation operation = (x, y) => x + y;

Console.WriteLine(operation(6, 7));

operation = (x, y) => x * y;
Console.WriteLine(operation(6, 7));

int[] mas = { 1, 6, 3, 8, 9, 15 };
Console.WriteLine(Sum(mas, x => x > 5));
Console.WriteLine(Sum(mas, x => x % 2 == 0));
IsOdd odd=(x)=> x % 2 == 0?true: false;
Console.WriteLine(odd(6));

Max max=(mas) => mas.Max();
Console.WriteLine(max(mas));

Sort sort=(mas)=> Array.Sort(mas);
Console.WriteLine();

Print print = (mas) =>
{
    foreach (var item in mas)
    {
        Console.Write(item + " ");
    }
};
print(mas);

Fact fact = (x) =>
{
    long f = 1;
    for (int i = 1; i <= x; i++) f *= i;
    return f;
};
Console.WriteLine(fact(5));

int Sum(int[] ints, IsEqual fun)
{
    int sum = 0;
    foreach (int x in ints)
    {
        if (fun(x)) sum += x;
    }
        return sum;
}

delegate bool IsOdd(int x);
delegate bool IsEqual(int x);
delegate void Del(string x);
delegate void MesHello();
delegate int Operation(int x, int y);
delegate long Fact(long x);
delegate int Max(int[]mas);
delegate void Sort(int[]mas);
delegate void Print (int[] mas);