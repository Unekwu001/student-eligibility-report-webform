Student Eligibility Report
----------------------------
Overview
Student Eligibility Report is a web application designed to manage and report student eligibility for sports and academic programs. Built with ASP.NET Web Forms and Entity Framework, the application allows users to submit student eligibility information, manage sports and college data, and view detailed error logs using ELMAH.

Features
---------
Student Eligibility Submission: Users can submit their eligibility information including personal details, sports history, and college history.
Dynamic Table Management: Add and manage multiple sports and college records dynamically.
Error Handling: ELMAH (Error Logging Modules and Handlers) integration for error logging and management.
Custom Error Pages: User-friendly error and success pages for a better user experience.
Asynchronous Operations: The application uses async/await patterns for database operations.

Table of Contents
Features
Technologies
Setup Instructions
Usage
Folder Structure
Contributing
License

Technologies
-------------
ASP.NET Web Forms: Framework for building dynamic web applications.
Entity Framework 6: ORM for database operations.
SQL Server: Database management system.
ELMAH: Error logging and management.
Bootstrap: CSS framework for responsive design.


Setup Instructions
-------------------
Prerequisites
.NET Framework 4.7.2 or higher
SQL Server
Visual Studio 2019 or higher

Clone the Repository
-------------------
git clone https://github.com/Unekwu001/student-eligibility-report-webform.git
cd student-eligibility-report-webform

Update the Connection String
Update the connection string in Web.config to match your SQL Server configuration
<connectionStrings>
    <add name="StudentEligibilityContext" connectionString="Data Source=(local);Initial Catalog=StudentEligibilityReportDb;Integrated Security=True;TrustServerCertificate=True;" providerName="System.Data.SqlClient" />
</connectionStrings>

Restore NuGet Packages
Open the solution in Visual Studio and restore NuGet packages:
Update-Package -reinstall
Build and Run
Build the solution and run the application:
dotnet build
dotnet run
Navigate to http://localhost:your-port to access the application.

Usage
-----------
Submitting Eligibility Information
Navigate to the Home page.
Fill in the student’s eligibility information.
Add multiple sports and college records.
Click the Submit button to save the information.
Viewing Error Logs
Navigate to http://localhost:your-port/elmah.axd to access the ELMAH error log page.
Review the logs for any recorded errors.
Error and Success Pages
Error Page: Custom error page for user-friendly error messages.
Success Page: Displays a thank you message after successful submission.


Folder Structure
--------------------
/Views
    /Site.master
    /Default.aspx
    /ErrorPage.aspx
/Content
    /images
        /vertex-logo.svg
/Scripts
    /js
    /css
/Models
    /StudentEligibility.cs
    /Sport.cs
    /College.cs
/StudentEligibilityDbContext
    /StudentEligibilityContext.cs
/Web.config
/Views: Contains master page and default page.
/Content: Stores images, CSS, and other static resources.
/Scripts: Contains JavaScript and CSS files.
/Models: Contains model classes for the application.
/StudentEligibilityDbContext: Contains database context for Entity Framework.
Web.config: Configuration file for the application.



Contributing
-----------------
Contributions are welcome! Please follow these guidelines for contributing:

Fork the Repository: Create a fork of the repository on GitHub.
Create a Feature Branch: Create a new branch for your feature or bug fix.

git checkout -b feature/your-feature
Make Your Changes: Implement the feature or fix the bug.
Commit Your Changes: Write clear commit messages.

git add .
git commit -m "Add feature or fix bug"
Push to Your Fork: Push your changes to your forked repository.

git push origin feature/your-feature
Open a Pull Request: Submit a pull request to the main repository.


License
----------
