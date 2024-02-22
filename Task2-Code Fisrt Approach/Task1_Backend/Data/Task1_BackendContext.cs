using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1_Backend.Models;

namespace Task1_Backend.Data
{
    public class Task1_BackendContext : DbContext
    {
        public Task1_BackendContext (DbContextOptions<Task1_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<Task1_Backend.Models.TodoItems> TodoItems { get; set; } = default!;
    }
}
