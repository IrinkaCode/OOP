//Создать класс, содержащий динамический массив и количество элементов в нем. Добавить конструктор, который выделяет память под заданное количество элементов, и деструктор. Добавить методы, позволяющие заполнять массив случайными числами, переставлять в данном массиве элементы в случайном порядке, находить количество различных элементов в массиве, выводить массив на экран.

//using Lesson2_DZ_;

//Massiv massiv = new Massiv(10);
//massiv.Fill();
//massiv.Print();

//massiv.Mix();
//massiv.Print();

//Console.WriteLine(massiv.Different());

//Описать класс «домашняя библиотека». Предусмотреть возможность работы с произвольным числом книг, поиска книги по какому-либо признаку (например, по автору или по году издания), добавления книг в библиотеку, удаления книг из нее, сортировки книг по разным полям.

using Lesson2_DZ_;

var library = new HomeLibrary();

var book1 = new Book { Title = "Буратино", Author = "Толстой", Year = 2021 };
var book2 = new Book { Title = "Незнайка", Author = "Носов", Year = 2020 };
var book3 = new Book { Title = "Дюймовочка", Author = "Андерсен", Year = 2018 };

library.AddBook(book1);//добавление книг
library.AddBook(book2);
library.AddBook(book3);

Console.WriteLine("Библиотека отсортированная по названию:");
library.SortByTitle();
library.PrintLibrary();

Console.WriteLine("\nБиблиотека отсортированная по автору:");
library.SortByAuthor();
library.PrintLibrary();

Console.WriteLine("\nБиблиотека отсортированная по году:");
library.SortByYear();
library.PrintLibrary();

Console.WriteLine("\nКнига от автора 1:");//поиск книги по автору
var authorBooks = library.FindByAuthor("Носов");

foreach (var book in authorBooks)
{
    Console.WriteLine($"Название: {book1.Title}, автор: {book.Author}, год: {book1.Year}");
}

Console.WriteLine("\nКнига опубликованная в 2020:");//поиск книги по году
var yearBooks = library.FindByYear(2020);
foreach (var book in yearBooks)
{
    Console.WriteLine($"Название: {book.Title}, автор: {book.Author}");
}
Console.WriteLine();

library.RemoveBook(book2);//удаление книги
library.PrintLibrary();
    