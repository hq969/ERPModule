using System.Windows.Controls;
using ProBizERP.ViewModels;

namespace ProBizERP.Views
{
    public partial class InventoryView : UserControl
    {
        InventoryViewModel vm = new InventoryViewModel();
        public InventoryView()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AddProduct_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vm.AddProduct();
        }
    }
}
