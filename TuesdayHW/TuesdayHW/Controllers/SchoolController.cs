﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuesdayHW.Models;


namespace TuesdayHW.Controllers
{
   
        public class SchoolController : Controller
        {
            // GET: Person
            public ActionResult Index()
            {
                return View(Session["Classmates"]);
            }

            // GET: Person/Details/5
            public ActionResult Details(int id)
            {
                return View();
            }

            // GET: Person/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: Person/Create
            [HttpPost]
            public ActionResult Create(List<Person> peoples)
            {
                try
                {
                    // TODO: Add insert logic here
                    Session["Classmates"] = peoples;
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            // GET: Person/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: Person/Edit/5
            [HttpPost]
            public ActionResult Edit(int id, FormCollection collection)
            {
                try
                {
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            // GET: Person/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: Person/Delete/5
            [HttpPost]
            public ActionResult Delete(int id, FormCollection collection)
            {
                try
                {
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
        }
    }
