using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public ICollection<Rental>? Rentals { get; set; }
    }
}
