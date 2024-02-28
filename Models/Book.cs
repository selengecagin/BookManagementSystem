using System;

namespace BookManagementSystem.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public DateTime DueDate { get; set; }
    }
}
