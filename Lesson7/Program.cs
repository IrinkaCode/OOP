// Наследование

//ClassParent parent = new ClassParent(5, 9);
//Console.WriteLine(parent.getX);
//Child child = new Child(6);
//Console.WriteLine(child.getX);


Student vasia = new Student("Иванов", "Василий","21ПОБ12", 4.5);
Console.WriteLine(vasia.getScholarship());
Aspirant borya = new Aspirant("Петров", "Борис", 5, "Геофизика");
Console.WriteLine(borya.getScholarship());

Student[] group = new Student[4];
group[0] = vasia;
group[1] = borya;
group[2] = new Student("Федоров", "Илья", "21ПОБ12", 4.9);
Student sam = new Aspirant("Сидоров","Сэм",3.8,"Биолгия");//восходящее преобразование
group[3] = sam;
//Aspirant? max = new Student("Планк","Макс",5) as Aspirant;//нисходящее преобрразование
Student max = new Student("Планк", "Макс", 5);


Aspirant? maxAspirant = max as Aspirant;
maxAspirant!.ScientistWork = "Химия";
group[4] = maxAspirant;
Console.WriteLine(maxAspirant.getScholarship());

class ClassParent
{
    private int x;
    protected int y;
    public int getX { get { return x; } }

    public ClassParent(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public ClassParent(int y)
    {
        this.y = y;
    }
}
class Child : ClassParent
{
    public Child(int y) : base(y) { }

    public void Method()
    {
        //int c=base.x;
        Console.WriteLine(base.y);
        double d = y;
        Console.WriteLine(d);
    }
}
//Создайте пример наследования, реализуйте класс Student и класс Aspirant, аспирант отличается от студента наличием некой научной работы. Класс Student содержит переменные: String firstName, lastName, group. А также, double averageMark, содержащую среднюю оценку. 
//1.Создать метод getScholarship() для класса Student, который возвращает сумму стипендии. Если средняя оценка студента равна 5, то сумма 5000 рублей, иначе 3000. Переопределить этот метод в классе Aspirant.  Если средняя оценка аспиранта равна 5, то сумма 25000 рублей, иначе 15000. 
//2. Создать массив типа Student, содержащий объекты класса Student и Aspirant. Вызвать метод getScholarship() для каждого элемента массива.


class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public  string? Group { get; }
    private string? group;

    private double averageMark;

    public Student(string? firstName, string? lastName, string? group, double averageMark)
    {
        FirstName = firstName;
        LastName = lastName;
        this.group = group;
        AverageMark = averageMark;

    }

    public double AverageMark
    {
        get { return averageMark; }
        set
        {
            if (value >= 2 && value <= 5) averageMark = value;
            else value = 0;
        }
    }

    public Student(string? firstName, string? lastName, double averageMark)
    {
        FirstName = firstName;
        LastName = lastName;
        AverageMark = averageMark;
    }
    //public virtual decimal getScholarship()
    //{
    //    if (AverageMark == 5) return 5000;
    //    return 3000;
    //}
    public virtual decimal getScholarship()
    {
        if (AverageMark == 5) return 5000;
        return 3000;
    }
}


class Aspirant : Student
{
    public string ScientistWork { get; set; }
    //public Aspirant(string? firstName, string? lastName, double averageMark) : base(firstName, lastName, averageMark)
    //{
    //}
    public Aspirant(string? firstName, string? lastName, double averageMark,string scientistWork) : base(firstName, lastName, averageMark)
    {
        this.ScientistWork = scientistWork;
    }

    //public override decimal getScholarship()
    //{
    //    if (AverageMark == 5) return 25000;
    //    return 15000;
    //}
    public new decimal getScholarship()
    {
        if (AverageMark == 5) return 25000;
        return 15000;
    }
}
