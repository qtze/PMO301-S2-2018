using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace IdentityMatchingWebsite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IdentityMatchingWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<IdentityMatchingWebsiteContext>>()))
            {
                // Look for any people.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                     new Person
                     {
                         FirstName = "Steve",
                         Surname = "Smith",
                         LegalSurname = "Smith",
                         DateOfBirth = "13/03/1997"
                     },

                     new Person
                     {
                         FirstName = "James",
                         Surname = "Franks",
                         LegalSurname = "Franks",
                         DateOfBirth = "29/02/2000"
                     },

                      new Person
                      {
                          FirstName = "Eric",
                          Surname = "Harden",
                          LegalSurname = "Harden",
                          DateOfBirth = "23/11/1980"
                      },

                       new Person
                       {
                           FirstName = "James",
                           Surname = "Samson",
                           LegalSurname = "Samson",
                           DateOfBirth = "23/11/1980"
                       },

                        new Person
                        {
                            FirstName = "Guy",
                            Surname = "Tran",
                            LegalSurname = "Tran",
                            DateOfBirth = "16/08/1977"
                        },

                         new Person
                         {
                             FirstName = "Sam",
                             Surname = "Swanson",
                             LegalSurname = "Swanson",
                             DateOfBirth = "13/03/1997"
                         }

                );
                context.SaveChanges();
            }
        }
    }
}