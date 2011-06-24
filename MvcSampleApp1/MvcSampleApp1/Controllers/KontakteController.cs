﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcSampleApp1.Helpers;

namespace MvcSampleApp1.Controllers
{
    public class KontakteController : Controller
    {
        public ActionResult Index()
        {
            return View(KontaktStore.GetKontakte());
        }

        //
        // GET: /Kontakte/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Kontakte/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Kontakte/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Kontakte/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Kontakte/Edit/5

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

        //
        // GET: /Kontakte/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Kontakte/Delete/5

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