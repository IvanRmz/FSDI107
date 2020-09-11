using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using myCalendar.Models;
using System.Linq;

namespace myCalendar.Controllers 
{
    public class ApiController : Controller
    {
        private DataContext database;

        public ApiController(DataContext db)
        {
            this.database = db;
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            // var list = new List<Task>();
            // var t1 = new Task();
            // t1.Id = 1;
            // t1.Title = "First Task";
            // t1.Notes = "This is the first task on my super calendar sys";
            // t1.Important = true;
            // t1.Date = DateTime.Now; 
            // list.Add(t1);

            // var t2 = new Task(){
            //     Id = 2,
            //     Title = "Get Milk",
            //     Important = false,
            //     Notes = "Get milk next time you go to the store"
            // };
            // list.Add(t2);

            // var t3 = new Task(){
            //     Id = 3,
            //     Title = "Dentist",
            //     Important = true,
            //     Notes = "Go to the Dentist",
            //     Date = DateTime.Now
            // };
            // list.Add(t3);

            // var t4 = new Task(){
            //     Id = 3,
            //     Title = "Walk the dog",
            //     Important = true,
            //     Notes = "Take the dog to walk",
            //     Date = DateTime.Today.AddDays(1)
            // };
            // list.Add(t4);
            // return Json(list);

            var list = database.TasksTable.ToList();
            return Json(list);
        }

        [HttpPost]
        public IActionResult CreateTask ([FromBody] Task theTask)
        {
            database.TasksTable.Add(theTask);
            database.SaveChanges();
            return Json(theTask);
        }
    }
}