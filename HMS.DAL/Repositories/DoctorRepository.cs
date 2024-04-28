using HMS.DAL.Data;
using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repositories
{
    public class DoctorRepository
    {
        private CustomDbContext _dbContext;

        public DoctorRepository()
        {
            _dbContext = new CustomDbContext();
        }

        public Doctor add(Doctor item) { 
         
            _dbContext.Doctors.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public Doctor update(int id,Doctor item)
        {

         var entity=   _dbContext.Doctors.Find(id);
            entity = item;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Doctor delete(int id)
        {
            var entity = _dbContext.Doctors.Find(id);        
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Doctor Get(int id)
        {
            var entity = _dbContext.Doctors.Find(id);
            return entity;
        }
        public List<Doctor> GetAll()
        {
            var entities = _dbContext.Doctors.ToList();
            return entities;
        }
    }
}
