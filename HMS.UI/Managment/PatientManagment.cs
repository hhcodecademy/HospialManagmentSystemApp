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
    internal class PatientManagment
    {
        private PatientRepository _patientRepository;
        public PatientManagment()
        {
            _patientRepository = new PatientRepository();
        }
        public void GetAll()
        {

            var items = _patientRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Fathername}");
            }

        }
        public void Get()
        {
            Console.WriteLine("id daxil edin");
            int id = int.Parse(Console.ReadLine());
            var item = _patientRepository.Get(id);
            Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Fathername}");
        }
        public void Add()
        {
            Patient patient = new Patient();
            Console.WriteLine("Xeste adini daxil ediniz");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Xeste soyadini daxil ediniz");
            patient.Surname = Console.ReadLine();
            Console.WriteLine("Xeste ata adini daxil ediniz");
            patient.Fathername = Console.ReadLine();
            Console.WriteLine("Xeste dogum tarixi daxil ediniz");
            patient.DOB =DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Xeste cinsiyyetini daxil ediniz");
            patient.Gender = (GenderType)int.Parse(Console.ReadLine());
             _patientRepository.add(patient);
        }
    }
}
