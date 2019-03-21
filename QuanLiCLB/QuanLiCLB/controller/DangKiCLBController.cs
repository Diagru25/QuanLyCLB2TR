using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCLB.Model;

namespace QuanLiCLB.controller
{
    class DangKiCLBController
    {
        QLCLBDbContext db = null;
        public DangKiCLBController()
        {
            db = new QLCLBDbContext();
        }
        public DangKy DetailOne(long id)
        {
            return db.DangKies.Find(id);
        }
        public List<DangKy> DetailByIDExamination(long _id)
        {
            return db.DangKies.Where(m=>m.ID==_id).ToList();
        }
        public List<DangKy> Detail()
        {
            return db.DangKies.OrderByDescending(x=>x.ID).ToList();
        }
        public long Add(DangKy entity)
        {
            try
            {
                db.DangKies.Add(entity);
                db.SaveChanges();
            }
            catch(Exception)
            {
                return 0;
                throw;
            }
            return entity.ID;
        }
        public bool Edit(DangKy entity)
        {
            try
            {
                DangKy temp = db.DangKies.Find(entity.ID);
                temp.HocPhi = entity.HocPhi;
                temp.HocSinhID = entity.HocSinhID;
                temp.LopID = entity.LopID;
                temp.NgayDky = entity.NgayDky;
                temp.NguoiDangKy = entity.NguoiDangKy;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(long id)
        {
            try
            {
                DangKy temp = db.DangKies.Find(id);
                db.DangKies.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
