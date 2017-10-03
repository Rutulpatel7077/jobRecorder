using JobRecorder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobRecorder.Controllers
{
    public class JobController : Controller
    {
        //db connection to server
        JobRecorderModel db = new JobRecorderModel();


        // GET: Job
        public ActionResult Index()
        {
            var jobs = from j in db.jobs
                       orderby j.job_position
                       select j;
            return View(jobs);
        }
        //public ActionResult Index()
        //{
        //    var employees = from e in db.employees
        //               orderby e.employee_name
        //               select e;
        //    return View(employees);
        //}
        public ActionResult Browse(string jobs)
        {

            var SelectedJobs = db.jobs.Include("employee")
                .SingleOrDefault(j => j.job_position == jobs);

            return View(SelectedJobs);
        }
    }
}