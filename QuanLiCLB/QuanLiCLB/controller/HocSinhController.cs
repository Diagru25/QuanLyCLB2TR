using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCLB.controller
{
    class HocSinhController
    {
        QLCLBDbContext db = null;
        public HocSinhController()
        {
            db = new QLCLBDbContext();
        }
        public List<HocSinh> Detail()
        {
            return db.HocSinhs.OrderByDescending(x=>x.ID).ToList();
        }
        public HocSinh DetailOne(long ID)
        {
            var dr = db.HocSinhs.Find(ID);
            return dr;
        }
        public long Add(HocSinh entity)
        {
            try
            {
                var index = db.HocSinhs.Where(m => m.TenHS == entity.TenHS).ToList();
                if (index.Count>0)
                {
                    return -1;
                }
                else
                {
                    db.HocSinhs.Add(entity);
                    db.SaveChanges();
                }
                
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.ID;
        }
        public bool Edit(HocSinh entity)
        {
            try
            {
                var index = db.HocSinhs.Find(entity.ID);
                index.TenHS = entity.TenHS;
                index.GioiTinh = entity.GioiTinh;
                index.NgaySinh = entity.NgaySinh;
                //index.LopID = entity.LopID;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public bool Del(long ID)
        {
            try
            {
                var entity = db.HocSinhs.Find(ID);
                db.HocSinhs.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public List<HocSinh> FindByName(string key)
        {
            var list = db.HocSinhs.Where(m => m.TenHS.Contains(key)).ToList();
            return list;
        }
    }
}
