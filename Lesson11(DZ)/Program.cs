//Задача на взаимодействие между классами. Разработать систему «Автобаза». Диспетчер распределяет заявки на Рейсы между Водителями и назначает для этого Автомобиль. Водитель может сделать заявку на ремонт. Диспетчер может отстранить Водителя от работы. Водитель делает отметку о выполнении Рейса и состоянии Автомобиля.

// Создание объектов
using Lesson11_DZ_;

Avto avto1 = new Avto { Model = "Toyota", Year = 2020 };
Avto avto2 = new Avto { Model = "Honda", Year = 2018 };
Driver driver1 = new Driver { Name = "John Smith" };
Driver driver2 = new Driver { Name = "Jane Broun" };

Dispatcher dispatcher = new Dispatcher();
dispatcher.AddCar(avto1);
dispatcher.AddCar(avto2);
dispatcher.AddDriver(driver1);
dispatcher.AddDriver(driver2);

// Назначение рейсов
dispatcher.AssignTrip(driver1, avto1);
dispatcher.AssignTrip(driver2, avto2);

// Водитель делает заявку на ремонт
driver1.RequestRepair();

// Диспетчер отстраняет водителя от работы
dispatcher.SuspendDriver(driver2);
