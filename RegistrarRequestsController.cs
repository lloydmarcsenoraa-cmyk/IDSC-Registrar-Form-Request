using Microsoft.AspNetCore.Mvc;
using IDSCRegistrar.Models;

namespace IDSCRegistrar.Controllers
{
    public class RegistrarRequestsController : Controller
    {
        public IActionResult Index()
        {
            var requests = FakeRequestRepository.GetAll();
            return View(requests);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RegistrarRequest request)
        {
            if (ModelState.IsValid)
            {
                FakeRequestRepository.Add(request);
                return RedirectToAction("Index");
            }
            return View(request);
        }

        public IActionResult Edit(int id)
        {
            var request = FakeRequestRepository.Get(id);
            if (request == null) return NotFound();
            return View(request);
        }

        [HttpPost]
        public IActionResult Edit(RegistrarRequest request)
        {
            if (ModelState.IsValid)
            {
                FakeRequestRepository.Update(request);
                return RedirectToAction("Index");
            }
            return View(request);
        }

        public IActionResult Delete(int id)
        {
            var request = FakeRequestRepository.Get(id);
            if (request == null) return NotFound();
            return View(request);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            FakeRequestRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
