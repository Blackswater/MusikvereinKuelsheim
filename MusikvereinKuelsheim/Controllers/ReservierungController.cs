
using Database;
using Database.Models;
using Microsoft.AspNetCore.Mvc;
using MusikvereinKuelsheim.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MusikvereinKuelsheim.Controllers
{
    public class ReservierungController : Controller
    {
        private IContactData _contactData;
        public ReservierungController(IContactData contactData)
        {
            _contactData = contactData;
        }

        public IActionResult Reservierung()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Reservierung(ContactDataDetailModel contactDataDetailModel)
        {            
            if(ModelState.IsValid  && !CheckIfContactDataAlreadyExists(contactDataDetailModel))
            {
                var contactData = new ContactData()
                {
                    Id = contactDataDetailModel.ID,
                    FirstName = contactDataDetailModel.FirstName,
                    LastName = contactDataDetailModel.LastName,
                    PLZ = contactDataDetailModel.PLZ,
                    EMail = contactDataDetailModel.Email,
                    TelephonNumber = contactDataDetailModel.Telephonnumber

                };

                
                _contactData.Add(contactData);
                return RedirectToAction("Index", "Home");
            }
            contactDataDetailModel.isContactDataAlreadyExisting = true;
            return View(contactDataDetailModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool CheckIfContactDataAlreadyExists(ContactDataDetailModel contactDataDetailModel)
        {
            var result = false;

            var exisitngContactData = _contactData.GetAll();

            foreach(ContactData c in exisitngContactData) 
            {
                result = c.FirstName.Equals(contactDataDetailModel.FirstName)
                    && c.LastName.Equals(contactDataDetailModel.LastName)
                    && c.PLZ == contactDataDetailModel.PLZ
                    && c.EMail.Equals(contactDataDetailModel.Email)
                    && c.TelephonNumber.Equals(contactDataDetailModel.Telephonnumber);

                if(result)
                {
                    break;
                }
            }
            
            return result;
        }
    }
}
