//Создайте запись (Record) с именем student, содержащую поля: фамилия и инициалы, номер группы, успеваемость (массив из пяти элементов). Создать массив из десяти элементов такого типа, упорядочить записи по возрастанию среднего балла. Добавить возможность вывода фамилий и номеров групп студентов, имеющих оценки, равные только 4 или 5.
using System;
using Lesson14_DZ_Методы_расширения;
using Lesson14_DZ_Методы_расширения._Анонимные_типы._Кортежи_;

Student[] students = new Student[10]
{
            new Student("Иванов И.И.", 1, new int[]{5, 4, 5, 3, 4}),
            new Student("Петров П.П.", 2, new int[]{4, 4, 5, 4 ,5}),
            new Student("Сидорова Н.А.", 2, new int[]{3, 4, 5, 4 ,5}),
            new Student("Петрова О.К.", 3, new int[]{5, 4, 5, 4 ,5}),
            new Student("Алексеев А.А.", 3, new int[]{3, 4, 5, 4 ,5}),
            new Student("Воронцова А.Н.", 3, new int[]{5, 5, 5, 4 ,5}),
            new Student("Попов Д.А.", 4, new int[]{3, 4, 5, 4 ,5}),
            new Student("Соколова П.С.", 4, new int[]{4, 4, 5, 4 ,5}),
            new Student("Баранов Н.М.", 2, new int[]{4, 4, 5, 4 ,5}),
            new Student("Климова И.Л.", 5, new int[]{4, 5, 5, 5 ,5}),

};

Array.Sort(students,
           (s1, s2) => s1.AverageGrade.CompareTo(s2.AverageGrade));

Console.WriteLine("Студенты с оценками только равными 4 или 5:");

foreach (Student student in students)
{
    if (student.Grades.All(g => g == 4 || g == 5))
    {
        Console.WriteLine($"Фамилия: {student.FullName}, Номер группы: {student.GroupNumber}");
    }
}

