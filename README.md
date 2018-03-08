# ContactAPIDemo

This repo is an __incomplete__ demo of a very simple Contact API and entry page. _Though the task remains only 15-20% complete_, an approach was determined and some code was produced and placed in this repo. Below you'll find a general solution scope and notations on the individual requirements where work was complete/incomplete and what work is necessary to finish.

The code as it functions now provides an entry form, but does not process the form, and API that retrieves a fixed collection of records by ID, but does not have either a search feature or a mechanism for retrieving items added via the Views. There is no unit test project in this solution.

## Solution 

The major components of this proposed solution are as follows:

1. A REST API that pulls contact details from an in-memory repository via an interface (```iContactRepository```), 
2. An MVC implementation that provides 2 views, ```Create``` and ```Confirm```, which permit a user to add contact details to the repository and received a confirmation that those details are entered, and 
3. A unit test that uses the ```iContactRepository``` interface, a setup routine that populates contacts in a collection, and then tests the ```ContactsController``` endpoint methods.


## Overview

![Img](images/overview.png "Overview")


## Specific Notes on Requirements

1.	[x] **Web Entry** Provide a simple html page in which a user can enter the following.  The page merely needs to be functional and does not need to be styled in any way.
**I created two views and a controller to set this up but did not get the persistence/interface set up like I wanted. I imagined to be flexible and use proper patterns, the project ought to use a Repository pattern. But I didn't have time to do that.**

2.	[ ] **Web Confirmation** When the user submits this data, a confirmation page should be displayed which tells the user the data was received by the system.
**I worked on the ```ContractsEntryController``` and intended for that to redirect to a Confirmation view and pass the Contact object to the rendered view.**

3.	[ ] **Save/Persistence** All data submitted in this way must be saved, but only for the duration of the application’s run.  It does not need to survive a restart of the application.  However, in your design consider that this application will ultimately have to save this data to a persistent datastore.
** I could not figure out how to do in-memory persistence in the time alotted, but knew that the system needed to have a repository pattern/interface to accomplish the requirement to switch to a new data access type.**


4.	[ ] **EndPoint** A REST endpoint must be provided to retrieve all mailing list entries.  This endpoint should take 2 optional parameters:
a.	Last name- if specified, only records with this last name are returned
b.	Ascending/Descending flag which indicates how to sort records.  If not specified, default behavior is to sort ascending.  Records should be sorted by last name.  Where last names are equal, records should be sorted by first name.
**I was only able to get a rough API configured to return records from my Contact class. I imagine filtering would have happened via checking request attributes and running a LINQ query on the data in the persistence/data/model ** 
5.	[ ] **Test** At least one automated test must be provided which tests one of your .net components.
** Using interfaces in the design alongside the Repository Pattern would make this system testable without requiring access to the eventual data store that is chosen for the work.**

6.	[ ] **Deployment** Application should run in MS Internet Information Server.
** Wasn't sure whether or not this meant the demo should run within IIS or should be developed in IIS. I used IIS Express during development, but looked into how I'd do either of the other two things:'
[IIS Host in Development](http://www.c-sharpcorner.com/article/how-to-host-asp-net-mvc-5-and-web-api-on-iis-for-development-purpose/)
[IIS Host Test](http://www.c-sharpcorner.com/UploadFile/2b481f/how-to-host-Asp-Net-web-api-on-iis-server/)
