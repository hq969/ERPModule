using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using ProBizERP.Models;

namespace ProBizERP.ViewModels
{
    public class SalesViewModel : BindableBase
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();
        public ObservableCollection<Sale> Sales { get; set; } = new ObservableCollection<Sale>();

        private Product _selectedProduct;
        private int _saleQuantity;

        public Product SelectedProduct { get => _selectedProduct; set => SetProperty(ref _selectedProduct, value); }
        public int SaleQuantity { get => _saleQuantity; set => SetProperty(ref _saleQuantity, value); }

        public SalesViewModel()
        {
            LoadProducts();
            LoadSales();
        }

        public void LoadProducts()
        {
            Products.Clear();
            using var conn = DatabaseHelper.GetConnection();
            var cmd = new SQLiteCommand("SELECT * FROM Products", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Products.Add(new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    Price = Convert.ToDouble(reader["Price"])
                });
            }
        }

        public void RecordSale()
        {
            if (SelectedProduct == null || SaleQuantity <= 0 || SaleQuantity > SelectedProduct.Quantity)
                return;

            double total = SaleQuantity * SelectedProduct.Price;

            using var conn = DatabaseHelper.GetConnection();
            var cmd = new SQLiteCommand("INSERT INTO Sales(ProductId, Quantity, TotalPrice, Date) VALUES(@pid, @qty, @total, @date)", conn);
            cmd.Parameters.AddWithValue("@pid", SelectedProduct.Id);
            cmd.Parameters.AddWithValue("@qty", SaleQuantity);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE Products SET Quantity = Quantity - @qty WHERE Id = @pid";
            cmd.ExecuteNonQuery();

            LoadProducts();
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
                    Id = Convert.ToInt32(reader["Id"]),
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                    Date = reader["Date"].ToString()
                });
            }
        }
    }
}
