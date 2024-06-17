using Lesson4;
using System.Text;

Point p1 = new Point(7, 9);
Point p2 = new Point(12, 10);
Console.WriteLine(Point.count);
Console.WriteLine($"Расстояние между точками:{Point.LengthPoints(p1,p2):F2}");

Person person = new Person(60);
person.CheckAge();
Person.RetirementAge = 70;
person.CheckAge();

//PointStruct ps1= new PointStruct();
//ps1.x = 4;
//ps1.y = 9;


class PointStruct(double x,double y)
{
    public PointStruct(double a) : this(a, 20)
    {

    }

}

 

