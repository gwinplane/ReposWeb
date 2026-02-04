using AddressManagementWeb.Models;// Für Address-Klasse
using AddressManagementWeb.Services;//Für AddressService
using Microsoft.AspNetCore.Mvc;//Für Controller, IActionResult

namespace AddressManagementWeb.Controllers
{
    public class AddressController : Controller //erbt von Basis-Controller-Klasse
    {
        private readonly AddressService _service;

        public AddressController()
        {
            _service = new AddressService();
        }


        //Daten abrufen (Seite ansehen) получить данные
        // GET: /Address/Index запрос данных
        public IActionResult Index() //IActionResult - ist ein Interface, das das Ergebnis einer Aktion beschreibt.
        {                            //Methodenname (Action)
            var addresses = _service.GetAllAddresses();
            return View(addresses);  //Übergibt die Adressliste an die **View** (HTML-Seite) und gibt sie an den Benutzer zurück.
                                     //Views/Address/Index.cshtml
        }

        // GET: /Address/Create   Zeigt leeres Formular zum Erstellen einer Adresse an.
        public IActionResult Create()
        {
            return View();  //Views/Address/Create.cshtml
                            //Wann wird aufgerufen: Wenn Benutzer auf "Add New Address" klickt
        }

        //Daten senden (Formular absenden)
        // POST: /Address/Create
        [HttpPost]
        public IActionResult Create(Address address)
        {
            if (ModelState.IsValid)
            {
                bool success = _service.AddAddress(address);

                if (success)
                {   //emporärer Speicher** zum Übergeben von Nachrichten zwischen Seiten.
                    TempData["SuccessMessage"] = "Address added successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = $"Address '{address.Street} {address.HouseNumber}' already exists!";
                }
            }

            return View(address);
        }

        // POST: /Address/Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            bool success = _service.DeleteAddress(id);

            if (success)
            {
                TempData["SuccessMessage"] = "Address deleted successfully!";
            }
            else
            {
                TempData["ErrorMessage"] = "Failed to delete address!";
            }

            return RedirectToAction("Index");
        }
    }
}