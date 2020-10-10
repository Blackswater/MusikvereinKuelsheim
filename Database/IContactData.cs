using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public interface IContactData
    {
        ContactData Get(int id);
        IEnumerable<ContactData> GetAll();
        void Add(ContactData newContactData);
        void Remove(int id);
    }
}
