using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMatchingWebsite.Models
{
    public class PersonFilterViewModel
    {
        public List<Person> people;
        public List<PersonTwo> peopletwo;
        public List<Results> results;

        

        public SelectList columnnames;
        public SelectList firstnames;
        public SelectList surnames;
        public SelectList legalsurnames;
        public SelectList dob;

        public string personFirstName { get; set; }
        public string personSurname { get; set; }
        public string personLegalSurname { get; set; }
        public string personDoB { get; set; }

    }
}
