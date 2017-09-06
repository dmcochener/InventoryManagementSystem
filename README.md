# InventoryManagementSystem
This Inventory Management System was a group project developed to help a food cart manage it's ingredients used. The model is based on a simple sandwich shop. I worked on the initial two week sprint. Through the project we had several issues with merging code. The code posted here is not the final version, but it include all of my work, and very little other work. The main item in this code I did not develop is the search functionality. The rest was developed by me. 

# Objective
The main objective of the project was to build a code first MVC solution to an inventory management system. The minimal viable product would include an ingredients list and menu items, with full CRUD control, with relationships between the two classes. It needed to be able to track ingredients used based on menu items, and display a weekly report of how much profit was made. The lists of ingredients and menu items should also be searchable.

# Steps Taken
We started off by dividing up tasks. The time schedule of my collaborator was later in the day than mine, so I started off building the basic functionality. I created the ingredient and menu item classes, created controllers and views for CRUD functionality, and then linked the classes. My collaborator created the search functionality. I then created a weekly report class, controller, and views. With minimal viable product achieved about half-way through the sprint, we started adding funcitonality. I added the ability to save the data from the weekly reports, which included creating two new classes of used ingredients and sold menu items. I identified a few other minor issues to fix, such as we'd neglected to have the quanitity of ingreidients be reduced after the weekly report is created and saved. I fixed the issues I identified, and added some display information to detail views, and created a home page. I then made a short list of additional issues I had noticed, and passed them on to the project manager for the next group working on this project.

# Results
I created from the group up a minimal working product that could track inventory for a food cart style restaurant. I learned a great deal about how things are saved to databases, and what data types cannot be saved, like dictionaries. I improved my skills in C# and developed confidence in my ability to create work-arounds for issues where the direct approach doesn't work due to code constraints. I completed my work quickly and efficiently, allowing me time to add in functionality and identify future concerns, such as the need to be able to modify the ingredients linked to a menu item without having to hard code it-- a concern I didn't get to but passed on for the next sprint. It was also a great experience in debugging issues that arise from sharing code, having to roll back changes, and using source control. I also learned how to use a basic project management cloud based software (TFS).
