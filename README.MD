# Epicodus Independent Project - March 13, 2020

### Created by: Brandan Sayarath

## Description

This is the Epicodus independent end-of-week assignment for Friday, March 13, 2020.  The purpose of this assignment is to build an MVC application to help track vendors that purchase baked goods from a bakery and track the orders belonging to those vendors.  For example, the bakery might supply croissants to a vendor called "Suzie's Cafe" once a week. The bakery may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of their expanding business relationships.

## Behavior Driven Development Specifications

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
|If user visits '/' root route, display splash page with link to '/vendors' | user visits '/' route | display home|
| If user visits '/vendors' display list of all vendors, each with 'view menu' button, and 'add new vendor' button | user visits '/vendors' | display list of vendors|
| If user clicks 'Add new vendor' button, redirect to vendor form | clicks 'add new vendor' | redirect to '/vendors/new'|
| If user visits '/vendors/new' show new vendors form with field for "Vendor Name" | user visits '/vendors/new' | show vendor form |
| If user clicks submit on vendor form, add new vendor to List and redirect to '/vendors' | clicks submit | Add newvendor to List, redirect to '/vendors' |
| If user visits '/vendors/{id}', they will see the details of the vendor, including the menu items and buttons for 'Add new order' and 'go back'. | user visits vendor page | show vendor info and menu |

Specs to be continued...


## Setup/Installation Requirements

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/brandanpdx/vendor-tracker```
* ```$ cd word-counter```

To run the program, navigate to the VendorTracker production folder by typing the following into the terminal: 

* ```$ cd VendorTracker```

Then run the program by typing:
* ```$ dotnet run```


## Support and Contact

Please email Brandan Sayarath: brandan@brandan.tech for any questions.

## Technologies Used

This program was created with:

* C#
* ASP.NET Core MVC
* HTML
* CSS

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 Brandan Sayarath

