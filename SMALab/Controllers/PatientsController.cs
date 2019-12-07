using SMALab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMALab.Controllers
{
    public class PatientsController : Controller
    {
        List<Patient> people = new List<Patient>();
        // GET: Patients
        public ActionResult Index()
        {
            people.Add(new Patient() { PatientId = 1, FirstName = "Clara", LastName = "Thompson", Dob = new DateTime(1991, 12, 05) });
            people.Add(new Patient() { PatientId = 1, FirstName = "Jason", LastName = "Malkov", Dob = new DateTime(2000, 08, 14) });

            return View(people);
        }
    }
}