using System.Windows.Controls;
using ProBizERP.ViewModels;

namespace ProBizERP.Views
{
    public partial class ReportView : UserControl
    {
        ReportViewModel vm = new ReportViewModel();
        public ReportView()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
