using System.Collections.Generic;
using WhatWasThat_2._0.Context;
using WhatWasThat_2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace WhatWasThat_2._0.Data.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly ContextDb _context;

        public SqlRepository(ContextDb context)
        { 
            _context = context;
        }

        public void AddTodo(string todoName)
        {
            TodoItem newItem = new TodoItem()
            {
                Title = todoName,
                IsDone = false
            };

            _context.TodoItems.Add(newItem);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var deletedItem = _context.TodoItems.Find(id);

            if (deletedItem != null)
            { 
                _context.TodoItems.Remove(deletedItem);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TodoItem> GetAllItems()
        {
            return _context.TodoItems;
        }

        public void ValueChanger(TodoItem changedItem)
        {
            var item = _context.TodoItems.Attach(changedItem);
            item.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
