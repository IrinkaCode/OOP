//Задача 6
//Создать класс «Аэробус», включающий данные-элементы: номер рейса, количество мест I класса, количество мест II класса, количество мест III класса. Функции-элементы:
//создание и инициализация (конструктор),
//количество пассажиров, вышедших из каждого класса в промежуточном аэропорту (в аргументе),
//количество билетов каждого класса, проданных на промежуточной станции (в аргументе)
//выдача сообщения о количестве свободных мест,
//деструктор.

//using Lesson5_DZ_;

//Airbus myAirbus = new Airbus(123, 20, 30, 150);
//// Пассажиры, вышедшие в промежуточном аэропорту
//myAirbus.PassengersExited(5, 10, 20);
//// Билеты, проданные на промежуточной станции
//myAirbus.TicketsSold(2, 5, 15);
//// Сообщение о количестве свободных мест
//myAirbus.FreeSeats();


//Задача 12
//Создать класс «Библиотечный абонемент», включающий данные-элементы: название учебника по С++, автор, шифр, количество на абонементе, количество в читальном зале. Функции-элементы:
//создание и инициализация (конструктор),
//взятые с абонемента и из читального зала учебники (количество тех и других – в аргументе),
//возвращенные учебники (количество тех и других – в аргументе),
//выдача сообщения об имеющемся в наличии количестве учебников (на абонементе и читальном зале),
//деструктор.

using Lesson5_DZ_;

LibraryLoan libraryLoan1 = new LibraryLoan("C# Programming", "John Sat", 13, 10, 5);
LibraryLoan libraryLoan2 = new LibraryLoan("C# Prog", "Tom Ford", 45, 15, 3);

libraryLoan1.TakenFromSubscription(5);
Console.WriteLine($"Количество взятых книг с абонемента: {5}");
libraryLoan2.TakenFromReadingRoom(2);
Console.WriteLine($"Количество взятых книг с читального зала: {2}");
Console.WriteLine();

libraryLoan1.ReturnedFromSubscription(3);
Console.WriteLine($"Количество возвращенных книг с абонемента: {3}");
libraryLoan2.ReturnedFromReadingRoom(1);
Console.WriteLine($"Количество возвращенных книг с абонемента: {1}");
Console.WriteLine();

libraryLoan1.AvailabilityOnSubscription();
Console.WriteLine();
libraryLoan2.AvailabilityOnReadingRoom();
Console.WriteLine();
Console.WriteLine($"Оставшееся количество книг в абонементе: {libraryLoan1.quantityOnSubscription}");
Console.WriteLine($"Оставшееся количество книг в читальном зале: {libraryLoan2.quantityInReadingRoom}");
