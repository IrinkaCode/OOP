//using Lesson14;

//IntOperation op = new IntOperation(Calculatior.Sum);

//int x;                                                         //Дописать из гита
//int.TryParse(
//int y;
//IntOperation op = new IntOperation(Calculator.Sum);
//Console.WriteLine($"{x}+{y}");


//using Lesson14;

//UserInfo[] userInfo =
//{
//    new UserInfo("Иван","Иванов",900),
//    new UserInfo("Алексей","Петров",120000),
//    new UserInfo("Семен","Семенов",1800),
//    new UserInfo("Петр","Петров",7900),
//};
//ArraySort.Sort(userInfo,UserInfo.UserSalary);
//foreach(var item in userInfo)
//{
//    Console.WriteLine(item);
//}
//ArraySort.Sort(userInfo, UserInfo.UserSalaryDesc);
//foreach (var item in userInfo)
//{
//    Console.WriteLine(item);
//}

//void DoOperation(int x, int y,Action<int,int>op)=>op(x,y);
//void Add(int x,int y)=>Console.WriteLine($"{x}+{y}={x+y}");
//void Sub(int x, int y) => Console.WriteLine($"{x}-{y}={x - y}");
//DoOperation(x, y, Add);
//DoOperation(x, y, Sub);

//Predicate<int> IsPositiv = x => x > 0;
//Console.WriteLine(IsPositiv(10));
//Console.WriteLine(IsPositiv(-16));

int[] mas= new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
    mas[i] = random.Next(10,100);
foreach (int i in mas)
    Console.Write(i + " ");
Console.WriteLine();

List<DateTime> tList = new List<DateTime>();
{
    DateTime.Parse("2024-07-20");
    DateTime.Parse("2024-07-28");
    DateTime.Parse("2024-07-22");
    DateTime.Parse("2024-07-17")
};
CheckPredicateDate(tList, x => x);


void CheckPredicate(int[] x, Predicate<int>filter)
{
    for (int i = 0;i < mas.Length;i++)
    {
        if (filter(x[i])) Console.Write(x[i]+" ");
    }
    Console.WriteLine();
}
void CheckPredicateDate(List<DateTime> x, Predicate<DateTime> filter)
{
    for (int i = 0; i < x.Count; i++)
    {
        if (filter(x[i])) Console.Write(x[i] + " ");
    }
    Console.WriteLine();
}
CheckPredicate(mas, x => x % 2 == 0);
delegate bool FilterPredicate(int x);