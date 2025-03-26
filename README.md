# Hotel Management System
###### Version 1.0.0.0

## 🌟 Overview
A professional desktop application built with Windows Forms (.NET) for comprehensive hotel management. This system streamlines daily hotel operations with a modern, user-friendly interface.

### 🔑 Default Login Credentials

#### Admin Access
- **Login:** admin
- **Password:** password

#### User Access
- **Login:** user1
- **Password:** password1

### 🚀 Features

#### Core Functionality
- 🔐 Secure authentication system
- 👔 Role-based access control
- 🏨 Room management
- 👥 Customer management
- 📊 Admin dashboard
- 🌤️ Weather integration for local conditions

#### User Interface
- 🎨 Modern Material Design
- 🖥️ Responsive layout
- 🌈 Professional color scheme with DarkOrange accents
- 🔤 Montserrat font family implementation

### 💻 Technical Stack

#### Backend
- C# (.NET Framework 4.8)
- MS SQL Server (LocalDB)

#### Frontend
- Windows Forms
- Custom UI controls
- Material Design principles

### 📋 Requirements
- Windows OS
- .NET Framework 4.8
- SQL Server LocalDB
- Minimum resolution: 650x450

### 🔧 Installation

```bash
# Clone repository
git clone https://github.com/yourusername/Hotel-Management-System.git

# Open solution
Open Hotel-Management-System-WinFormsApp.sln in Visual Studio

# Restore packages
dotnet restore

# Build and run
Press F5 in Visual Studio
```

### 📸 Screenshots
<div align="center">
  <img src="https://github.com/user-attachments/assets/e55b14b6-74bb-4995-91ec-238718fea973" alt="Login Screen" width="400"/>
  <img src="https://github.com/user-attachments/assets/5abffcad-0067-49a7-92bf-44876173847c" alt="Dashboard" width="400"/>
  <img src="https://github.com/user-attachments/assets/248be51b-b7b8-4c0a-aaea-860bcbc952d6" alt="Dashboard" width="400"/>
  <img src="https://github.com/user-attachments/assets/111a2d84-eb13-4cee-856a-0a545e897c8b" alt="Dashboard" width="400"/>
</div>


### 🔒 Security Features
- Password hashing
- Session management
- Input validation
- Secure database connections

### 🛠️ Configuration
```xml
<connectionStrings>
    <add name="HotelDb"
         connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelManagmentSystem_Db.mdf;
         Integrated Security=True;Connect Timeout=30"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 🤝 Contributing
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
