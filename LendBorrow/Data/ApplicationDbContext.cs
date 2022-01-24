﻿using LendBorrow.Models;
using Microsoft.EntityFrameworkCore;

namespace LendBorrow.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items{ get; set; }
        public DbSet<Expense> Expenses{ get; set; }
       public DbSet<ExpenseType> ExpenseTypes { get; set; }
    }
}
