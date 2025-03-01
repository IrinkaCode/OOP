//Задача.
//На сервере:
//● Создайте базу данных InternetShop
//● Создайте пользователя internet-shop-admin
//● Выдайте ему привилегии на работу с БД
//● Обновите привилегии
//Программа:
//В проекте создайте конфигурационный Json-файл для БД и ее пользователя.
//Пропишите в нем строку подключения.
//Организуйте подключение к базе данных используя конфигурационный json файл.
//Настройте логирование операций в 2 файла:
//1.Дебаг
//2.Ошибки

using System;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

// Загрузка конфигурации из JSON-файла
var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Настройка логирования
using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddFilter("Microsoft", LogLevel.Warning)
        .AddFilter("System", LogLevel.Warning)
        .AddFilter("InternetShop", LogLevel.Debug)
        .AddFilter("debug.log", LogLevel.Debug)
        .AddFilter("errors.log", LogLevel.Error);
});

var logger = loggerFactory.CreateLogger<Program>();

// Получение строки подключения из конфигурации
string connectionString = $"Server={config["Database:169.254.120.188"]};" +
                          $"Database={config["Database:InternetShop"]};" +
                          $"User ID={config["Database:internet-shop-admin"]};" +
                          $"Password={config["Database:000000"]};";

try
{
    using var connection = new MySqlConnection(connectionString);
    connection.Open();
    logger.LogDebug("Успешное подключение к базе данных");
}
catch (MySqlException ex)
{
    logger.LogError($"Ошибка подключения или выполнения запроса: {ex.Message}");
}
catch (Exception ex)
{
    logger.LogError($"Неизвестная ошибка: {ex.Message}");
}