using AspNetCoreTodo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> GetIncompleteItemsAsync();
    }
}
