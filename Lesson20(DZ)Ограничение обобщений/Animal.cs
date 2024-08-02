using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_DZ_Ограничение_обобщений
{
    public class Animal : IListAnimal
    {
        public Animal( int id, string? nickName, string? breed, DateTime? acceptanceDate, int? age)
        {
            Id = id;
            NickName = nickName;
            Breed = breed;
            AcceptanceDate = acceptanceDate;
            Age = age;
        }
        public int Id { get;  private set; }
        public string? NickName { get; set; }
        public string? Breed {  get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public int? Age { get; set; }

    }
    public interface IListAnimal
    {
        int Id { get; }
    }
    public class Animals<T> where T : IListAnimal
    {
        private List<T> animalList = new List<T>();

        public void AddAnimal(T animal)
        {
            animalList.Add(animal);
        }

        public List<T> GetAnimals()
        {
            return animalList;
        }

        public T GetConcreteAnimal(int id)
        {
            return animalList.Find(animal => animal.Id == id)!;
        }
    }

}
