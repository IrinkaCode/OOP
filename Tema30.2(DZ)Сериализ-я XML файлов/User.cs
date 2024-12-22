using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema30._2_DZ_Сериализ_я_XML_файлов
{
    [Serializable]
    internal class User
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
