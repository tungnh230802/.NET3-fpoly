using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_DB;

namespace DataLayer
{
    public interface IContactRepository
    {
        List<contact> GetAll();
        contact GetById(int id);
        contact Insert(contact obj);
        void Update(contact obj);
        void Delete(contact obj);
    }
}
