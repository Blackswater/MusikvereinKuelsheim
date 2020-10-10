using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusikvereinKuelsheim.Models
{
    public class ContactDataDetailModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Vorname muss vorhanden sein!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Nachname muss vorhanden sein!")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage ="Es muss eine gültige E-Mail Adresse eingegeben wernden!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public int PLZ { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telephonnumber { get; set; }
        [Display(Name = "Diese Kontaktdaten sind schon vorhanden!")]
        public bool isContactDataAlreadyExisting { get; set; } = false;
    }
}
