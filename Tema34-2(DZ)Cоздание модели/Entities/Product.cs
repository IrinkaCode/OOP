using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema34_2_DZ_Cоздание_модели.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        // Навигационное свойство для категории
        public Category Category { get; set; }

        // Внешний ключ для категории
        public int CategoryId { get; set; }
    }
}
