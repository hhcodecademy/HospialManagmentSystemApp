using HMS.DAL.Models;
using HMS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI.Managment
{
    internal class RoomManagment
    {
        private RoomRepository _roomRepository;
        public RoomManagment()
        {
            _roomRepository = new RoomRepository();
        }
        public void GetAll()
        {

            var items = _roomRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Code}");
            }

        }
        public void Get()
        {
            Console.WriteLine("id daxil edin");
            int id = int.Parse(Console.ReadLine());
            var item = _roomRepository.Get(id);
            Console.WriteLine($"{item.Id} {item.Code}");
        }
        public void Add()
        {
            Room item = new Room();
            Console.WriteLine("Room adini daxil ediniz");
            item.Code = Console.ReadLine();
            _roomRepository.add(item);
        }
    }
}
