using FisioFinancials.Domain.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FisioFinancials.API.Controllers
{
    public class ReceivedsController : Controller
    {
        // GET: ReceivedsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReceivedsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReceivedsController/Create
        public ActionResult Create(ReceivedDTO receivedDTO)
        {
            return View();
        }

        // POST: ReceivedsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceivedsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReceivedsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceivedsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReceivedsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
