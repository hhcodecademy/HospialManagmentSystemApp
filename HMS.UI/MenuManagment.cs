using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI
{
    internal class MenuManagment
    {
        public static int showDoctortMenu()
        {

            Console.WriteLine("1.Show doctors");
            Console.WriteLine("2.Add doctor");
            Console.WriteLine("3.Update doctor");
            Console.WriteLine("4.Delete doctor");
            Console.WriteLine("5.Select doctor");
            Console.WriteLine("6.Exit");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }
        public static int showDepartmentMenu()
        {

            Console.WriteLine("1.Show departments");
            Console.WriteLine("2.Add department");
            Console.WriteLine("3.Update department");
            Console.WriteLine("4.Delete department");
            Console.WriteLine("5.Select department");
            Console.WriteLine("6.Exit");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }
        public static int showRoomMenu()
        {

            Console.WriteLine("1.Show room");
            Console.WriteLine("2.Add room");
            Console.WriteLine("3.Update room");
            Console.WriteLine("4.Delete room");
            Console.WriteLine("5.Select room");
            Console.WriteLine("6.Exit");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }
        public static int showPatientMenu()
        {

            Console.WriteLine("1.Show patient");
            Console.WriteLine("2.Add patient");
            Console.WriteLine("3.Update patient");
            Console.WriteLine("4.Delete patient");
            Console.WriteLine("5.Select patient");
            Console.WriteLine("6.Exit");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }
        public static int showDoctorMenu()
        {

            Console.WriteLine("1.Show doctors");
            Console.WriteLine("2.Add doctor");
            Console.WriteLine("3.Update doctor");
            Console.WriteLine("4.Delete doctor");
            Console.WriteLine("5.Select doctor");
            Console.WriteLine("6.Exit");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }

        public static int showDiagnosticMenu()
        {

            Console.WriteLine("1.Show diagnostics");
            Console.WriteLine("2.Add diagnostic");
            Console.WriteLine("3.Update diagnostic");
            Console.WriteLine("4.Delete diagnostic");
            Console.WriteLine("5.Select diagnostic");
            Console.WriteLine("6.Exit");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }
    }
}
