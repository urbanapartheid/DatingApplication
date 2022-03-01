﻿using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace API.Data
{
    public class DataContext : DbContext
    {
        #region Properties
        public DbSet<AppUser> Users { get; set; }
        #endregion

        #region CTOR
        public DataContext(DbContextOptions options) : base(options)
        {
        } 
        #endregion
    }
}
