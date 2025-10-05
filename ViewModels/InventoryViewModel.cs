using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using ProBizERP.Models;

namespace ProBizERP.ViewModels
{
    public class InventoryViewModel : BindableBase
    {
        private string _name;
        private int _quantity;
        private double _price;

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public int Quantity { get => _quantity; set => SetProperty(ref _quantity, value); }
        public double Price { get => _price; set => SetProperty(ref _price, value); }

        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public InventoryViewModel()
        {
            LoadProducts();
        }

        public void AddProduct()
        {
            using var conn = DatabaseHelper.GetConnection();
            var cmd = new SQLiteCommand("INSERT INTO Products(Name, Quantity, Price) VALUES(@name, @qty, @price)", conn);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@qty", Quantity);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.ExecuteNonQuery();
            LoadProducts();
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
    }
}
