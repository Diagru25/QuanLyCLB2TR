using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCLB.controller
{
    class LopHcController
    {
        QLCLBDbContext db = null;
        public LopHcController()
        {
            db = new QLCLBDbContext();
        }
        public List<LopHC> Detail()
        {
            return db.LopHCs.OrderByDescending(x=>x.ID).ToList();
        }
        public LopHC DetailOne(long ID)
        {
            var dr = db.LopHCs.Find(ID);
            return dr;
        }
        public long Add(LopHC entity)
        {
            try
            {
                db.LopHCs.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.ID;
        }
        public bool Edit(LopHC entity)
        {
            try
            {
                LopHC temp = db.LopHCs.Find(entity.ID);

                temp.Ten = entity.Ten;

                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public bool delete(long ID)
        {
            try
            {
                var entity = db.LopHCs.Find(ID);
                db.LopHCs.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public List<LopHC> FindByName(string key)
        {
            var list = db.LopHCs.Where(m => m.Ten.Contains(key)).ToList();
            return list;
        }
    }
}
