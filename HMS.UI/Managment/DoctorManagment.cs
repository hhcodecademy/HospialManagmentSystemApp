using HMS.DAL.Models;
using HMS.DAL.Models.Enums;
using HMS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI.Managment
{
    internal class DoctorManagment
    {
        private DoctorRepository _doctorRepository;
        private DepartmentRepository _departmentRepository;
        private DepartmentManagement _departmentManagement;
        public DoctorManagment()
        {
            _doctorRepository = new DoctorRepository();
            _departmentRepository = new DepartmentRepository();
            _departmentManagement = new DepartmentManagement();
        }
        public void GetAll()
        {

            var doctors= _doctorRepository.GetAll();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.Id} {doctor.Name} {doctor.Surname}");
            }

        }

        public void Add()
        {
            Doctor doctor = new Doctor();   
             Console.WriteLine("Doktorun adini daxil ediniz");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Doktorun soyadini daxil ediniz");
            doctor.Surname = Console.ReadLine();
            Console.WriteLine("Doktorun ata adini daxil ediniz");
            doctor.Fathername = Console.ReadLine();
            Console.WriteLine("Doktorun meslekini daxil ediniz");
            doctor.Occupation = Console.ReadLine();
            Console.WriteLine("Doktorun cinsiyyetini daxil ediniz");
            doctor.Gender =(GenderType)int.Parse(Console.ReadLine());
            Console.WriteLine();
            _departmentManagement.GetAll();
            Console.Write("\nHekimin departmaninin id-si: ");
            int depId = int.Parse(Console.ReadLine()) ;
            doctor.DepartmentId = depId ;
           // doctor.Department = _departmentRepository.Get(depId);
            _doctorRepository.add(doctor);

        }
    }
}
