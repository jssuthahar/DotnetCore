# MSDEVBUILD Shop - ASP.NET Core MVC Shopping Cart

## Overview
MSDEVBUILD Shop is a simple e-commerce web application built with ASP.NET Core MVC. The project includes product listing, shopping cart management using session, order placement, and user authentication. It also supports email notifications and localization using resource files.

## Features
- Product listing page with images and prices
- Add to cart and remove from cart functionality
- Session-based cart management
- Order placement and checkout
- User authentication (Login and Registration)
- Email notification on successful registration
- Localization support for different languages

## Technologies Used
- **Backend:** ASP.NET Core MVC
- **Frontend:** Bootstrap 5
- **Session Management:** ASP.NET Core Session
- **Email Service:** MailKit (for sending emails)
- **Localization:** Resource files (.resx)
- **Database (if needed):** SQL Server / In-Memory

## Project Structure
```
MSDEVBUILD_Shop/
│-- Controllers/
│   ├── ProductController.cs
│   ├── CartController.cs
│   ├── AuthController.cs
│-- Models/
│   ├── Product.cs
│   ├── CartItem.cs
│   ├── Order.cs
│-- Views/
│   ├── Product/Index.cshtml
│   ├── Cart/Index.cshtml
│   ├── Cart/OrderSuccess.cshtml
│   ├── Auth/Login.cshtml
│   ├── Auth/Register.cshtml
│   ├── Shared/_Layout.cshtml
│-- Resources/
│   ├── CartController.en-US.resx
│   ├── CartController.tn-IN.resx
│-- Services/
│   ├── EmailService.cs
│-- wwwroot/
│   ├── images/ (Product images)
│-- appsettings.json
│-- Program.cs
│-- Startup.cs (if applicable)
```

## Installation and Setup
### Prerequisites
- .NET SDK (6.0 or later)
- Visual Studio / VS Code
- SQL Server (if database is used)

### Steps to Run
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/MSDEVBUILD_Shop.git
   cd MSDEVBUILD_Shop
   ```
2. Configure **appsettings.json** for email settings (MailKit SMTP)
3. Run the application:
   ```sh
   dotnet run
   ```
4. Open `http://localhost:5000` in your browser.

## Configuration
### Email Settings (appsettings.json)
```json
"EmailSettings": {
  "SMTPServer": "smtp.gmail.com",
  "Port": 587,
  "SenderEmail": "your-email@gmail.com",
  "Password": "your-app-password"
}
```
### Localization
- Resource files (`.resx`) should be placed inside the **Resources/** folder.
- Example: `CartController.en-US.resx`, `CartController.tn-IN.resx`

## Future Enhancements
- Payment gateway integration
- User profile and order history
- Product reviews and ratings
- Inventory management system

## License
This project is open-source and available under the MIT License.

## Author
MSDEVBUILD Team

