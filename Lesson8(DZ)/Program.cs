//Задача на взаимодействие между классами. Разработать систему «Вступительные экзамены». Абитуриент регистрируется на Факультет, сдает Экзамены. Преподаватель выставляет Оценку. Система подсчитывает средний бал и определяет Абитуриента, зачисленного в учебное заведение.

// Создаем факультет
Faculty faculty = new Faculty("Информационные сиситемы");

// Создаем абитуриентов
Abiturent abiturent1 = new Abiturent("Иван Иванов", faculty);
Abiturent abiturent2 = new Abiturent("Петр Петров", faculty);

// Абитуриенты сдают экзамены
abiturent1.TakeExam(new Exam("Математика"), new Mark(5));
abiturent1.TakeExam(new Exam("Физика"), new Mark(5));
abiturent1.TakeExam(new Exam("Информатика"), new Mark(5));

abiturent2.TakeExam(new Exam("Математика"), new Mark(5));
abiturent2.TakeExam(new Exam("Физика"), new Mark(5));
abiturent2.TakeExam(new Exam("Информатика"), new Mark(4));

// Абитуриенты регистрируются на факультет
faculty.RegisterAbiturent(abiturent1);
faculty.RegisterAbiturent(abiturent2);

// Абитуриенты рассчитывают средний балл
abiturent1.CalculateAverageMark();
abiturent2.CalculateAverageMark();

// Система определяет абитуриента, зачисленного в учебное заведение
if (abiturent1.AverageMark > abiturent2.AverageMark)
{
    Console.WriteLine($"Абитуриент {abiturent1.Name} зачислен в учебное заведение.");
}
else
{
    Console.WriteLine($"Абитуриент {abiturent2.Name} зачислен в учебное заведение.");
}

public class Abiturent
{
    public string Name { get; set; }
    public List<Exam> Exams { get; set; }
    public Faculty Faculty { get; set; }
    public double AverageMark { get; set; }

    public Abiturent(string name, Faculty faculty)
    {
        Name = name;
        Faculty = faculty;
        Exams = new List<Exam>();
    }

    public void TakeExam(Exam exam, Mark mark)
    {
        Exams.Add(exam);
        exam.SetMark(this, mark);
    }

    public void CalculateAverageMark()
    {
        double sum = 0;
        foreach (var exam in Exams)
        {
            sum += exam.Mark.Value;
        }
        AverageMark = sum / Exams.Count;
    }
}

public class Faculty
{
    public string Name { get; set; }
    public List<Abiturent> Abiturents { get; set; }

    public Faculty(string name)
    {
        Name = name;
        Abiturents = new List<Abiturent>();
    }

    public void RegisterAbiturent(Abiturent abiturent)
    {
        Abiturents.Add(abiturent);
    }
}

public class Exam
{
    public string Name { get; set; }
    public Mark Mark { get; set; }

    public Exam(string name)
    {
        Name = name;
    }

    public void SetMark(Abiturent abiturent, Mark mark)
    {
        Mark = mark;
    }
}

public class Mark
{
    public double Value { get; set; }

    public Mark(double value)
    {
        Value = value;
    }
}