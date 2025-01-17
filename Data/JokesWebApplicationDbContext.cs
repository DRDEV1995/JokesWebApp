﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWebApp.Models;

namespace JokesWebApp.Data
{
    public class JokesWebApplicationDbContext : DbContext
    {
        public JokesWebApplicationDbContext (DbContextOptions<JokesWebApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<JokesWebApp.Models.Joke> Joke { get; set; }
    }
}
