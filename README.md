Alright bro, no stress — I’ll give you the README.md **directly here in chat** so you can just **copy–paste** it into your README file manually.

This avoids download issues.
Here is your **FULL, FINAL, POLISHED README.md** exactly as you requested:

---

# ⭐ **FINAL README.md — COPY THIS INTO YOUR FILE**

```markdown
# UserPortal – ASP.NET Core MVC + SQL Server

A clean and modern **User Authentication Portal** built using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQL Server**, featuring user registration, login, secure hashed passwords, and a responsive UI.

---

## 🖼 Logo

![Logo](wwwroot/images/logo.png)

---

## 🚀 Features

- 🔐 User Registration  
- 🔑 Secure Login using BCrypt password hashing  
- 👤 Personalized Welcome Dashboard  
- 💾 SQL Server Database using Entity Framework Core  
- 💼 Session-Based Authentication  
- 🎨 Modern UI using Bootstrap  
- 📸 Screenshots available  
- 💻 Perfect for freshers showcasing .NET skills  

---

## 📸 Screenshots

> Ensure your screenshot filenames match these.  
> All images must be inside the `screenshots` folder.

### 🔹 Login Page  
![Login](screenshots/UserPortal_login.png)

### 🔹 Register Page  
![Register](screenshots/UserPortal_register.png)

### 🔹 My Account Page  
![My Account](screenshots/UserPortal_myaccount.png)

---

## 📁 Project Structure

```

UserPortal/
│
├── Controllers/
│   └── AccountController.cs
│
├── Models/
│   ├── AppDbContext.cs
│   ├── User.cs
│   ├── LoginViewModel.cs
│   └── RegisterViewModel.cs
│
├── Migrations/
│   └── (Auto-generated EF Core migrations)
│
├── Views/
│   ├── Account/
│   │   ├── Login.cshtml
│   │   ├── Register.cshtml
│   │   └── MyAccount.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
│
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   ├── js/
│   ├── lib/
│   └── images/
│       └── logo.png
│
├── screenshots/
│   ├── UserPortal_login.png
│   ├── UserPortal_register.png
│   └── UserPortal_myaccount.png
│
├── appsettings.json
├── Program.cs
├── UserPortal.csproj
└── README.md

```

---

## 🗄 Database Structure

The app uses a single table called **Users**.

### 📌 Users Table Schema

| Column       | Type            | Description                          |
|--------------|-----------------|--------------------------------------|
| **Id**       | int (PK)        | Primary key, auto-increment          |
| **FirstName**| nvarchar(100)   | User first name                      |
| **LastName** | nvarchar(100)   | User last name                       |
| **Phone**    | nvarchar(20)    | Mobile number                        |
| **Email**    | nvarchar(256)   | Email used for login                 |
| **Password** | nvarchar(max)   | Hashed password using BCrypt         |

### 🔐 Password Hashing

Passwords are hashed using:

```

BCrypt.Net.BCrypt.HashPassword(password)

```

Verification during login:

```

BCrypt.Net.BCrypt.Verify(plainText, hashedPassword)

````

---

## 🔧 Setup Instructions

### 1️⃣ Replace SQL Connection String in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SANTHOSH\\SQLEXPRESS;Database=UserPortalDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
````

### 2️⃣ Apply EF Core Migrations

In Package Manager Console:

```
Update-Database
```

### 3️⃣ Run the Application

Click **IIS Express** or run:

```
dotnet run
```

---

## 🧠 Tech Stack

* ASP.NET Core MVC
* Entity Framework Core
* SQL Server
* Bootstrap
* C#
* BCrypt.Net

---

## ⭐ Author

**Dulam Santhosh Satya Sai Naga Hanuman**
Aspiring .NET Developer — Fresher

This project demonstrates practical understanding of MVC architecture, database design, secure authentication, and UI development.

```

---


