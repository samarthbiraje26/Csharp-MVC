/*
Assignment: Student Admission Form

Objective - 
Create a Student Admission Form using ASP.NET MVC, JavaScript, and jQuery. Use JavaScript/jQuery to perform DOM manipulation, event handling, client-side validation, and AJAX.

Student Admission Form
Fields
• Student Name (TextBox)
• Email (TextBox)
• Course (DropDown)
• Age (TextBox)
• Gender (Radio Buttons)
• Hostel Required (CheckBox)

Buttons
• Save
• Clear

Output
• Student List (HTML Table)

Requirements
Part 1 – Document Ready
Display a message in the browser console when the page loads.

Part 2 – jQuery Events
Implement:
• click() – Save and Clear buttons
• keyup() – Display 'Typing: Student Name'
• blur() – Validate Email when leaving the Email textbox
• change() – Display the selected Course

Part 3 – DOM Manipulation
Use:
• .val()
• .text()
• .html()
• .append()
• .css()
• .addClass()
• .removeClass()

Part 4 – Create JavaScript Object
Read all form values and create a JavaScript object named student.

Part 5 – Client-side Validation
Validate:
• Student Name is required
• Email is required
• Course must be selected
• Age must be greater than 18
• Gender must be selected

Part 6 – AJAX
Call /Student/Save using $.ajax() and display 'Student Saved Successfully.'

Part 7 – Display Data
Append the student details into an HTML table after a successful save.

Part 8 - Tasks
• Clear all controls
• Highlight invalid controls
• Display total students added
• Show a success message

Submission
Must submit:
• ASP.NET MVC Project
• Student Model
• Student Controller
• Index View
• student.js
• Client-side Validation
• AJAX Implementation
• Working Student List
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment_2.Models
{
    public class Student
    {
        public string StudentName { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public bool HostelRequired { get; set; }
    }
}