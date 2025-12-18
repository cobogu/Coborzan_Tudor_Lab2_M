using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coborzan_Tudor_Lab2_M.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
