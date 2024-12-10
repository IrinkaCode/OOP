//Домашнее задание
//Задание: Список контактов.
//Создайте таблицу для хранения и управления контактами, включая имена, адреса, номера телефонов и электронные адреса.
//Используя средства разработки, сформируйте таблицу для работы со списком контактов
//Рекомендуется использовать Windows Forms, но вы можете использовать для управления и консоль.
//Необходимо дать пользователю возможность добавлять контакты в список.
//Строка контакта должна содержать:
//Имя контакта
//Адрес
//Номер телефона
//Электронный адрес
//Необходимо реализовать возможность добавления контакта, удаления по имени контакта, перезапись отдельных ячеек контакта

using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using Tema28_DZ__Работа_с_формулами;

class Program
{
    static List<Contact> contacts = new List<Contact>();
    static string filePath = "contacts.xlsx";

    static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        using (ExcelPackage package = new ExcelPackage(filePath))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets["Лист1"] ?? package.Workbook.Worksheets.Add("Лист1");
            LoadContactsFromExcel(worksheet);

            while (true)
            {
                Console.WriteLine("1. Добавить контакт");
                Console.WriteLine("2. Удалить контакт");
                Console.WriteLine("3. Редактировать контакт");
                Console.WriteLine("4. Показать все контакты");
                Console.WriteLine("5. Сохранить и выйти");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        RemoveContact();
                        break;
                    case "3":
                        UpdateContact();
                        break;
                    case "4":
                        ShowContacts();
                        break;
                    case "5":
                        SaveContactsToExcel(package);
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }

    static void LoadContactsFromExcel(ExcelWorksheet worksheet)
    {
        int rowCount = worksheet.Dimension?.Rows ?? 0;
        for (int i = 1; i <= rowCount; i++)
        {
            var contact = new Contact
            {
                Name = worksheet.Cells[i, 1].Text,
                Address = worksheet.Cells[i, 2].Text,
                PhoneNumber = worksheet.Cells[i, 3].Text,
                Email = worksheet.Cells[i, 4].Text
            };
            contacts.Add(contact);
        }
    }

    static void SaveContactsToExcel(ExcelPackage package)
    {
        var worksheet = package.Workbook.Worksheets["Лист1"] ?? package.Workbook.Worksheets.Add("Лист1");
        worksheet.Cells[1, 1].Value = "Имя";          
        worksheet.Cells[1, 2].Value = "Адрес";        
        worksheet.Cells[1, 3].Value = "Телефон";       
        worksheet.Cells[1, 4].Value = "Электронная почта"; 

       // worksheet.Cells.Clear(); 

        for (int i = 0; i < contacts.Count; i++)
        {
            worksheet.Cells[i + 2, 1].Value = contacts[i].Name;
            worksheet.Cells[i + 2, 2].Value = contacts[i].Address;
            worksheet.Cells[i + 2, 3].Value = contacts[i].PhoneNumber;
            worksheet.Cells[i + 2, 4].Value = contacts[i].Email;
        }

        worksheet.Cells["A1:D1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
        worksheet.Cells["A1:D1"].Style.Fill.BackgroundColor.SetColor(Color.Violet);
        worksheet.Cells["A1:D1"].Style.Font.Bold = true;

        worksheet.Column(1).Width = 20;
        worksheet.Column(2).Width = 25;
        worksheet.Column(3).Width = 30;
        worksheet.Column(4).Width = 40;
        try
        {
            package.Save();
            Console.WriteLine("Контакты сохранены в Excel.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении: {ex.Message}");
        }
    }


    static void AddContact()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine()!;
        Console.Write("Введите адрес: ");
        string address = Console.ReadLine()!;
        Console.Write("Введите номер телефона: ");
        string phoneNumber = Console.ReadLine()!;
        Console.Write("Введите электронный адрес: ");
        string email = Console.ReadLine()!;

        contacts.Add(new Contact { Name = name, Address = address, PhoneNumber = phoneNumber, Email = email });
        Console.WriteLine("Контакт добавлен.");
    }

    static void RemoveContact()
    {
        Console.Write("Введите имя контакта для удаления: ");
        string name = Console.ReadLine()!;
        Contact contactToRemove = contacts.Find(c => c.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) == true);

        if (contactToRemove != null)
        {
            contacts.Remove(contactToRemove);
            Console.WriteLine("Контакт удален.");
        }
        else
        {
            Console.WriteLine("Контакт не найден.");
        }
    }

    static void UpdateContact()
    {
        Console.Write("Введите имя контакта для редактирования: ");
        string name = Console.ReadLine()!;
        Contact contactToUpdate = contacts.Find(c => c.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) == true);

        if (contactToUpdate != null)
        {
            Console.Write("Введите новое имя (или оставьте пустым для пропуска): ");
            string newName = Console.ReadLine()!;
            Console.Write("Введите новый адрес (или оставьте пустым для пропуска): ");
            string newAddress = Console.ReadLine()!;
            Console.Write("Введите новый номер телефона (или оставьте пустым для пропуска): ");
            string newPhoneNumber = Console.ReadLine()!;
            Console.Write("Введите новый электронный адрес (или оставьте пустым для пропуска): ");
            string newEmail = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(newName)) contactToUpdate.Name = newName;
            if (!string.IsNullOrEmpty(newAddress)) contactToUpdate.Address = newAddress;
            if (!string.IsNullOrEmpty(newPhoneNumber)) contactToUpdate.PhoneNumber = newPhoneNumber;
            if (!string.IsNullOrEmpty(newEmail)) contactToUpdate.Email = newEmail;

            Console.WriteLine("Контакт обновлен.");
        }
        else
        {
            Console.WriteLine("Контакт не найден.");
        }
    }

    static void ShowContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Список контактов пуст.");
            return;
        }

        Console.WriteLine("Список контактов:");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
}




