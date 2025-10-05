using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using ProBizERP.Models;

namespace ProBizERP.ViewModels
{
    public class ReportViewModel : BindableBase
    {
        public ObservableCollection<Sale> Sales { get; set; } = new ObservableCollection<Sale>();

        public ReportViewModel()
        {
            LoadSales();
        }

        public void LoadSales()
        {
            Sales.Clear();
            using var conn = DatabaseHelper.GetConnection();
            var cmd = new SQLiteCommand("SELECT * FROM Sales", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Sales.Add(new Sale
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    ProductId = int.Parse(reader["ProductId"].ToString()),
                    Quantity = int.Parse(reader["Quantity"].ToString()),
                    TotalPrice = double.Parse(reader["TotalPrice"].ToString()),
                    Date = reader["Date"].ToString()
                });
            }
        }
    }
}
