using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCLB.controller
{
    class CLBController
    {
        QLCLBDbContext db = null;
        public CLBController()
        {
            db = new QLCLBDbContext();
        }
        public List<Clb> Detail()
        {
            return db.Clbs.OrderByDescending(x=>x.ID).ToList();
        }
        public long Add(Clb entity)
        {
            try
            {
                db.Clbs.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.ID;
        }
        public bool Edit(Clb entity)
        {
            try
            {
                Clb temp = db.Clbs.Find(entity.ID);
                temp.TenClb = entity.TenClb;
                temp.MucHocPhi = entity.MucHocPhi;
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
                var entity = db.Clbs.Find(ID);
                db.Clbs.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public List<Clb> FindByName(string key)
        {
            var list = db.Clbs.Where(m => m.TenClb.Contains(key)).ToList();
            return list;
        }
    }
}
