using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> GetIncompleteItemsAsync()
        {
            return await _context.Items
                .Where(x => x.IsDone == false)
                .ToListAsync();
        }

        public async Task<bool> AddItemAsync(TodoItemDTO newItem)
        {
            var item = new TodoItem
            {
                Id = Guid.NewGuid(),
                Title = newItem.Title,
                IsDone = false,
                DueAt = newItem.DueAt
            };

            _context.Items.Add(item);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> MarkDoneAsync(Guid id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return false;
            item.IsDone = true;
            return await _context.SaveChangesAsync() == 1;
        }
    }
}
