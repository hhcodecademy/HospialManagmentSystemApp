using HMS.DAL.Models.Enums;
using HMS.DAL.Models;
using HMS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI.Managment
{
    internal class DepartmentManagement
    {
        private DepartmentRepository _depRepository;
        public DepartmentManagement()
        {
            _depRepository = new DepartmentRepository();
        }
        public void GetAll()
        {

            var items = _depRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Description}");
            }

        }
        public void Get()
        {
            Console.WriteLine("id daxil edin");
            int id =int.Parse(Console.ReadLine());
            var item=_depRepository.Get(id);
                Console.WriteLine($"{item.Id} {item.Name} {item.Description}");
        }
        public void Add()
        {
            Department item = new Department();
            Console.WriteLine("Department adini daxil ediniz");
            item.Name = Console.ReadLine();
            Console.WriteLine("Department aciqlama daxil ediniz");
            item.Description = Console.ReadLine();
            _depRepository.add(item);
        }
       
    }
}
