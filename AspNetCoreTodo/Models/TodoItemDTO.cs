using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class TodoItemDTO
    {
        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }/* = DateTimeOffset.Now.AddDays(3);*/
    }
}
