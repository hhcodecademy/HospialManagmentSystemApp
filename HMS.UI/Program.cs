using HMS.UI.Managment;

namespace HMS.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiagnosticManagment manage = new ();
            int menu = 0;
            do
            {
                menu = MenuManagment.showDiagnosticMenu();
                switch (menu)
                {
                    case 1:
                        manage.GetAll();                        
                        break;
                        case 2:
                        manage.Add();
                        break;
                        case 5:
                        break;
                    default:
                        break;
                }
            } while (menu != 6);

        }
    }
}
