# 👨‍💼 Employee Management System (WPF Desktop App)

A modern Windows desktop application built with **WPF (Windows Presentation Foundation)** that allows organizations to manage employees, attendance, leaves, and payroll in one unified system.

--

## 📖 Overview

The **Employee Management WPF App** is a desktop-based HR tool designed for small to medium businesses. It helps automate tasks like managing employee records, tracking attendance, processing payroll, and handling leave requests — all within a secure and intuitive desktop environment.

---

## 🚀 Features

- 🔐 Secure Login with Role-Based Access
- 👥 Employee Records Management
- 🕒 Attendance Tracking with Reports
- 🏖️ Leave Application & Approval Workflow
- 💵 Payroll Generation & Payslip Export
- 📁 Document Upload & Viewer
- 📊 In-App Dashboard & Reporting

---

## 🛠️ Tech Stack

| Layer         | Technology                |
|---------------|----------------------------|
| UI Framework  | WPF (.NET 6 / .NET Framework) |
| Architecture  | MVVM (Model-View-ViewModel) |
| Database      | SQLite / SQL Server        |
| Reporting     | RDLC / LiveCharts / PDFSharp |
| Data Access   | Entity Framework Core       |
| Styling       | MahApps / Material Design   |

---

## ✅ Functional Requirements

### 1. User Login & Roles
- Login form with credential validation.
- Load different dashboards for Admin, HR, Employee.
- Secure session handling (locally stored).

### 2. Employee Management
- Add/Edit/Delete employee details.
- Search, filter, and sort employees.
- Upload/view documents (image, PDF).

### 3. Attendance Management
- Manual Check-In / Check-Out per employee.
- Daily/Monthly summary reports.
- Export attendance to Excel/PDF.

### 4. Leave Management
- Apply for leaves with type and date range.
- Approve/Reject by Admin/HR.
- Leave history and balance tracking.

### 5. Payroll Management
- Configure employee salary structure.
- Generate payroll monthly.
- Export payslip to PDF or Excel.
- Print payslip.

### 6. Document Management
- Upload scanned ID proofs, resumes, etc.
- View images and open PDF files in-app.

### 7. Notifications
- Show in-app alerts for:
  - Pending approvals
  - Contract expiry
  - Monthly payroll processing

### 8. Dashboard & Reporting
- Display total employees, monthly salary stats, and leave charts.
- Use charts for visual summaries (via LiveCharts/OxyPlot).

