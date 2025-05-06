# Oak Course

# 📚Training Course CMS

**A Content Management System for managing and displaying training courses.**

###  🌟 Overview
1. ## **Purpose**
  - A centralized platform for hosting and managing professional training courses.
  - Enables admins to publish, organize, and update training content dynamically.
  - Provides users with an intuitive interface to discover courses by popularity, category, or recency.

2. ## **Target Audience**
  - Admins/Trainers: Manage course content, track engagement (views/comments), and moderate user interactions.
  - Learners: Browse courses, access training materials, and engage via comments/messages.

3. ## **Core Functionalities**
   ### For Users (Frontend)
    **Breaking Trainings:** Highlight newly added courses.
   
    **Popular/Most Viewed:** Auto-generated based on user engagement.
   
    **Category Filtering:** Structured navigation for seamless discovery.
   
   ## For Admins (Backend)
  	#### Dashboard Analytics:
    - Real-time stats (posts, views, comments, messages).
   
  	#### Content Management:
    - Posts: Full CRUD (Create, Read, Update, Delete) for training materials.
    - Categories: Hierarchical organization of courses.
   
  	#### Site Customization:
  	- Branding (logo, favicon, meta tags)
    - Manage contact addresses, social links, and advertisements.
   
  	#### Moderation Tools:
    - Approve/reject user comments.
    - Track and respond to messages.

5. ## **Unique Selling Points (USPs)**
- Role-Based Access: Secure admin portal with restricted permissions.
- Dynamic Display Logic: Automatically surfaces trending/breaking content.
- Scalable Architecture: Built with Entity Framework and MVC, ensuring maintainability.


5. ## **Technical Highlights**
- Database-Driven: SQL Server stores all content (courses, users, comments).
- SEO-Friendly: Customizable meta tags and clean URL structures.
- Responsive Design: Works on desktop and mobile (if implemented).


### Key Features

✔**User-Friendly Frontend**

- Breaking trainings (latest courses)

- Most viewed & popular trainings

- Training categories

✔ **ADMIN PORTAL (SECURE LOGIN-BASED)**

- Dashboard: Post counts, total views, comments, messages

- Site Settings: Favicon, logo, meta tags, site title

- Address Management: List & add addresses

- Social Media Links: List & add social media profiles

- Ads Management: List & add advertisements

- Category Management: List & add training categories

- Post Management: List & add training posts

- User Management: Update user details

- Comment Moderation: Approve/unapprove comments

- Message Handling: View all/ Unread messages


## 🛠 Technologies Used

- Backend :  ASP.NET MVC, C#, ADO.NET, Entity Framework
- Frontend:  Razor Pages, HTML5, CSS3, JavaScript
- Database:  SQL Server, SSMS
- Architecture:  MVC Pattern, Entity Framework

##  🚀 Setup & Installation
**Prerequisites**

- Visual Studio 2022+

- .NET 6.0+

- SQL Server (LocalDB or Express)

## 📂 Project Structure

**Training-Course-CMS/  **
├── Controllers/          # MVC Controllers (Admin, Posts, Comments, etc.)  
├── Models/              # Entity Framework Models & ViewModels  
├── Views/               # Razor Pages & Frontend  
├── Data/                # DbContext & Repositories  
├── Migrations/          # Entity Framework DB Migrations  
├── wwwroot/             # Static files (CSS, JS, Images)  
├── appsettings.json     # Configuration & DB connection  
└── Program.cs           # Startup configuration  


# Screenshots
![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Add%20category%20page.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Address%20list%20page.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Admin%20landing%20page.png?raw=true)


![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/All%20comments%20page.png?raw=true)


![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Application%20landing%20page.png?raw=true)


![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/admin%20login%20page.png?raw=true)


![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Landing%20pag2.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Landing%20page1.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Post%20detail%20page.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/Post%20detail%20page2.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/category%20list%20page.png?raw=true)

![image alt](https://github.com/ujwalg63/OakCourseProjectMVC/blob/master/post%20detail%20page%203.png?raw=true)

**End**
