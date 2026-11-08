# 🏥 Clinic Management System

A Windows desktop application for running the day-to-day operations of a medical clinic — patients, staff, check-up types, suppliers and database maintenance — built with **C# WinForms** and **SQL Server**.

![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-WinForms-5C2D91?style=flat-square&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)

## ✨ Features

- **Authentication & users** — login screen, add / manage users
- **Patients** — register new patients, search and update patient records
- **Staff** — add staff members, search and manage staff
- **Check-up types** — define the examination / check-up types the clinic offers
- **Suppliers** — add and manage suppliers
- **Clinic information** — configure the clinic's name and details
- **Server settings** — configure the database connection from the UI
- **Backup & restore** — back up and restore the clinic database
- **Reports** — printable RDLC reports (e.g. patients report)

## 🧱 Project structure

```
Clinic Management System/
├── BL/                  # Business layer (Login, Patient, Staff, Supplier, CheckType, ServerSettings)
├── Data Access Layer/   # Database connection & data access
├── PL/                  # Presentation layer – WinForms screens
├── UC/                  # User controls (new staff, manage staff)
├── *.rdlc               # Printable reports (patients)
└── Program.cs
```

## 🚀 Getting started

1. Open `Clinic Management System/Clinic Management System.sln` in Visual Studio.
2. Create / attach the clinic database on SQL Server.
3. Run the app and set the server name from **Server Settings**.
4. Build and run (F5).

---
👤 **Ahmed Hamam** · [LinkedIn](https://www.linkedin.com/in/ahmedhamam50/) · [Portfolio](https://ahmedhamam.github.io)
