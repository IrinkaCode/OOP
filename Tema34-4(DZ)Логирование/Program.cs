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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;



IConfigurationRoot configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("jsconfig1.json").Build();

var serviceProvider = new ServiceCollection()
    .AddDbContext<ShopContext>(options => options.EnableServiceProviderCaching())

    //UseSqlServer(configuration.GetConnectionString("DefaultConnection")))

    .AddLogging(builder =>
    {
        builder.AddFilter(configuration["Logging:FileLogging:DebugLogPath"], LogLevel.Debug);
        builder.AddFilter(configuration["Logging:FileLogging:ErrorLogPath"], LogLevel.Error);
    })
    .BuildServiceProvider();

using (var context = serviceProvider.GetService<ShopContext>())
{
    var logger = serviceProvider.GetService<ILogger<Program>>();
    logger.LogInformation("Приложение запущено.");

}

public class ShopContext : DbContext
{
    public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
}


