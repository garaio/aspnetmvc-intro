using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcSampleApp1.Helpers;
using MvcSampleApp1.Models;

namespace MvcSampleApp1.Controllers
{
	public class KontakteController : Controller
    {
		private readonly IKontaktStore _kontaktStore;

    	public KontakteController(IKontaktStore kontaktStore)
    	{
    		_kontaktStore = kontaktStore;
    	}

    	public ActionResult Index(KontaktIndexCommand command)
        {
            return View(command.Execute());
        }

        public ActionResult Details(KontaktDetailsCommand command)
        {
            return View(command.Execute());
        }

        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Create(KontaktCreateCommand command)
        {
        	if (!ModelState.IsValid)
        	{
        		return View();
        	}

        	command.Execute();
        	return RedirectToAction("Index");
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
			var zulöschen = _kontaktStore.GetKontakte().ElementAt(id);
			_kontaktStore.RemoveKontakt(zulöschen);
            return RedirectToAction("Index");
        }
    }
}
