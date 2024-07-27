using Lesson_15_2_JSON;
using System.Text.Json;
using System.Text.Json.Serialization;


//var options = new JsonSerializerOptions
//{
//    WriteIndented = true,
//    PropertyNamingPolicy=JsonNamingPolicy.CamelCase,
//    DefaultIgnoreCondition= System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
//};

//Person person = new Person("Tom", 40);
//string json = JsonSerializer.Serialize(person,options);
//Console.WriteLine(json);

//Person? restorePerson= JsonSerializer.Deserialize<Person>(json);
//Console.WriteLine(restorePerson!.Name + " " + restorePerson.Age);

//List<Person> persons = new List<Person>();
//persons.Add(person);
//persons.Add(new Person("Jerry",45));
//persons.Add(new Person("Sam", 30));
//persons.Add(new Person("Bill", 28));

//string jsonList= JsonSerializer.Serialize(persons);
//Console.WriteLine(jsonList);
//List<Person>fronJson = JsonSerializer.Deserialize<List<Person>>(jsonList);
//foreach(Person p in fronJson)
//{
//    Console.WriteLine(p!.Name + " " + p.Age);
//}



//class Person
//{


//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public string Name { get; set; }
//    [JsonPropertyName("firstName")]
//    public int Age { get; set; }
// // [JsonIgnore]
//}

List<Product> products = new List<Product>
{
    new Product{Name="Хлеб",Count=20,Description="Белый",Price=40},
        new Product{Name="Соль",Count=5,Description="Каменная",Price=10},
            new Product{Name="Вода",Count=3,Description="Газированная",Price=20},
};
//string json = JsonSerializer.Serialize(products);
//using (FileStream fs = new FileStream("products.json",FileMode.OpenOrCreate))
//{
//    await JsonSerializer.SerializeAsync(fs, products);
//}
using (FileStream fs = new FileStream("products.json", FileMode.OpenOrCreate))
{
    List<Product> list = await JsonSerializer.DeserializeAsync<List<Product>>(fs);
    foreach (Product product in list)
    {
        Console.WriteLine(product.Name+" "+product.Description+" "+product.Count+" "+product.Price);
    }
}
