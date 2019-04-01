using QuanLiCLB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCLB.controller
{
    class TKController
    {
        QLCLBDbContext db = null;
        public TKController()
        {
            db = new QLCLBDbContext();
        }
        public TaiKhoan Login(string username, string pass)
        {
            return db.TaiKhoans.Where(x => x.TenTK == username && x.MatKhau == pass).SingleOrDefault();
        }
        public long Add(TaiKhoan entity)
        {
            try
            {
                db.TaiKhoans.Add(entity);
                db.SaveChanges();
                return entity.ID;
            }
            catch
            {
                return 0;
            }
        }
        public bool EditTK(string username, string pass)
        {
            try
            {
                TaiKhoan temp = db.TaiKhoans.Find(ConstantCommon.ID);
                temp.MatKhau = pass;
                db.SaveChanges();
                ConstantCommon.MAT_KHAU = pass;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<TaiKhoan> Detail()
        {
            return db.TaiKhoans.Where(x=>x.ID != ConstantCommon.ID).OrderByDescending(x => x.ID).ToList();
        }
        public bool ChangeRole(TaiKhoan entity)
        {
            try
            {
                TaiKhoan temp = db.TaiKhoans.Find(entity.ID);
                temp.Quyen = entity.Quyen;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(long ID)
        {
            try
            {
                db.TaiKhoans.Remove(db.TaiKhoans.Find(ID));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<TaiKhoan> FindByName(string key)
        {
            return db.TaiKhoans.Where(x => x.TenTK.Contains(key)).ToList();
        }
        public List<TaiKhoan> getListTK(string from, string to)
        {
            //var list = from ex in db.dispenseds
            //           group ex by new {ex.IDexamination}
            //           into g
            //           select new
            //           {
            //               IDexamination = g.Key.IDexamination,
            //               PriceDrug=g.Sum(s=>s.Amount*s.drug.Price)
            //           };
            //var res = from l in list
            //          join ex in db.examinations
            //          on l.IDexamination equals ex.ID
            //          group ex by new { ex.Date }
            //          into g
            //          select new
            //          {
            //              Date = g.Key.Date,
            //              costs = g.Sum(x => x.Cost),
            //              pricesDrugs= g.Where
            //          };
            
            string esqlQuery = "select Date,costs=sum(cost),PirceDrugs=sum(PirceDrug) " +
                "from examination as ex left join (select d.IDexamination, PirceDrug = sum(d.Amount * dr.Price) from dispensed as d, drug as dr where d.IDdrug = dr.ID " +
                "group by d.IDexamination) as de on de.IDexamination = ex.ID " +
                "where ex.Date >= Cast('"+ from + "' as datetime) and ex.Date < Cast('" + to + "' as datetime) " +
                "group by Date";

            //SqlParameter frompara = new SqlParameter("datefrom", from);
            //SqlParameter topara = new SqlParameter("dateto", to);
            var re = db.Database.SqlQuery<TaiKhoan>(esqlQuery).ToList();
            return re;
        }
    }
}
