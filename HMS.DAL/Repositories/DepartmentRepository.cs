using HMS.DAL.Data;
using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repositories
{
    public class DepartmentRepository
    {
        private CustomDbContext _dbContext;

        public DepartmentRepository()
        {
            _dbContext = new CustomDbContext();
        }

        public Department add(Department item)
        {

            _dbContext.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public Department update(int id, Department item)
        {

            var entity = _dbContext.Departments.Find(id);
            entity = item;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Department delete(int id)
        {
            var entity = _dbContext.Departments.Find(id);
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Department Get(int id)
        {
            var entity = _dbContext.Departments.Find(id);
            return entity;
        }
        public List<Department> GetAll()
        {
            var entities = _dbContext.Departments.ToList();
            return entities;
        }
    }
}
