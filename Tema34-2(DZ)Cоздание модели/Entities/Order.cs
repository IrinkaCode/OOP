using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema34_2_DZ_Cоздание_модели.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // Внешний ключ для пользователя
        public int UserId { get; set; }

        // Навигационное свойство для пользователя
        public User User { get; set; }

        // Навигационное свойство для продуктов
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
