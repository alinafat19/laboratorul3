using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace laboratorul2.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set; } // Colecția de cărți asociate acestei categorii
    }
}
