﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            :base(options)
        {

        }
        public DbSet<ToDoItem> TodoItems { get; set; }
        public object ToDoItems { get; internal set; }
        public object ToDoItem { get; internal set; }
    }
}
