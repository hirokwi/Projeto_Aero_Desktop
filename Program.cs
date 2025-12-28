using System.Globalization;
using System.Threading;

namespace projeto_teste1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            ApplicationConfiguration.Initialize();
            Application.Run(new frm_index());
        }
    }
}
