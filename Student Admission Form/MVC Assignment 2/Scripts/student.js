$(document).ready(function () {

    console.log("Student Admission Form Loaded");

    var totalStudents = 0;

    $("#btnSave").click(function () {

        $(".error-message").text("");
        $(".form-control").removeClass("invalid");
        $("input[name='Gender']").removeClass("invalid");
        $("#successMessage").text("");

        var studentName = $("#StudentName").val().trim();
        var email = $("#Email").val().trim();
        var course = $("#Course").val();
        var age = $("#Age").val();
        var gender = $("input[name='Gender']:checked").val();
        var hostelRequired = $("#HostelRequired").is(":checked");

        var emailPattern = /^[a-zA-Z0-9._%+-]+@gmail\.com$/;

        var isValid = true;


        if (studentName == "") {

            $("#nameError").text("Student Name is required.");

            $("#StudentName")
                .val("")
                .attr("placeholder", "Student Name is required")
                .addClass("invalid");

            isValid = false;
        }

        if (email == "") {

            $("#emailError").text("Email is required.");

            $("#Email")
                .val("")
                .attr("placeholder", "Email is required")
                .addClass("invalid");

            isValid = false;
        }

        else if (!emailPattern.test(email)) {

            $("#emailError").text("Enter valid Gmail address.");

            $("#Email")
                .val("")
                .attr("placeholder", "example@gmail.com")
                .addClass("invalid");

            isValid = false;
        }

   
        if (course == "") {

            $("#courseError").text("Please select a course.");

            $("#Course").addClass("invalid");

            isValid = false;
        }


        if (age == "" || parseInt(age) <= 18) {

            $("#ageError").text("Age must be greater than 18.");

            $("#Age").addClass("invalid");

            isValid = false;
        }


        if (gender == undefined) {

            $("#genderError").text("Please select gender.");

            $("input[name='Gender']").addClass("invalid");

            isValid = false;
        }

        if (!isValid)
            return;

        
        // JS Object
        
        var student = {

            StudentName: studentName,

            Email: email,

            Course: course,

            Age: age,

            Gender: gender,

            HostelRequired: hostelRequired

        };


        $.ajax({

            url: "/Student/Save",

            type: "POST",

            data: student,

            success: function (response) {

                alert("Student Added Successfully!");

                $("#successMessage")
                    .html("<b>" + response.message + "</b>")
                    .css("color", "green");

                $("#studentBody").append(

                    "<tr>" +

                    "<td>" + student.StudentName + "</td>" +

                    "<td>" + student.Email + "</td>" +

                    "<td>" + student.Course + "</td>" +

                    "<td>" + student.Age + "</td>" +

                    "<td>" + student.Gender + "</td>" +

                    "<td>" +

                    (student.HostelRequired ? "Yes" : "No") +

                    "</td>" +

                    "</tr>"

                );

                totalStudents++;

                $("#totalStudents").text(totalStudents);

                clearForm();

            },

            error: function () {

                alert("Something went wrong.");

            }

        });

    });
    

    $("#btnClear").click(function () {

        clearForm();

        $("#successMessage").text("");

    });

    $("#StudentName").keyup(function () {

        $("#typingMessage").text("Typing : Student Name");

        $("#nameError").text("");

        $(this)
            .removeClass("invalid")
            .attr("placeholder", "Enter student name");

    });


    $("#Email").keyup(function () {

        $("#emailError").text("");

        $(this)
            .removeClass("invalid")
            .attr("placeholder", "Enter email");

    });

    $("#Email").blur(function () {

        var email = $(this).val().trim();

        var emailPattern = /^[a-zA-Z0-9._%+-]+@gmail\.com$/;

        $("#emailError").text("");

        $(this).removeClass("invalid");

        if (email != "" && !emailPattern.test(email)) {

            $("#emailError").text("Enter valid Gmail address.");

            $(this).addClass("invalid");

        }

    });


    $("#Course").change(function () {

        $("#courseMessage").text("Selected Course : " + $(this).val());

        $("#courseError").text("");

        $(this).removeClass("invalid");

    });

    // cheat sheet method implementation - .empty() method
    $("#btnDeleteTable").click(function () {

        $("#studentBody").empty();

        totalStudents = 0;

        $("#totalStudents").text(totalStudents);

        $("#successMessage")
            .text("Student list cleared successfully.")
            .css("color", "red");

    });

});   



// Clear Form

function clearForm() {

    $("#StudentName").val("");

    $("#Email").val("");

    $("#Course").val("");

    $("#Age").val("");

    $("input[name='Gender']").prop("checked", false);

    $("#HostelRequired").prop("checked", false);

    $(".error-message").text("");

    $(".form-control").removeClass("invalid");

    $("input[name='Gender']").removeClass("invalid");

    $("#typingMessage").text("");

    $("#courseMessage").text("");

    $("#StudentName").attr("placeholder", "Enter student name");

    $("#Email").attr("placeholder", "Enter email");

}