using AspNetCoreTodo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> GetIncompleteItemsAsync();
        Task<bool> AddItemAsync(TodoItemDTO newItem);
        Task<bool> MarkDoneAsync(Guid id);
    }
}
