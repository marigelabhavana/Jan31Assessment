using Jan31Assessment.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Jan31Assessment.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> listCourses = new List<Course>()
        {
            new Course() { CId=1, CName= "Introduction to Python Programming", CFee=45000 , Technology= "Python", CStartDate= new DateTime(day:20,month:02,year:2024), CEndDate= new DateTime(day:15,month:05,year:2024)},
            new Course() { CId=2, CName= "Web Development with ReactJS", CFee=54000 , Technology= "ReactJS", CStartDate= new DateTime(day:25,month:02,year:2024), CEndDate= new DateTime(day:20,month:06,year:2024)},
            new Course() { CId=3, CName= "Database Design and SQL Fundamentals", CFee=82000 , Technology= "SQL", CStartDate= new DateTime(day:05,month:03,year:2024), CEndDate= new DateTime(day:20,month:06,year:2024)},
            new Course() { CId=4, CName= "Machine Learning Essentials with TensorFlow", CFee=20000 , Technology= "TensorFlow", CStartDate= new DateTime(day:10,month:02,year:2024), CEndDate= new DateTime(day:20,month:04,year:2024)},
            new Course() { CId=5, CName= "Cybersecurity Basics and Ethical Hacking", CFee=60000 , Technology= "CyberSecurity", CStartDate= new DateTime(day:18,month:03,year:2024), CEndDate= new DateTime(day:20,month:05,year:2024)},
        };
        public ActionResult Index()
        {
            return View(listCourses);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                listCourses.Add(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }
    }
}