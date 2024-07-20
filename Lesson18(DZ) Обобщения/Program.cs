using Lesson18_DZ__Обобщения;
using System;

Person<string, string, string> person = new Person<string, string, string>
{
    Name = "Иван",
    Age = 25,
    Gender= "Мужской",
    Height = 90,
    Weight = 190,
    Race = "Европа",
    EyeColor = "Зеленые",
    Address = "Москва",
    PhoneNumber = "+71234567890"
};

Teacher<string, string, string> teacher = new Teacher<string, string, string>
{
    Name = "Василий",
    Age = 40,
    Gender = "Мужской",
    Address = "Самара",
    PhoneNumber = "+790067884534",
    Height = 90,
    Weight = 190,
    Race = "Европа",
    EyeColor = "Зеленые",
    EmployeeId = 123,
    Subject = "Физика",
    TeachingExperience = 15,
    Salary = 45000,
    Position = "Учитель",
    HireDate = new DateTime(2000, 12, 3)
};
Console.WriteLine();

Student<string, string, string> student = new Student<string, string, string>
{
    Name = "Мария",
    Age = 20,
    Height = 60,
    Weight = 170,
    Race = "Европа",
    EyeColor = "Зеленые",
    Gender = "Женский",
    Address = "Москва",
    PhoneNumber = "+75551234567",
    Course = 3,
    Specialization = "Информатика",
    AverageGrade = 4.5

};

Manager<string, string, string> manager = new Manager<string, string, string>
{
    Name = "Алексей",
    Age = 40,
    Gender = "Мужской",
    Height = 70,
    Weight = 180,
    Race = "Европа",
    EyeColor = "Голубые",
    Address = "Новосибирск",
    PhoneNumber = "+71112223333",
    ManagementArea = "Продажи",
    SubordinatesCount = 15,
    ManagementExperience = 8,
    EmployeeId = 125,
    Salary = 45000,
    Position = "Менеджер",
    HireDate = new DateTime(2000, 12, 3)
};

Programmer<string, string, string> programmer = new Programmer<string, string, string>
{
    Name = "Елена",
    Age = 30,
    Gender = "Женский",
    Height = 70,
    Weight = 180,
    Race = "Европа",
    EyeColor = "Карие",
    Address = "Казань",
    PhoneNumber = "+79998887777",
    EmployeeId = 120,
    ProgrammingLanguage = "C#",
    Projects = new List<string> { "Проект 1", "Проект 2", "Проект 3" },
    Specialization = "Веб-разработка",
    Salary = 45000,
    Position = "Разработчик",
    HireDate = new DateTime(2001, 11, 23)
};

Console.WriteLine($"Имя: {person.Name}");
Console.WriteLine($"Возраст: {person.Age}");
Console.WriteLine($"Пол: {person.Gender}");
Console.WriteLine($"Вес: {person.Height}");
Console.WriteLine($"Рост: {person.Weight}");
Console.WriteLine($"Раса: {person.Gender}");
Console.WriteLine($"Цвет глаз: {person.EyeColor}");
Console.WriteLine($"Адрес: {person.Address}");
Console.WriteLine($"Номер телефона: {person.PhoneNumber}");

Console.WriteLine();

Console.WriteLine($"Имя: {teacher.Name}");
Console.WriteLine($"Возраст: {teacher.Age}");
Console.WriteLine($"Пол: {teacher.Gender}");
Console.WriteLine($"Вес: {teacher.Height}");
Console.WriteLine($"Рост: {teacher.Weight}");
Console.WriteLine($"Раса: {teacher.Gender}");
Console.WriteLine($"Цвет глаз: {teacher.EyeColor}");
Console.WriteLine($"Адрес: {teacher.Address}");
Console.WriteLine($"Номер телефона: {teacher.PhoneNumber}");
Console.WriteLine($"Номер сотрудника: {teacher.EmployeeId}");
Console.WriteLine($"Предмет,который преподает: {teacher.Subject}");
Console.WriteLine($"Стаж: {teacher.TeachingExperience}");
Console.WriteLine($"Зарплата: {teacher.Salary}");
Console.WriteLine($"Позиция: {teacher.Position}");
Console.WriteLine($"Дата приема на работу: {teacher.HireDate}");





