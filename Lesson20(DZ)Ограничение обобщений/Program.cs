//Задание: "Менеджер приюта для животных"
//Вы разрабатываете систему для управления приютом. Ваша задача -создать классы и интерфейсы, используя ограничения обобщений, чтобы облегчить работу с приемкой и ведением документации о животных.
//Создайте класс Animal, представляющий животное. У этого класса должны
//быть следующие свойства:
//NickName(строка) - кличка животного,
//Breed (строка) - порода,
//AcceptanceDate (дата) - дата поступления животного.
//Age (число) - возраст животного

//Создайте интерфейс IListAnimal, который будет представлять собой
//элемент списка животных. Этот интерфейс должен иметь свойство
//Id (Число) - уникальный номер животного.

//Создайте класс Animals<T>, который будет представлять животных, таких
//как собаки, кошки, тигры и т. д. В классе Animals<T> должна быть
//коллекция элементов типа T.

//Реализуйте ограничение обобщения в классе Animals<T>, чтобы оно
//принимало только типы, реализующие интерфейс IListAnimal.

//Создайте методы для добавления элемента в список животных и
//получения списка всех животных.
//AddAnimal() - для добавления животного со всеми его параметрами
//GetAnimals() - для получения всех объектов животных
//Создайте метод для поиска животного по его Id в списке.
//GetConcreteAnimal() - возвращает объект типа T

//Напишите простой код для создания объекта класса Animals<Animal>,добавления нескольких животных в перечень, и вывода списка животных с их параметрами.

using Lesson20_DZ_Ограничение_обобщений;

Animals<Animal> animals = new Animals<Animal>();

animals.AddAnimal(new Animal(1, "Buddy", "Golden Retriever", DateTime.Now, 3));
animals.AddAnimal(new Animal(2,"Mittens", "Siamese Cat", DateTime.Now, 2));
animals.AddAnimal(new Animal(3,"Leo", "Bengal Tiger", DateTime.Now, 5));

//список всех животных
List <Animal> animalList = animals.GetAnimals();

// Выводим информацию о каждом животном
Console.WriteLine("Список животных:");
foreach (var animal in animalList)
{
    Console.WriteLine($"ID: {animal.Id}, NickName: {animal.NickName}, Breed: {animal.Breed}, " +
                      $"AcceptanceDate: {animal.AcceptanceDate.ToString()}, Age: {animal.Age}");
}

// Пример поиска животного по ID
int searchId = 2;
Animal foundAnimal = animals.GetConcreteAnimal(searchId);
if (foundAnimal != null)
{
    Console.WriteLine($"\nЖивотное с ID {searchId} найдено:");
    Console.WriteLine($"NickName: {foundAnimal.NickName}, Breed: {foundAnimal.Breed}");
}
else
{
    Console.WriteLine($"Животное с ID {searchId} не найдено.");
}
    
