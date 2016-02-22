using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using LibraryDataBase.Models;

namespace LibraryDataBase
{
    public class LibraryDB : IdentityDbContext<IdentityUser>
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Book_Author> Book_Author { get; set; }
        public DbSet<Borrow> Borrow { get; set; }
        public DbSet<Borrower> Borrower { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Classification> Classification { get; set; }
        public DbSet<Copy> Copy { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public LibraryDB()
            : base("LibraryDB")
        {

        }
    }
}