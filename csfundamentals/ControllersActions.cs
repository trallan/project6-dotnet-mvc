/*

Controller:
A controller is a class that inherits from Microsoft.AspNetCore.Mvc.Controller.
It serves as a logical grouping of related actions and is responsible for processing user input, interacting with models (data), and selecting views (UI) to render.
Controllers, by convention, reside in the Controllers folder of an ASP.NET Core MVC project and have names ending with "Controller" (e.g., HomeController, ProductsController).
They are activated and disposed of on a per-request basis, ensuring efficient resource management.



Action:
An action (or action method) is a public method within a controller class.
Each action is designed to handle specific types of HTTP requests (e.g., GET, POST, PUT, DELETE) and return a result.
Examples of action results include:
-Views: For rendering HTML pages.
-JSON data: For building APIs.
-File results: For serving files.
-Redirects: For navigating to other URLs.
Actions are mapped to incoming requests through routing, where URL patterns are matched to specific controller actions. 
For example, a request to /Home/Index would typically invoke the Index() action method within the HomeController. 


Relationship:
Controllers provide the structure for organizing actions, while actions are the individual units of work within that structure that directly handle and respond to web requests. 
This separation of concerns promotes maintainable and scalable web applications.

*/