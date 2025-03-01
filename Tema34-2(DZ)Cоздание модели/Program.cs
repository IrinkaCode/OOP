using Microsoft.EntityFrameworkCore;
using Tema34_2_DZ_Cоздание_модели;
using Tema34_2_DZ_Cоздание_модели.Entities;

var optionsBuilder = new DbContextOptionsBuilder<OnlineShopContext>();
optionsBuilder.UseMySql("server=localhost;database=OnlineShop;user=root;password=000000;", new MySqlServerVersion(new Version(8, 0, 23)));

using (var context = new OnlineShopContext(optionsBuilder.Options))
{
    // Создание категорий
    var foodCategory = new Category("Еда", "Продукты питания");
    var toolsCategory = new Category("Инструменты", "Различные инструменты");

    context.Categories.AddRange(foodCategory, toolsCategory);
    context.SaveChanges();

    // Создание продуктов
    var products = new List<Product>
                {
                    new Product { Name = "Хлеб", Description = "Свежий хлеб", Price = 1.5m, CategoryId = foodCategory.CategoryId },
                    new Product { Name = "Молоко", Description = "Свежее молоко", Price = 2.0m, CategoryId = foodCategory.CategoryId },
                    new Product { Name = "Молоток", Description = "Прочный молоток", Price = 15.0m, CategoryId = toolsCategory.CategoryId },
                    new Product { Name = "Отвертка", Description = "Набор отверток", Price = 10.0m, CategoryId = toolsCategory.CategoryId },
                    new Product { Name = "Яблоки", Description = "Свежие яблоки", Price = 3.0m, CategoryId = foodCategory.CategoryId }
                };

    context.Products.AddRange(products);
    context.SaveChanges();

    // Создание пользователей
    var user1 = new User("User1", "user1@example.com", "password1");
    var user2 = new User("User2", "user2@example.com", "password2");

    context.Users.AddRange(user1, user2);
    context.SaveChanges();

    // Создание заказов
    var order1 = new Order { OrderDate = DateTime.Now, Status = "В обработке", UserId = user1.UserId, Products = new List<Product> { products[0], products[1] } };
    var order2 = new Order { OrderDate = DateTime.Now, Status = "Доставка", UserId = user2.UserId, Products = new List<Product> { products[2], products[3] } };

    context.Orders.AddRange(order1, order2);
    context.SaveChanges();

    // Добавление заказов пользователям
    user1.Orders.Add(order1);
    user2.Orders.Add(order2);

    context.SaveChanges();
}

Console.WriteLine("База данных успешно создана и заполнена!");
        