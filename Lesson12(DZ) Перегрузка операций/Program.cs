// Составить описание класса для вектора, заданного координатами его концов в трехмерном пространстве. Обеспечить операции сложения и вычитания векторов с получением нового вектора (суммы или разности), вычисления скалярного произведения двух векторов, длины вектора, косинуса угла между векторами.
// Создание векторов

using Lesson12_DZ__Перегрузка_операций;

Vector v1 = new Vector(1, 2, 3);
Vector v2 = new Vector(4, 5, 6);

// Сложение и вычитание векторов
Vector sum = v1 + v2;
Vector diff = v1 - v2;

// Скалярное произведение
double sclrProizvedenie = Vector.SclrProizvedenie(v1, v2);

// Длина вектора
double lenght = v1.Length();

// Косинус угла между векторами
double cos = Vector.Cos(v1, v2);

Console.WriteLine("Сумма векторов: ({0}, {1}, {2})", sum.X, sum.Y, sum.Z);
Console.WriteLine("Разность векторов: ({0}, {1}, {2})", diff.X, diff.Y, diff.Z);
Console.WriteLine(sclrProizvedenie);
Console.WriteLine($"{lenght:F2}");
Console.WriteLine($"{cos:F2}");