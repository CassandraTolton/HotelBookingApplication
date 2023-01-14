# Hotel Booking Application
**Languages:** C#, Dapper, SQL

## Description
A backend application that takes data from a sql server consisting of three tables. Clients, Rooms and Occupancies, all stored within the application as classes and uses a grid view to display the data. Can change the data from within the application ranging from adding, deleting and editing the data.


### Issues
several issues that need to be fixed:
  1. if you close the clients or room windows without using the close button it will stay open in the background, and if you try to open it again the app will crash <br>
     Fix: either auto close it before you open it again, or add and onclick event to the x and close it that way.
  2. when trying to remove clients, it will crash as its not converting the id from string to int.
    fix: rewrite the code so that it will properly convert and delete the client.
    
### Main Window

### Adding
*screenshots*
### Deleting
*screenshots*
### Editing
*screenshots*
### Exiting
*screenshots*
