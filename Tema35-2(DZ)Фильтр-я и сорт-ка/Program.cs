//Домашнее задание. Фильтрация и сортировка.
//Считайте данные из CSV-файла в список объектов в методе Main
//Выполните следующий запрос:
//1.Отсортируйте фильмы по убыванию даты.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

string filePath = @"C:\Users\pil02\Desktop\Movies.csv";
List<Movie> movies;

using (var reader = new StreamReader(filePath))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    // Чтение записей из CSV
    movies = csv.GetRecords<Movie>().ToList();
}

// Сортировка фильмов по убыванию года выпуска
var sortedMovies = movies.OrderByDescending(m => m.Year);

// Вывод результатов в консоль
foreach (var movie in sortedMovies)
{
    Console.WriteLine($"Id: {movie.Id}, Name: {movie.Name}, Year: {movie.Year}, Director: {movie.Director}, Genre: {movie.Genre}, Rating: {movie.Graduate}");
}

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public double Graduate { get; set; } 

    public Movie() { }

    public Movie(int id, string name, int year, string director, string genre, double graduate)
    {
        Id = id;
        Name = name;
        Year = year;
        Director = director;
        Genre = genre;
        Graduate = graduate;
    }
}
