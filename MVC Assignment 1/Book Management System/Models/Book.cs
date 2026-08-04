/*
Assignment - ASP.NET MVC Session 3: HTML Helpers, URL Helpers & Model Binding

Objective: Build a simple ASP.NET MVC application using the concepts covered in the training session.

Assignment - Book Management System

Scenario
Create a Book Management application without using a database.
Store all records in a static List<Book>.
Book Model
- BookId
- BookName
- Price
- Category

Requirements
1. Create a Book Registration page using HTML Helpers. 
2. Use a Strongly Typed View. 
3. Use Html.BeginForm() to submit the form. 
4. Receive submitted data using Model Binding. 
5. Store books in a static List<Book>. 
6. Display all books on a Book List page. 
7. Create a Book Details page. 
8. Use appropriate MVC concepts such as Html.ActionLink(), Url.Action(), Session, or Query String
wherever required.

Concepts to Demonstrate
• Strongly Typed View
• HTML Helpers
• URL Helpers
• Html.BeginForm()
• Model Binding
• Session
• Html.ActionLink()
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Book_Management_System.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public int Price { get; set; }

        public string Category { get; set; }
    }
}