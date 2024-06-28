// Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран. Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.

using Lesson7_DZ_.Russia;
using Lesson7_DZ_.Italy;
using Lesson7_DZ_.Poland;

Moscow moscow = new Moscow(13149803);
Warsaw warsaw = new Warsaw(1861644);
Rome rome = new Rome(2870515);
if (moscow.number > warsaw.number)
{
    Console.WriteLine("Население Москвы больше чем население Рима");
}
if (moscow.number < rome.number)
{
    Console.WriteLine("Население Москвы больше чем население Рима");
}
if (warsaw.number > rome.number)
{
    Console.WriteLine("Население Варшавы больше чем население Рима");
}
if (warsaw.number < rome.number)
{
    Console.WriteLine("Население Варшавы больше чем население Рима");
}
