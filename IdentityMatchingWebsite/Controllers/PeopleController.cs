using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IdentityMatchingWebsite.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

namespace IdentityMatchingWebsite.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IdentityMatchingWebsiteContext _context;
        private IHostingEnvironment _hostingEnvironment;

        public PeopleController(IdentityMatchingWebsiteContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: People


        public async Task<IActionResult> Index(string personFirstName, string personSurname, string personLegalSurname, string personDoB, string searchString)
        {
            // Use LINQ to get list of first names, surnames, legal surnames, and date of birth from the database.


            //---------------------------------------------------------------------------
            var deleteCurrentResults = _context.Results.ToList();

            foreach (var item in deleteCurrentResults)
            {
                _context.Results.Remove(item);
            }


            var personFilterVM = new PersonFilterViewModel();

            //person one's matching
            var people = from p in _context.Person
                         select p;

            var peopletwo = from p in _context.PersonTwo
                            select p;

            var result = from p in _context.Results
                            select p;


            if (personFirstName == "1" && personSurname == null && personLegalSurname == null && personDoB == null)
            {
                var compareFirstNameP1 = from p1 in _context.Person
                                       from p2 in _context.PersonTwo
                                       where p1.FirstName == p2.FirstName
                                       select (p1);

                var compareFirstNameP2 = from p1 in _context.Person
                                       from p2 in _context.PersonTwo
                                       where p1.FirstName == p2.FirstName
                                       select (p2);

                personFilterVM.people = compareFirstNameP1.ToList();
                personFilterVM.peopletwo = compareFirstNameP2.ToList();

                foreach (var item in compareFirstNameP1.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }

                foreach (var item in compareFirstNameP2.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }
                

                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }
            else if (personFirstName == null && personSurname == "2" && personLegalSurname == null && personDoB == null)
            {
                var compareSurnameP1 = from p1 in _context.Person
                                         from p2 in _context.PersonTwo
                                         where p1.Surname == p2.Surname
                                         select (p1);

                var compareSurnameP2 = from p1 in _context.Person
                                         from p2 in _context.PersonTwo
                                         where p1.Surname == p2.Surname
                                         select (p2);

                personFilterVM.people = compareSurnameP1.ToList();
                personFilterVM.peopletwo = compareSurnameP2.ToList();

                foreach (var item in compareSurnameP1.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }

                foreach (var item in compareSurnameP2.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }


                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }
            else if (personFirstName == null && personSurname == null && personLegalSurname == "3" && personDoB == null)
            {
                var compareLegalSurnameP1 = from p1 in _context.Person
                                       from p2 in _context.PersonTwo
                                       where p1.LegalSurname == p2.LegalSurname
                                       select (p1);

                var compareLegalSurnameP2 = from p1 in _context.Person
                                       from p2 in _context.PersonTwo
                                       where p1.LegalSurname == p2.LegalSurname
                                       select (p2);

                personFilterVM.people = compareLegalSurnameP1.ToList();
                personFilterVM.peopletwo = compareLegalSurnameP2.ToList();

                foreach (var item in compareLegalSurnameP1.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }

                foreach (var item in compareLegalSurnameP2.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }


                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }
            else if (personFirstName == null && personSurname == null && personLegalSurname == null && personDoB == "4")
            {
                var compareDateOfBirthP1 = from p1 in _context.Person
                                            from p2 in _context.PersonTwo
                                            where p1.DateOfBirth == p2.DateOfBirth
                                            select (p1);

                var compareDateOfBirthP2 = from p1 in _context.Person
                                            from p2 in _context.PersonTwo
                                            where p1.DateOfBirth == p2.DateOfBirth
                                            select (p2);

                personFilterVM.people = compareDateOfBirthP1.ToList();
                personFilterVM.peopletwo = compareDateOfBirthP2.ToList();


                foreach (var item in compareDateOfBirthP1.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }

                foreach (var item in compareDateOfBirthP2.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }


                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }
            else if (personFirstName == "1" && personSurname == "2" && personLegalSurname == null && personDoB == null)
            {
                var compareFirstNAndLNameP1 = from p1 in _context.Person
                                           from p2 in _context.PersonTwo
                                           where p1.FirstName == p2.FirstName
                                           && p1.Surname == p2.Surname
                                           select (p1);

                var compareFirstNAndLNameP2 = from p1 in _context.Person
                                           from p2 in _context.PersonTwo
                                           where p1.FirstName == p2.FirstName
                                           && p1.Surname == p2.Surname
                                           select (p2);

                personFilterVM.people = compareFirstNAndLNameP1.ToList();
                personFilterVM.peopletwo = compareFirstNAndLNameP2.ToList();

                foreach (var item in compareFirstNAndLNameP1.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }

                foreach (var item in compareFirstNAndLNameP2.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }


                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }
            else if (personFirstName == "1" && personSurname == "2" && personLegalSurname == "3" && personDoB == null)
            {
                var compareFnameLnameAndLSurnameP1 = from p1 in _context.Person
                                           from p2 in _context.PersonTwo
                                           where p1.FirstName == p2.FirstName
                                           && p1.Surname == p2.Surname
                                           && p1.LegalSurname == p2.LegalSurname
                                           select (p1);

                var compareFnameLnameAndLSurnameP2 = from p1 in _context.Person
                                           from p2 in _context.PersonTwo
                                           where p1.FirstName == p2.FirstName
                                           && p1.Surname == p2.Surname
                                           && p1.LegalSurname == p2.LegalSurname
                                           select (p2);

                personFilterVM.people = compareFnameLnameAndLSurnameP1.ToList();
                personFilterVM.peopletwo = compareFnameLnameAndLSurnameP2.ToList();

                foreach (var item in compareFnameLnameAndLSurnameP1.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }

                foreach (var item in compareFnameLnameAndLSurnameP2.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }


                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }

            else if (personFirstName == "1" && personSurname == "2" && personLegalSurname == "3" && personDoB == "4")
            {
                var compareP1All = from p1 in _context.Person
                                       from p2 in _context.PersonTwo
                                       where p1.FirstName == p2.FirstName 
                                       && p1.Surname == p2.Surname
                                       && p1.LegalSurname == p2.LegalSurname
                                       && p1.DateOfBirth == p2.DateOfBirth
                                   select (p1);

                var compareP2All = from p1 in _context.Person
                                   from p2 in _context.PersonTwo
                                   where p1.FirstName == p2.FirstName
                                   && p1.Surname == p2.Surname
                                   && p1.LegalSurname == p2.LegalSurname
                                   && p1.DateOfBirth == p2.DateOfBirth
                                   select (p2);

                personFilterVM.people = compareP1All.ToList();
                personFilterVM.peopletwo = compareP2All.ToList();

                foreach (var item in compareP1All.ToList())
                {
                    var results = new Results
                    {
                        FirstName = item.FirstName,
                        Surname = item.Surname,
                        LegalSurname = item.LegalSurname,
                        DateOfBirth = item.DateOfBirth


                    };
                    _context.Results.Add(results);
                }



                await _context.SaveChangesAsync();

                var resultsList = _context.Results.ToList();
                personFilterVM.results = resultsList;

            }
            else
            {
                personFilterVM.peopletwo = await peopletwo.ToListAsync();
                personFilterVM.people = await people.ToListAsync();


            }


            return View(personFilterVM);
        }


        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,Surname,LegalSurname,DateOfBirth")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        public IActionResult CreateTwo()
        {
            return View();
        }

        // POST: People/CreateTwo
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTwo([Bind("ID,FirstName,Surname,LegalSurname,DateOfBirth")] PersonTwo persontwo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persontwo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persontwo);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> EditTwo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.PersonTwo.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,Surname,LegalSurname,DateOfBirth")] Person person)
        {
            if (id != person.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }


        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTwo(int id, [Bind("ID,FirstName,Surname,LegalSurname,DateOfBirth")] PersonTwo person)
        {
            if (id != person.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.ID == id);
        }



        public async Task<IActionResult> OnPostExport()
        {
            string sWebRootFolder = _hostingEnvironment.WebRootPath;
            string sFileName = @"Results.xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Results");
                IRow row = excelSheet.CreateRow(0);

                row.CreateCell(0).SetCellValue("ID");
                row.CreateCell(1).SetCellValue("FirstName");
                row.CreateCell(2).SetCellValue("Surname");
                row.CreateCell(3).SetCellValue("LegalSurname");
                row.CreateCell(4).SetCellValue("DateOfBirth");

                var resultsToExport = _context.Results.ToList();
                var i = 1;
                foreach (var item in resultsToExport)
                {
                    row = excelSheet.CreateRow(i);
                    row.CreateCell(0).SetCellValue(item.ID);
                    row.CreateCell(1).SetCellValue(item.FirstName);
                    row.CreateCell(2).SetCellValue(item.Surname);
                    row.CreateCell(3).SetCellValue(item.LegalSurname);
                    row.CreateCell(4).SetCellValue(item.DateOfBirth);

                    i++;
                }


                workbook.Write(fs);
            }
            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }

    }
}
