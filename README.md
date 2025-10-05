# ProBizERP 🚀

**ProBizERP** is a professional desktop-based Enterprise Resource Planning (ERP) application tailored for **small and medium-scale businesses**. It streamlines **inventory management**, **sales tracking**, and **reporting** into a single, user-friendly application built with **C# WPF** and **SQLite**.  

---

## 🌟 Features

### Inventory Management
- Add, edit, and remove products
- Track stock levels in real-time
- Categorize products for easy access

### Sales Management
- Record sales transactions
- Manage invoices efficiently
- Monitor sales trends and revenue

### Reporting & Analytics
- Generate daily, weekly, and monthly reports
- Export reports in CSV or PDF format
- Visualize data with interactive charts

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|------------|
| Programming Language | C# |
| UI Framework | WPF (Windows Presentation Foundation) |
| Architecture | MVVM using Prism Framework |
| Database | SQLite |
| IDE | Visual Studio |
| Data Access | ADO.NET |
| Optional Libraries | LiveCharts, OxyPlot |

---

## 📂 Project Structure

```

ProBizERP/
├── ProBizERP.sln                # Visual Studio solution file
├── ProBizERP/
│   ├── App.xaml                 # Application definition
│   ├── App.xaml.cs              # Application logic
│   ├── MainWindow.xaml          # Main window UI
│   ├── MainWindow.xaml.cs       # Main window logic
│   ├── Views/
│   │   ├── InventoryView.xaml
│   │   ├── InventoryView.xaml.cs
│   │   ├── SalesView.xaml
│   │   ├── SalesView.xaml.cs
│   │   ├── ReportView.xaml
│   │   └── ReportView.xaml.cs
│   ├── ViewModels/
│   │   ├── InventoryViewModel.cs
│   │   ├── SalesViewModel.cs
│   │   └── ReportViewModel.cs
│   └── Models/
│       ├── Product.cs
│       ├── Sale.cs
│       └── DatabaseHelper.cs

````

---

## ⚡ Getting Started

### Prerequisites
- Windows OS
- [Visual Studio](https://visualstudio.microsoft.com/) 2019 or later
- .NET Framework 4.7.2 or higher

### Installation
1. Clone the repository:  
```bash
git clone https://github.com/hq969/ProBizERP.git
````

2. Open the solution file `ProBizERP.sln` in Visual Studio.

3. Restore NuGet packages if required.

4. Build and run the application.

---

## 🎯 Future Enhancements

* Multi-user login system with role-based access
* Cloud-based database support
* Advanced analytics dashboard with KPI tracking
* Integration with barcode scanners for inventory management

---

## 📧 Contact

**Developer:** Harsh Sonkar
**Email:** [contact.harshsonkar@gmail.com](mailto:contact.harshsonkar@gmail.com)
**LinkedIn:** [linkedin.com/in/harshsonkar](https://www.linkedin.com/in/harsh-sonkar-232573250/ )

---

## 📜 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---
