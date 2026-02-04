# MarketCRUDProduct 🛒

A simple **ASP.NET MVC / ASP.NET Core** CRUD project to manage **Categories** and **Products**.  
This project is built for learning purposes and demonstrates core MVC concepts, Razor views, and basic repository patterns.

---

## 🚀 Features

- Category Management (Add, Edit, Delete, Details)
- Product Management (Add, Edit, Delete, Details)
- Category–Product relationship handling
- Prevent deleting a category if products exist
- Bootstrap-based responsive UI
- Confirmation modals & user-friendly alerts

---

## 🛠️ Tech Stack

- ASP.NET MVC / ASP.NET Core
- C#
- Razor Views
- Bootstrap 5
- In-memory Repository (no database)

---

## 📂 Project Structure

```

MarketCRUDProduct/
│
├── Controllers/
│   ├── HomeController.cs
│   ├── CategoriesController.cs
│   └── ProductsController.cs
│
├── Models/
│   ├── Category.cs
│   └── Product.cs
│
├── Repository/
│   ├── CategoryRepository.cs
│   └── ProductRepository.cs
│
├── Views/
│   ├── _ViewImports.cshtml     
│   ├── _ViewStart.cshtml      
│   │
│   ├── Home/
│   │   └── Index.cshtml
│   │
│   ├── Categories/
│   │   ├── Index.cshtml
│   │   ├── AddCategory.cshtml
│   │   ├── Edit.cshtml
│   │   └── Detail.cshtml
│   │
│   ├── Products/
│   │   ├── Index.cshtml
│   │   ├── AddProduct.cshtml
│   │   ├── EditProduct.cshtml
│   │   └── Details.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ValidationScriptsPartial.cshtml
│
└── wwwroot/


```

## ▶️ How to Run

1. Clone the repository
2. Open the project in **Visual Studio**
3. Restore dependencies
4. Run the project (`Ctrl + F5`)

---
## 🌐 Deployment

- Recommended (Free):
  - Azure App Service (Free Tier)
  - Fly.io

> Note: Platforms like **Vercel / Netlify** do not support ASP.NET MVC runtime.

---

## 📌 Purpose

This project is intended for:
- Learning ASP.NET MVC fundamentals
- Understanding CRUD operations
- Preparing for interviews and college projects

---

## 👤 Author

**Aditya Kumar**  
Learning-focused .NET MVC project 🚀

