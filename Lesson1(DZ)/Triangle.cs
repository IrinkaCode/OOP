using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangle
{
    // Поля для хранения сторон треугольника
    private double _a;
    private double _b;
    private double _c;

    // Конструктор для создания треугольника
    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    // Свойства для получения состояния треугольника
    public double A { get { return _a; } }
    public double B { get { return _b; } }
    public double C { get { return _c; } }

    // Метод для вычисления площади треугольника
    public double Area()
    {
        double p = Perimeter() / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    // Метод для вычисления периметра треугольника
    public double Perimeter()
    {
        return _a + _b + _c;
    }

    // Метод для вычисления точки пересечения медиан треугольника
    public (double, double) MedianIntersection()
    {
        double x = (_a * _a * (_b + _c - _a) + _b * _b * (_a + _c - _b) + _c * _c * (_a + _b - _c)) / (2 * (_a + _b + _c));
        double y = (_a * _a - (x - _a) * (x - _a));
        return (x, y);
    }
}

