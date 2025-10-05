using System.Windows.Controls;
using ProBizERP.ViewModels;

namespace ProBizERP.Views
{
    public partial class SalesView : UserControl
    {
        SalesViewModel vm = new SalesViewModel();
        public SalesView()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void RecordSale_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vm.RecordSale();
        }
    }
}
