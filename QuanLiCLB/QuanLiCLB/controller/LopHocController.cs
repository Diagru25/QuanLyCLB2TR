using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCLB.controller
{
    class LopHocController
    {
        QLCLBDbContext db = null;
        public LopHocController()
        {
            db = new QLCLBDbContext();
        }
        public List<LopHoc> Detail()
        {
            return db.LopHocs.OrderByDescending(x=>x.ID).ToList();
        }
        public LopHoc DetailOne(long ID)
        {
            var dr = db.LopHocs.Find(ID);
            return dr;
        }
        public long Add(LopHoc entity)
        {
            try
            {
                db.LopHocs.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.ID;
        }
        public bool Edit(LopHoc entity)
        {
            try
            {
                LopHoc temp = db.LopHocs.Find(entity.ID);
                temp.TenLp = entity.TenLp;
                temp.LichHoc = entity.LichHoc;
                temp.ClbID = entity.ClbID;
                temp.NgayBatDau = entity.NgayBatDau;
                temp.CaHoc = entity.CaHoc;
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
                var entity = db.LopHocs.Find(ID);
                db.LopHocs.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public List<LopHoc> FindByName(string key)
        {
            var list = db.LopHocs.Where(m => m.TenLp.Contains(key)).ToList();
            return list;
        }
        public decimal GetHocPhiByID(long id)
        {
            long clbID = (long)db.LopHocs.Find(id).ClbID;
            decimal hocphi = Convert.ToDecimal(db.Clbs.Find(clbID).MucHocPhi);
            return hocphi;
        }
    }
}
