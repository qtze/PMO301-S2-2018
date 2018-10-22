using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IdentityMatchingWebsite.Models
{
    public class IdentityMatchingWebsiteContext : DbContext
    {
        public IdentityMatchingWebsiteContext (DbContextOptions<IdentityMatchingWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<IdentityMatchingWebsite.Models.Person> Person { get; set; }
        public DbSet<IdentityMatchingWebsite.Models.PersonTwo> PersonTwo { get; set; }
        public DbSet<IdentityMatchingWebsite.Models.Results> Results { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AFTS;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Person>().HasData(
                new
                {
                    ID = 1,
                    FirstName = "Steve",
                    Surname = "Smith",
                    LegalSurname = "Smith",
                    DateOfBirth = "13/03/1997"
                },
                new
                {
                    ID = 2,
                    FirstName = "James",
                    Surname = "Franks",
                    LegalSurname = "Franks",
                    DateOfBirth = "29/02/2000"
                },
                new
                {
                    ID = 3,
                    FirstName = "Eric",
                    Surname = "Harden",
                    LegalSurname = "Harden",
                    DateOfBirth = "23/11/1980"
                },
                new
                {
                    ID = 4,
                    FirstName = "James",
                    Surname = "Samson",
                    LegalSurname = "Samson",
                    DateOfBirth = "23/11/1980"
                },
                 new
                {
                    ID = 5,
                    FirstName = "Guy",
                    Surname = "Hammer",
                    LegalSurname = "Hammer",
                    DateOfBirth = "16/08/1977"
                 },
                new
                {
                    ID = 6,
                    FirstName = "Sam",
                    Surname = "Swanson",
                    LegalSurname = "Swanson",
                    DateOfBirth = "13/03/1997"
                },
                new
                {
                    ID = 7,
                    FirstName = "Sarah",
                    Surname = "Morgan",
                    LegalSurname = "Smith",
                    DateOfBirth = "6/08/1977"
                },
                new
                {
                    ID = 8,
                    FirstName = "Hugh",
                    Surname = "Mungus",
                    LegalSurname = "Mungus",
                    DateOfBirth = "13/03/1966"
                });

                modelBuilder.Entity<PersonTwo>().HasData(
                new
                {
                    ID = 1,
                    FirstName = "Steve",
                    Surname = "Smith",
                    LegalSurname = "Smith",
                    DateOfBirth = "13/03/1997"
                },
                new
                {
                    ID = 2,
                    FirstName = "Sam",
                    Surname = "Hammer",
                    LegalSurname = "Hammer",
                    DateOfBirth = "	29/02/2000"
                },
                new
                {
                    ID = 3,
                    FirstName = "Joe",
                    Surname = "Swanson",
                    LegalSurname = "Swanson",
                    DateOfBirth = "23/11/1989"
                },
                new
                {
                    ID = 4,
                    FirstName = "Eric",
                    Surname = "Jones",
                    LegalSurname = "Jones",
                    DateOfBirth = "23/11/1980"
                },
                 new
                {
                    ID = 5,
                    FirstName = "Emily",
                    Surname = "Smith",
                    LegalSurname = "Smith",
                    DateOfBirth = "16/08/1977"
                 },
                new
                {
                    ID = 6,
                    FirstName = "Steve",
                    Surname = "Swanson",
                    LegalSurname = "Swanson",
                    DateOfBirth = "13/03/1997"
                },
                new
                {
                    ID = 7,
                    FirstName = "Rebecca",
                    Surname = "Ferguson",
                    LegalSurname = "Mungus",
                    DateOfBirth = "23/11/1970"
                },
                new
                {
                    ID = 8,
                    FirstName = "Sarah",
                    Surname = "Harris",
                    LegalSurname = "Franks",
                    DateOfBirth = "16/08/1962"
                });
        }



    }
    }
