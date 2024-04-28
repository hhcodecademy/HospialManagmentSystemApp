using HMS.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Models
{
    public  class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public GenderType Gender { get; set; }

        public DateTime DOB { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

    }
}
