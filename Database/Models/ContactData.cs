using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class ContactData
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public int PLZ { get; set; }
        public string TelephonNumber { get; set; }


    }
}
