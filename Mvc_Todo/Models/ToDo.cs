using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Todo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public int Importance { get; set; }
    }
}