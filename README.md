Student Eligibility Report
-------------------------------
-------------------------------
**Quickly Run the Project on visual studio**
1. Ensure you have Asp .NET 4.7.2 Sdk installed on visual studio before cloning this project.
2. Clone and Build solution.
3. Set Default.aspx as start up page. Default.aspx can be found inside the views folder.
4. Run the project.
5. To view Elmah page , go to https://localhost:44389/elmah.axd. (Note that your port may be different from mine)

**Overview**
Student Eligibility Report is a web application designed to manage and report student eligibility for sports and academic programs. Built with ASP.NET Web Forms and Entity Framework, the application allows users to submit student eligibility information, manage sports and college data, and view detailed error logs using ELMAH.

Features
---------
Student Eligibility Submission: Users can submit their eligibility information including personal details, sports history, and college history.
Dynamic Table Management: Add and manage multiple sports and college records dynamically.
Error Handling: ELMAH (Error Logging Modules and Handlers) integration for error logging and management.
Custom Error Pages: User-friendly error and success pages for a better user experience.
Asynchronous Operations: The application uses async/await patterns for database operations.

**Table of Contents**
1. Features
2. Technologies
3. Setup Instructions
4. Usage
5. Folder Structure
6. Contributing
7. License

Technologies
-------------
1. ASP.NET Web Forms: Framework for building dynamic web applications.
2. Entity Framework 6: ORM for database operations.
3. SQL Server: Database management system.
4. ELMAH: Error logging and management.
5. Bootstrap: CSS framework for responsive design.


Setup Instructions
-------------------
Prerequisites
1. .NET Framework 4.7.2 or higher
2. SQL Server
3. Visual Studio 2019 or higher

Clone the Repository
-------------------
1. git clone https://github.com/Unekwu001/student-eligibility-report-webform.git
2. cd student-eligibility-report-webform
3. Update the Connection String
4. Update the connection string in Web.config to match your SQL Server configuration
<connectionStrings>
    <add name="StudentEligibilityContext" connectionString="Data Source=(local);Initial Catalog=StudentEligibilityReportDb;Integrated Security=True;TrustServerCertificate=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
5. Restore NuGet Packages
6. Open the solution in Visual Studio and restore NuGet packages:
7. Update-Package -reinstall
8. Build and Run
9. Build the solution and run the application:
10. dotnet build
11. dotnet run
12. Navigate to http://localhost:your-port to access the application.

Usage
-----------
**Submitting Eligibility Information**
1. Navigate to the Home page.
2. Fill in the student’s eligibility information.
3. Add multiple sports and college records.
4. Click the Submit button to save the information.
5. Viewing Error Logs
6. Navigate to http://localhost:your-port/elmah.axd to access the ELMAH error log page.
7. Review the logs for any recorded errors.
8. Error and Success Pages
9. Error Page: Custom error page for user-friendly error messages.
10. Success Page: Displays a thank you message after successful submission.


Folder Structure
--------------------
/Views
    /Site.master
    /Default.aspx
    /ErrorPage.aspx.
    
/Content
    /images
        /vertex-logo.svg.
        
/Scripts
    /js
    /css.
    
/Models
    /StudentEligibility.cs
    /Sport.cs
    /College.cs.
    
/StudentEligibilityDbContext
    /StudentEligibilityContext.cs.
    
/Web.config.

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
