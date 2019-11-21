using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using M_app.MarvelApi;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;







namespace M_app.Models
{
    public class ElContext : DbContext
    {

        public ElContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Character> elchar { get; set; }

    }

}