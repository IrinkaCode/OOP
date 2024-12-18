using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29
{
    internal class Nakladnaya:IComparable 
    {
        [DisplayName("Название товара")]
        public string? Name { get; set; }

        [DisplayName("Количество")]
        public string? Quantity { get; set; }

        [DisplayName("Стоимость")]
        public string? Price { get; set; }

        [DisplayName("ФИО поставщик")]
        public string? Provaider { get; set; }

        [DisplayName("ФИО получитель")]
        public string? Recipient { get; set; }

        [DisplayName("Дата оставки")]
        public string? DateOrder { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is Nakladnaya nak) return Name!.CompareTo(nak.Name);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
