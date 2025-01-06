using Tema22_DZ__Практика;

User.LoadUsers();
bool running = true;

while (running)
{
    Console.WriteLine("Выберите действие: ");
    Console.WriteLine("1. Зарегистрировать пользователя");
    Console.WriteLine("2. Выход");
    Console.WriteLine();
    string option = Console.ReadLine()!;
    Console.WriteLine();
    switch (option)
    {
        case "1":
            try
            {
                Console.Write("Введите имя пользователя: ");
                string username = Console.ReadLine()!;

                Console.Write("Введите пароль: ");
                string password = Console.ReadLine()!;

                Console.Write("Введите Email: ");
                string email = Console.ReadLine()!;

                User newUser = new User(username, password, email);
                Console.WriteLine("Пользователь успешно зарегистрирован!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            break;

        case "2":
            running = false;
            break;

        default:
            Console.WriteLine("Неверный вариант. Попробуйте еще раз.");
            break;
    }
}
        