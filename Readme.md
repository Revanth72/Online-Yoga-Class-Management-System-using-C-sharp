## Yoga Class Management System  
*A web-based platform for managing online yoga classes.*  

### **Table of Contents**  
- [Introduction](#introduction)  
- [Features](#features)  
- [Technologies Used](#technologies-used)  
- [Installation](#installation)  
- [Database Setup](#database-setup)  
- [Usage](#usage)  
- [Screenshots](#screenshots)  
- [Contributing](#contributing)  
- [License](#license)  

---

## Introduction  
The **Yoga Class Management System** is a web-based application that allows users to register, log in, and book yoga classes online. Instructors can manage class schedules, while users can view available classes and make bookings.

---

## Features  
✅ User registration and authentication  
✅ Class scheduling and management  
✅ Booking system for yoga classes  
✅ Responsive UI with HTML, CSS, and jQuery  
✅ Database integration with MS SQL  
✅ Built with C# and ASP.NET Core  

---

## Technologies Used  
- **Frontend:** HTML, CSS, jQuery  
- **Backend:** C#, ASP.NET Core MVC  
- **Database:** MS SQL Server  
- **Tools:** Visual Studio 2019, Git  

---

## Installation  

### 1. Clone the Repository 
```bash
git clone https://github.com/Revanth72/Online-Yoga-Class-Management-System-using-C-sharp.git
cd Online-Yoga-Class-Management-System-using-C-sharp
```

### 2. Setup Database  
- Open **SQL Server Management Studio (SSMS)**  
- Run the script in `Database/YogaDB.sql` to create tables  

### 3. Run the Application  
- Open **Visual Studio 2019**  
- Load `YogaClassManagement.sln`  
- Press `F5` to start the application  

---

## Database Setup  
Use the following SQL script to create the database:  

```sql
CREATE DATABASE YogaDB;
USE YogaDB;

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL
);

CREATE TABLE Classes (
    ClassId INT PRIMARY KEY IDENTITY(1,1),
    ClassName NVARCHAR(100) NOT NULL,
    Instructor NVARCHAR(100),
    Schedule DATETIME
);

CREATE TABLE Bookings (
    BookingId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    ClassId INT FOREIGN KEY REFERENCES Classes(ClassId),
    BookingDate DATETIME
);
```

---

## Usage  
1. **User Registration & Login**  
   - New users can register and log in  
2. **View Class Schedule**  
   - Users can browse available yoga classes  
3. **Book a Class**  
   - Users can enroll in a class  
4. **Instructor Management**  
   - Admins can manage schedules  

---




---

## **Contributing**  
💡 Want to improve this project? Feel free to contribute!  
1. Fork the repository  
2. Create a new branch (`feature-new-functionality`)  
3. Commit your changes (`git commit -m "Added new feature"`)  
4. Push to the branch (`git push origin feature-new-functionality`)  
5. Create a Pull Request  

---



