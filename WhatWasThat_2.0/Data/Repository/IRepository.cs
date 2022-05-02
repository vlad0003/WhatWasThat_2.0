using System.Collections.Generic;
using WhatWasThat_2._0.Models;

namespace WhatWasThat_2._0.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetAllItems();
        void AddTodo(string todoName);
        void ValueChanger(TodoItem changedItem);
        void DeleteItem(int id);
    }
}
