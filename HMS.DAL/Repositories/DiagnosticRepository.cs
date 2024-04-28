using HMS.DAL.Data;
using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repositories
{
    public class DiagnosticRepository
    {

        private CustomDbContext _dbContext;

        public DiagnosticRepository()
        {
            _dbContext = new CustomDbContext();
        }

        public Diagnostic add(Diagnostic item)
        {

            item.Doctor = _dbContext.Doctors.Find(item.Doctor.Id);
            item.Patient = _dbContext.Patients.Find(item.Patient.Id);
            _dbContext.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public Diagnostic update(int id, Diagnostic item)
        {

            var entity = _dbContext.Diagnostics.Find(id);
            entity = item;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Diagnostic delete(int id)
        {
            var entity = _dbContext.Diagnostics.Find(id);
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Diagnostic Get(int id)
        {
            var entity = _dbContext.Diagnostics.Find(id);
            return entity;
        }
        public List<Diagnostic> GetAll()
        {
            var entities = _dbContext.Diagnostics.ToList();
            return entities;
        }
    }
}
