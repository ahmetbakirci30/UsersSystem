using System.Windows.Forms;

namespace WindowsFormsApp
{

    static class Program
    {

        static void Main()
        {

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());

        }

    }

}