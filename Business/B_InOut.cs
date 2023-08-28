using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InOut
    {
        public static List<InOutEntity> InOutList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        public static void UpdateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
