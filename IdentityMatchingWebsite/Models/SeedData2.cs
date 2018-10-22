using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace IdentityMatchingWebsite.Models
{
    public static class SeedData2
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IdentityMatchingWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<IdentityMatchingWebsiteContext>>()))
            {
                // Look for any people.
                if (context.PersonTwo.Any())
                {
                    return;   // DB has been seeded
                }

                context.PersonTwo.AddRange(
                     new PersonTwo
                     {
                         FirstName = "Sam",
                         Surname = "Franks",
                         LegalSurname = "Franks",
                         DateOfBirth = "23/11/1989"
                     },

                     new PersonTwo
                     {
                         FirstName = "Sam",
                         Surname = "Tran",
                         LegalSurname = "Tran",
                         DateOfBirth = "29/02/2000"
                     },

                      new PersonTwo
                      {
                          FirstName = "Joe",
                          Surname = "Swanson",
                          LegalSurname = "Swanson",
                          DateOfBirth = "23/11/1989"
                      },

                       new PersonTwo
                       {
                           FirstName = "Eric",
                           Surname = "Tran",
                           LegalSurname = "Tran",
                           DateOfBirth = "23/11/1980"
                       },

                        new PersonTwo
                        {
                            FirstName = "Emily",
                            Surname = "Smith",
                            LegalSurname = "Smith",
                            DateOfBirth = "16/08/1977"
                        },

                         new PersonTwo
                         {
                             FirstName = "Steve",
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