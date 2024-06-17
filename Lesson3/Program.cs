using Lesson3;

Person p1 = new Person() { Name = "Иванов И.И." };
Person p2 = new Person() { Name = "Петров П.П." };
Person p3 = new Person() { Name = "Сидоров С.И." };

Person[] persons = new Person[3];
persons[0] = p1;
persons[1] = p2;
persons[2] = p3;

Company company = new Company { Personal = persons};
Console.WriteLine(company.Personal[0].Name);//без индексатора
Console.WriteLine(company[0].Name);//с индексатором

User user = new User();
user["name"] = "Иванов И.И.";
user["email"] = "mail@inbox.ru";
user["phone"] = "+7(952)-114-17-24";


Console.WriteLine(user["name"] + " " + user["email"] + " " + user["phone"]);

Random random = new Random();
int[,] mas = new int[3, 4];

for (int i = 0; i < mas.GetLength(0); i++)
{
	for (int j = 0; j < mas.GetLength(1); j++)
	{
		mas[i, j] = random.Next(10, 100);
    }
    Console.WriteLine();
}

Matrix matrix = new Matrix(mas);
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


//Создать класс, содержащий динамический массив и количество элементов в нем. Добавить конструктор, который выделяет память под заданное количество элементов, и деструктор. Реализовать индексатор. Добавить методы, позволяющие заполнять массив случайными числами, переставлять в данном массиве элементы в случайном порядке, находить количество различных элементов в массиве, выводить массив на экран.
Massiv massiv = new Massiv(10);
massiv.Fill();
massiv.Print();

massiv.Mix();
massiv.Print();

Console.WriteLine(massiv.Different());