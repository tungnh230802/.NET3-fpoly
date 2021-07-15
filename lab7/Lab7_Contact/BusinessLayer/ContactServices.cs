using DataLayer;
using Model_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ContactServices
    {
        static IContactRepository respository;
        static ContactServices()
        {
            respository = new ContactRepository();
        }

        public static List<contact> GetAll()
        {
            return respository.GetAll();
        }

        public static contact GetById(int id)
        {
            return respository.GetById(id);
        }

        public static contact Insert(contact obj)
        {
            return respository.Insert(obj);
        }

        public static void Update(contact obj)
        {
            respository.Update(obj);
        }

        public static void Delete(contact obj)
        {
            respository.Delete(obj);
        }
    }
}
