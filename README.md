# 🏢 ERPModule – WPF Desktop ERP Application

### A **desktop-based ERP application** built with **C#, WPF, Prism, and SQLite**, designed to streamline inventory, sales, and reporting processes for small and medium-scale businesses.

---

## 🚀 Overview

The **ERPModule** helps businesses manage core operations efficiently:

* 📦 **Inventory Management** — Track products, stock levels, and suppliers.
* 💰 **Sales & Orders** — Record sales, generate invoices, and manage orders.
* 📊 **Reporting & Analytics** — View performance metrics, sales trends, and inventory summaries.
* 🗂️ **Database Integration** — Persist data locally using SQLite.
* 🧩 **Modular Architecture** — Built using MVVM design pattern for maintainability.

---

## 🧱 Tech Stack

| Layer                                 | Technology Used                       |
| ------------------------------------- | ------------------------------------- |
| **UI / Frontend**                     | WPF (Windows Presentation Foundation) |
| **Architecture**                      | MVVM with Prism Framework             |
| **Database**                          | SQLite                                |
| **Dependency Injection & Modularity** | Prism                                 |
| **Platform**                          | Windows Desktop                       |

---

## 📂 Project Structure

```
ERPModule/
│
├── App.xaml                 # Application definition
├── App.xaml.cs              # Application logic
├── MainWindow.xaml          # Main window UI
├── MainWindow.xaml.cs       # Main window logic
│
├── Views/                   # WPF Views (XAML)
│   ├── InventoryView.xaml
│   ├── InventoryView.xaml.cs
│   ├── SalesView.xaml
│   ├── SalesView.xaml.cs
│   ├── ReportView.xaml
│   └── ReportView.xaml.cs
│
├── ViewModels/              # MVVM ViewModels
│   ├── InventoryViewModel.cs
│   ├── SalesViewModel.cs
│   └── ReportViewModel.cs
│
└── Models/                  # Data Models & Helpers
    ├── Product.cs
    ├── Sale.cs
    └── DatabaseHelper.cs
```

---

## ⚙️ Setup & Installation

### Step 1: Clone Repository

```bash
git clone https://github.com/hq969/ERPModule.git
cd ERPModule
```

### Step 2: Restore NuGet Packages

Open **ERPModule.sln** in Visual Studio. Ensure all NuGet packages (Prism, SQLite) are restored.

### Step 3: Build & Run

* Press **F5** in Visual Studio to run the application.
* The **MainWindow** will open, allowing navigation to Inventory, Sales, and Reports views.

---

## 📱 Application Flow

1. **MainWindow** → Dashboard with navigation menu.
2. **InventoryView** → Add, update, or delete products and manage stock levels.
3. **SalesView** → Record sales, generate invoices, and view daily transactions.
4. **ReportView** → Generate reports for sales, inventory, and performance metrics.

---

## 🔒 Future Enhancements

* 🧩 Cloud multi-user sync
* 📊 Advanced reporting with charts and export options
* 🏷️ Barcode scanning for inventory management
* 🤖 AI-assisted sales predictions

---

## 👨‍💻 Author

**Harsh Sonkar**

* ✉️ Email: [contact.harshsonkar@gmail.com](mailto:contact.harshsonkar@gmail.com)
* 📞 Phone: 6261205490
* 🌐 [LinkedIn](https://www.linkedin.com/in/harsh-sonkar-232573250/)

---
