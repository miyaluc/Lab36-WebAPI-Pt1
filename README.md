![cf](http://i.imgur.com/7v5ASc8.png) Lab36-WebAPI-Pt1
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a directory named `lab-#`; + `<your name>` **e.g.** `lab36-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions
- We will be creating a new project this week. It will be an api backend. No frontend will be created for this project.
- Problem Domain: Your choice. Pick something that can be a single resource, and extended to a double resource (i.e. We are making Tasks first, then associating those tasks with lists in a couple days)
1. Create a new empty project, and build out the site so that it enables Mvc (no need to have a default route) and DbContext/database.
2. Reviewing what the HTTP actions are, create a "Get" Action that brings in an Id from the url, and displays the information back out to the body of the request. (Only have it grab the ID, we will pull all tasks in a later lab). 
3. Your Controller must:
  - Include Attribute routing
  - include Model Binding
  - include Id constraints
  - include a route token
  - 
3. Attempt a POST action, and make it take in and save information. 
4. Add xUnit testing to your project, Craete at least 3 unit tests for your project for this lab.  
5. COMMENT your code. Clearly. Identify the above requirements within your code. It is important that ALL The code written in this project is yours and you comment exaclty what/why everything is going on. 
6. Use Postman to test your API.

## ReadMe
- Your readme should include the following information:
	- How long did it take you to complete this assignment?
	- What did you struggle with? Why? How did you solve?
	- What did you learn during this assignment?
    - What resources did you utilize for this assingment?

## Rubric
- 3pts: Get Action with requirements of the controller
- 3pts: Code started from an empty project, has MVC, and dbcontext/database
- 2pts: Code is clearly commented.
- 2pt: Readme included with answers to questions
