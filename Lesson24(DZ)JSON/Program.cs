using Lesson24_DZ_JSON;

Library library = new Library();

library.AddBook(new Book("Война и мир", "Толстой Л.Н.", "Роман", 1863));
library.AddBook(new Book("Преступление и наказание", "Достоевский Ф.М.", "Роман", 1865));
library.AddBook(new Book("Война миров", "Герберт Уэллс", "Ужасы", 1897));

Console.WriteLine("Книги в библиотеке:");
library.DisplayBooks();

string filePath = "library.json";
library.SerializeToJson(filePath);

Library newLibrary = new Library();
newLibrary.DeserializeFromJson(filePath);

Console.WriteLine($"\nСписок книг сохранен в файл: {filePath}");

Console.WriteLine("\nЗагруженные книги из файла:");
newLibrary.DisplayBooks();