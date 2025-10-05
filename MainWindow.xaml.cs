using System.Windows;
using ProBizERP.Views;

namespace ProBizERP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new InventoryView();
        }

        private void InventoryBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new InventoryView();
        }

        private void SalesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SalesView();
        }

        private void ReportsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ReportView();
        }
    }
}
