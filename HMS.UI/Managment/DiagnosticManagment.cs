using HMS.DAL.Models;
using HMS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI.Managment
{
    internal class DiagnosticManagment
    {
        private DiagnosticRepository _diagnosticrepository;
        private DoctorRepository _doctorrepository;
        private PatientRepository _patientrepository;
        public DiagnosticManagment()
        {
            _diagnosticrepository = new ();
            _doctorrepository = new  ();
            _patientrepository = new  ();
        }
        public void GetAll()
        {

            var items = _diagnosticrepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Title} {item.Description} Hekim adi: {item.Doctor.Name} Xeste adi: {item.Patient.Name} ");
            }

        }
        public void Get()
        {
            Console.WriteLine("id daxil edin");
            int id = int.Parse(Console.ReadLine());
            var item = _diagnosticrepository.Get(id);
            Console.WriteLine($"{item.Id} {item.Title} {item.Description} ");
        }
        public void Add()
        {
            Diagnostic item = new Diagnostic();
            Console.WriteLine("Muayyine basligini  daxil ediniz");
            item.Title = Console.ReadLine();
            Console.WriteLine("Muayyine aciqlamasini  daxil ediniz");
            item.Description = Console.ReadLine();
            Console.Write("Muayineni qoyan hekimin id-si: ");
            int doctorId = int.Parse (Console.ReadLine());
            item.Doctor = _doctorrepository.Get(doctorId);
            Console.Write("Muayine olunan xestenin id-si: ");
            int patientId = int.Parse (Console.ReadLine());
            item.Patient = _patientrepository.Get(patientId);

            _diagnosticrepository.add(item);
            
        }
    }
}
