﻿
using E_Commerce.Services.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Services.ShoppingCartAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public  DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
       
    }
}
