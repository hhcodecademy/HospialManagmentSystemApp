using HMS.DAL.Data;
using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repositories
{
    public class RoomRepository
    {
        private CustomDbContext _dbContext;

        public RoomRepository()
        {
            _dbContext = new CustomDbContext();
        }

        public Room add(Room item)
        {

            _dbContext.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
        public Room update(int id, Room item)
        {

            var entity = _dbContext.Rooms.Find(id);
            entity = item;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Room delete(int id)
        {
            var entity = _dbContext.Rooms.Find(id);
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public Room Get(int id)
        {
            var entity = _dbContext.Rooms.Find(id);
            return entity;
        }
        public List<Room> GetAll()
        {
            var entities = _dbContext.Rooms.ToList();
            return entities;
        }
    }
}
