using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string ISBN { get; set; } = default!;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int Year { get; set; }
        public bool IsInStock { get; set; }
    }
}
