using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using System.Data.Entity;
    using System.Data;
    using System.Data.SqlClient;
    using DAL.Contracts;
    using DAL.Entities;
    public class FilterRepository : MasterRepository, IFilterRepository
    {
        public bool Add(Filter entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Filters.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Filter entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Filters.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Filter> GetAll()
        {
            IEnumerable<Filter> obj;
            using (dbContext db = new dbContext())
            {
                obj = db.Filters;
            }
            return obj;
        }

        public Filter GetUser(int iduser, int idconsult)
        {
            Filter obj;
            using(dbContext db = new dbContext())
            {
                obj = (from o in db.Filters
                       where o.IdUser == iduser && o.IdConsult == idconsult
                       select o).FirstOrDefault();
            }
            return obj;
        }

        public DataTable Execute(string transactSql)
        {
            parameters = new List<SqlParameter>();
            return ExecuteReader(transactSql);
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                var obj = db.Filters.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
