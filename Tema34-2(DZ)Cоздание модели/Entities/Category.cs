using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema34_2_DZ_Cоздание_модели.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category() { }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
