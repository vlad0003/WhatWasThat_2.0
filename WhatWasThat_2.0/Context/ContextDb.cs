using Microsoft.EntityFrameworkCore;
using WhatWasThat_2._0.Models;

namespace WhatWasThat_2._0.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        { 
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
