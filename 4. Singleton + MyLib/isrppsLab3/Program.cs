using MyLib;

namespace isrppsLab4
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm());
        }
    }
}