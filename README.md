# RaffleApp
Web application that populates a database with 20 "people" (Automatically these all have my name and a index identifier at the end).
Then on the website you can select a number of winners and will randomly generate n amount of winners and show them on screen.
Has button to repopulate database which just removes all current Tables and generates new ones, with new ID's)

Done using simple TDD.
Backend was built using SOLID principles and for the frontend I used HTML, VUE, JS and Boostrap as well as SweetAlerts. (And MVC)

Script to populate the database is already written and will run when the page is opened (As soon as the program is ran) user also has the option to wipe and repopulate the database to generate new ID's and delete the old ones.

Throws error (Shown in sweetalert, with full stack trace), as well as a well-selected Exception (Which is tested)  explaining the error.

Only two possible human errors are:
1: Input number is higher than amount of people in database.
2: Input number is a negative number.

Uses microsoft Entity Framework
Made use of interfaces and reusable code.
Amount of code is minimum and very easy to read/improve.
