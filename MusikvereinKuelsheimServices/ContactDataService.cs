using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusikvereinKuelsheimServices
{
    public class ContactDataService : IContactData
    {
        private MusikvereinEintrachtKuelsheimContext _context;

        public ContactDataService(MusikvereinEintrachtKuelsheimContext context)
        {
            _context = context;
        }
        public void Add(ContactData newContactData)
        {
            _context.Add(newContactData);
            _context.SaveChanges();
        }

        public ContactData Get(int id)
        {
            return GetAll()
                .FirstOrDefault(contactdata => contactdata.Id == id);
        }

        public IEnumerable<ContactData> GetAll()
        {
            return _context.ContactDatas;

        }

        public void Remove(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
    }
}
