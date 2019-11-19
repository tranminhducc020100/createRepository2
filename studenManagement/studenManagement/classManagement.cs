using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenManagement
{
    class classManagement
    {
        public CLASS[] GetClasses()
        {
            var db = new OOPCSEntities();
           return db.CLASSes.ToArray();
            
        }
        public void addClass(string name, string description)
        {
            var newClass = new CLASS();
            newClass.NAME = name;
            newClass.DESCRIPTION = description;
            var db = new OOPCSEntities();
            db.CLASSes.Add(newClass);
            db.SaveChanges();

        }
        public void EditClass(int id, string name, string description)
        {
            var db = new OOPCSEntities();
            var oldClass = db.CLASSes.Find(id);

            oldClass.NAME = name;
            oldClass.DESCRIPTION = description;
            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteClass(int id)
        {
            var db = new OOPCSEntities();
            var @class = db.CLASSes.Find(id);
            db.CLASSes.Remove(@class);
            db.SaveChanges();
        }
        
        public CLASS GetClass(int id)
        {
            var db = new OOPCSEntities();
            return db.CLASSes.Find(id);
        }
    }
}
