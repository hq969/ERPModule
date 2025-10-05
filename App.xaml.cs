using System.Windows;
using ProBizERP.Models;

namespace ProBizERP
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DatabaseHelper.InitializeDatabase();
        }
    }
}
