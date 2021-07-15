using Model_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ContactRepository : IContactRepository
    {
        public void Delete(contact obj)
        {
            using (dbcontactEntities1 db = new dbcontactEntities1())
            {
                db.contacts.Attach(obj);
                db.contacts.Remove(obj);
                db.SaveChanges();
            }

        }

        public List<contact> GetAll()
        {
            using (dbcontactEntities1 db = new dbcontactEntities1())
            {
                return db.contacts.ToList();
            }
        }

        public contact GetById(int id)
        {
            using (dbcontactEntities1 db = new dbcontactEntities1())
            {
                return db.contacts.Find(id);
            }

        }

        public contact Insert(contact obj)
        {
            using (dbcontactEntities1 db = new dbcontactEntities1())
            {
                db.contacts.Add(obj);
                db.SaveChanges();
                return obj;
            }

        }

        public void Update(contact obj)
        {
            using (dbcontactEntities1 db = new dbcontactEntities1())
            {
                db.contacts.Attach(obj);
                db.Entry(obj).State =
                    System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}
