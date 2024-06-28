//Перегрузка операций


//using Lesson8;

//Complex c1 = new Complex { Re = 4, Im = 3 };
//Complex c2 = new Complex { Re = 4, Im = 3 };
//Complex c3 = new Complex { Re = 8, Im = 12 };

//Complex z1 = c1 + c2;
//Console.WriteLine(c1==c2);
//Console.WriteLine(c1==c3);

//Console.WriteLine(z1);
//Complex z2 = c1 + c3;
//Console.WriteLine(z2);
//Complex z3 = c1 * c2;
//Console.WriteLine(z3);
//Complex z4=c1/c2;
//Console.WriteLine(z4);
//Complex z5=c1/c3;
//Console.WriteLine(z5);


//Person p1 = new Person { FIO = "Иванов И.И.", Balance = 5000 };
//Person p2 = new Person { FIO = "Петров Д.К.", Balance = 400000 };
//if(p1 == p2)
//    Console.WriteLine("==");

//Console.WriteLine(p1+p2);

using Lesson8;
using System.Drawing;

Rectangle rect = new Rectangle { Width = 5, Height = 10, Name = "Прямоугольник" };
Console.WriteLine(rect.Name+" "+rect.getPerimetr() + " " + rect.getArea());
Circle circle = new Circle { Name = "Окружность", Radius = 40 };
Console.WriteLine(circle.getPerimetr()+" "+circle.getArea());
Cube cube = new Cube { Name = "Куб", Height = 20 };
Console.WriteLine(cube.getArea()+" "+cube.getVolume());
