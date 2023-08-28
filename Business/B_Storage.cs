using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static StorageEntity ProductById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList().LastOrDefault(s => s.StorageId == id);
            }
        }

        public static void CreateStorages(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
