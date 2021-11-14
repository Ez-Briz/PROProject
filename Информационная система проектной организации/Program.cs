using System;
using System.Windows.Forms;

namespace Информационная_система_проектной_организации
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogAdmForm());
        }
    }
}   
