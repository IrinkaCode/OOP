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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

// Загрузка конфигурации из appsettings.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

// Настройка логгера
var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddConfiguration(configuration.GetSection("Logging"))
        .AddConsole()
        .AddFile(configuration["Logging:FileDebug:Path"], minimumLevel: LogLevel.Debug)
        .AddFile(configuration["Logging:FileError:Path"], minimumLevel: LogLevel.Error);
});

ILogger logger = loggerFactory.CreateLogger<Program>();

// Получение строки подключения
string connectionString = configuration.GetConnectionString("DefaultConnection");

// Подключение к базе данных
using (var connection = new MySqlConnection(connectionString))
{
    try
    {
        connection.Open();
        logger.LogInformation("Подключение к базе данных успешно установлено.");

    }
    catch (Exception ex)
    {
        logger.LogError($"Ошибка при подключении к базе данных: {ex.Message}");
    }
}


