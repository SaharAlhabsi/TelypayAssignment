﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using TelypatAssignment.Models;
using TelypayAssignment.Data;
using TelypayAssignment.Models;

namespace TelypatAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Students"] = _context.Students.ToList();
            ViewData["Classes"] = _context.Classes.ToList();
            ViewData["Countries"] = _context.Countries.ToList();
         
       
           
            return View();


        }
        public IActionResult GetAvgAge()
        {
            using (var connection = new SqliteConnection("Data Source=studentsDB.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                      @"
        
                    SELECT birthDate,
                    strftime('%Y',date('now'))-strftime('%Y',date(birthDate))As 'age'
                    FROM students
                        ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);

                        Console.WriteLine($"Hello, {name}!");
                    }
                }
            }
            return View();
        }

            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
