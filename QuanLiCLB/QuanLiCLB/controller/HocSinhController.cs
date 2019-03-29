using QuanLiCLB.Model;
using QuanLiCLB.Model.View;
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
            return db.HocSinhs.OrderByDescending(x => x.ID).ToList();

        }
        public List<HocSinhView> DetailView()
        {
            var list = (from a in db.HocSinhs
                       join b in db.LopHCs
                       on a.Lophc equals b.ID
                       select new HocSinhView
                       {
                           ID = a.ID,
                           GioiTinh = a.GioiTinh,
                           TenHS = a.TenHS,
                           NgaySinh = a.NgaySinh,
                           Lophc = a.Lophc,
                           TenLopHc = b.Ten
                       }).OrderByDescending(x=>x.ID);
            return list.ToList();
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
                db.HocSinhs.Add(entity);
                db.SaveChanges();
                return entity.ID;

            }
            catch (Exception)
            {
                return 0;
                throw;
            }
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
        public List<HocSinhView> FindByNameView(string key)
        {
            var list = (from a in db.HocSinhs
                       join b in db.LopHCs
                       on a.Lophc equals b.ID
                       select new HocSinhView
                       {
                           ID = a.ID,
                           GioiTinh = a.GioiTinh,
                           TenHS = a.TenHS,
                           NgaySinh = a.NgaySinh,
                           Lophc = a.Lophc,
                           TenLopHc = b.Ten
                       }).Where(m => m.TenHS.Contains(key));

            return list.ToList();
        }
    }
}
