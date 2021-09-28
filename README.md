# RaffleApp
Web application that populates a database with 20 "people" (Automatically these all have my name and a index identifier at the end)

Done using simple TDD.
Backend was built using SOLID principles and for the frontend I used HTML, VUE, JS and Boostrap as well as SweetAlerts. (And MVC)

Script to populate the database is already written and will run when the page is opened (As soon as the program is ran) user also has the option to wipe and repopulate the database to generate new ID's and delete the old ones.

Throws error (Shown in sweetalert, with full stack trace), as well as a well-selected Exception (Which is tested)  explaining the error.

Only two possible human errors are:
1: Input number is higher than amount of people in database.
2: Input number is a negative number.

Made use of interfaces and reusable code.
Amount of code is minimum and very easy to read/improve.
