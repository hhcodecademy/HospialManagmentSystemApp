using HMS.DAL.Data;
using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repositories
{
    public class PatientRepository
    {
        private CustomDbContext _dbContext;

        public PatientRepository()
        {
            _dbContext = new CustomDbContext();
        }

        public Patient add(Patient item)
        {

            _dbContext.Patients.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public Patient update(int id, Patient item)
        {

            var entity = _dbContext.Patients.Find(id);
            entity = item;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Patient delete(int id)
        {
            var entity = _dbContext.Patients.Find(id);
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Patient Get(int id)
        {
            var entity = _dbContext.Patients.Find(id);
            return entity;
        }
        public List<Patient> GetAll()
        {
            var entities = _dbContext.Patients.ToList();
            return entities;
        }
    }
}

