﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using biblioteca.Models;

namespace biblioteca.Data
{
    public class bibliotecaContext : DbContext
    {
        public bibliotecaContext (DbContextOptions<bibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<biblioteca.Models.Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;

        public DbSet<Author> Author { get; set; } = default!;
    }
}
