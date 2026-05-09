# 🐾 ZooShop

A full-stack e-commerce web application for a pet supplies store, built with **ASP.NET Core MVC** and **Entity Framework Core**. Features user authentication, a product catalog, and a session-based shopping cart.

## 📸 Screenshots

> _Add screenshots of the app here_

## ✨ Features

- 🔐 **User Registration & Login** — cookie-based authentication with form validation
- 🛍️ **Product Catalog** — browse all available pet products with images and descriptions
- 🛒 **Shopping Cart** — add and remove items, session-persisted between pages, with auto-calculated total price
- 👤 **Personal Area** — protected page, accessible only to authorized users
- 📦 **Delivery & Pickup** — dedicated pages for delivery info and pickup point locations
- 📬 **Contacts** — store contact information page

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | ASP.NET Core MVC 3.1 |
| ORM | Entity Framework Core |
| Database | Microsoft SQL Server |
| Frontend | Razor Views, Bootstrap 4, jQuery |
| Authentication | Cookie Authentication (ASP.NET Core Identity-compatible) |
| Session | Distributed Memory Cache + ASP.NET Session |

## 🏗️ Architecture

The project follows the standard **MVC pattern** with a clean separation of concerns:

```
MyEShop/
├── Controllers/
│   ├── HomeController.cs       # Main pages + auth logic (login/register)
│   ├── CartController.cs       # Cart: add, remove, view (session-based)
│   └── ArticlesRepository.cs  # Repository pattern for user persistence
├── Models/
│   ├── Products.cs             # Product entity
│   ├── Cart.cs                 # Cart model with total price calculation
│   ├── Users.cs                # User entity with validation attributes
│   └── ApplicationContext.cs  # EF Core DbContext
├── ViewModels/
│   ├── LogModel.cs             # Login form view model
│   └── RegModel.cs             # Registration form view model
├── Views/
│   ├── Home/                   # Catalog, Delivery, Contacts, Auth pages
│   ├── Cart/                   # Cart view
│   └── Shared/_Layout.cshtml  # Shared layout with navigation
└── wwwroot/                    # Static assets (CSS, JS, images, icons)
```

## 🚀 Getting Started

### Prerequisites

- [.NET Core SDK 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- Microsoft SQL Server (LocalDB or full instance)
- Visual Studio 2019+ or Rider

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/NackBard/ZooShop.git
   cd ZooShop/MyEShop
   ```

2. Update the connection string in `appsettings.json` to point to your SQL Server instance:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=Shop_Database;Trusted_Connection=True;"
     }
   }
   ```

3. The database and tables are created automatically on first launch via `Database.EnsureCreated()`.

4. Run the application:
   ```bash
   dotnet run
   ```

5. Open your browser at `https://localhost:5001`.

## 🔑 How It Works

**Authentication** is handled via ASP.NET Cookie Authentication. On login, the user's email is stored as a Claim and a secure cookie is issued. The `/` (home) route is protected with `[Authorize]` and redirects unauthenticated users to the login page.

**Shopping Cart** is stored in the server-side session as a serialized JSON object. Items can be added from the catalog and removed from the cart view, with the total price calculated automatically.

**Database** uses Entity Framework Core's code-first approach — models are defined in C# and EF Core handles schema creation.

## 🔮 Roadmap

- [ ] Password hashing (bcrypt / ASP.NET Identity)
- [ ] Product categories and filtering
- [ ] Order placement and order history
- [ ] Admin panel for product management
- [ ] Quantity selection in the cart
- [ ] Search functionality

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

> Built with ❤️ using ASP.NET Core MVC and Entity Framework Core
