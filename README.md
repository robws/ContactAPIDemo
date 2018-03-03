# ContactAPIDemo
Demo of a very simple Contact API and entry page

The following should take approximately 2 hours.  If you find that you are not going to complete all the requirements in that time, note where and how you would have addressed them in the code.  You will also have an opportunity to discuss these points.

# Problem

The Problem:  Design a web based mailing list application.  The following requirements are relatively simple, but the application should be designed so that it could be used as the basis for a more complete implementation.  In other words, use sound design patterns and coding practices.


# Requirements
1.	[ ] **Web Entry** Provide a simple html page in which a user can enter the following.  The page merely needs to be functional and does not need to be styled in any way.
a.	Last Name
b.	First Name
c.	email
2.	[ ] **Web Confirmation** When the user submits this data, a confirmation page should be displayed which tells the user the data was received by the system.
3.	[ ] **Save/Persistence** All data submitted in this way must be saved, but only for the duration of the application’s run.  It does not need to survive a restart of the application.  However, in your design consider that this application will ultimately have to save this data to a persistent datastore.
Notes:
Use Repository Pattern
4.	[ ] **EndPoint** A REST endpoint must be provided to retrieve all mailing list entries.  This endpoint should take 2 optional parameters:
a.	Last name- if specified, only records with this last name are returned
b.	Ascending/Descending flag which indicates how to sort records.  If not specified, default behavior is to sort ascending.  Records should be sorted by last name.  Where last names are equal, records should be sorted by first name.
5.	[ ] **Test** At least one automated test must be provided which tests one of your .net components.
__XUnit__
6.	[ ] **Deployment** Application should run in MS Internet Information Server.
[IIS Host in Development](http://www.c-sharpcorner.com/article/how-to-host-asp-net-mvc-5-and-web-api-on-iis-for-development-purpose/)
[IIS Host Test](http://www.c-sharpcorner.com/UploadFile/2b481f/how-to-host-Asp-Net-web-api-on-iis-server/)
7.	Security is not required for this exercise.
