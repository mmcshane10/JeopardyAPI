﻿// <auto-generated />
using JeopardyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JeopardyAPI.Migrations
{
    [DbContext(typeof(JeopardyAPIContext))]
    [Migration("20191106170908_UpdateDbCategories")]
    partial class UpdateDbCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JeopardyAPI.Models.FillInTheBlank", b =>
                {
                    b.Property<int>("FillInTheBlankId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Category");

                    b.Property<string>("Difficulty");

                    b.Property<string>("Prompt");

                    b.HasKey("FillInTheBlankId");

                    b.ToTable("FillInTheBlank");

                    b.HasData(
                        new
                        {
                            FillInTheBlankId = 1,
                            Answer = "operators",
                            Category = "General",
                            Difficulty = "Easy",
                            Prompt = "+, -, *, /, and % are called _________. They are special characters that indicate an action to be performed."
                        },
                        new
                        {
                            FillInTheBlankId = 2,
                            Answer = "modulo",
                            Category = "General",
                            Difficulty = "Easy",
                            Prompt = "9 % 2; returns the remainder of 9 divided by 2. % is called _________."
                        },
                        new
                        {
                            FillInTheBlankId = 13,
                            Answer = "don't repeat yourself",
                            Category = "General",
                            Difficulty = "Easy",
                            Prompt = "DRY stands for _________ and refers to code that is well-refactored and efficient, instead of redundant. DRY code has many benefits, including being easier to maintain and update, and easier to debug when issues occur."
                        },
                        new
                        {
                            FillInTheBlankId = 4,
                            Answer = "DOM",
                            Category = "General",
                            Difficulty = "Easy",
                            Prompt = "The _________ is your browser's interpretation of the HTML it reads."
                        },
                        new
                        {
                            FillInTheBlankId = 9,
                            Answer = "branching",
                            Category = "General",
                            Difficulty = "Easy",
                            Prompt = "Determining the flow of your code based on certain conditions is called _________. (ie: If something is true, do one thing. If this same thing is false, do a different thing.)"
                        },
                        new
                        {
                            FillInTheBlankId = 41,
                            Answer = "refactoring",
                            Category = "General",
                            Difficulty = "Medium",
                            Prompt = "_________ is the process of restructuring existing code without changing its external behavior and with the purpose of improving its readability and reducing its complexity."
                        },
                        new
                        {
                            FillInTheBlankId = 49,
                            Answer = "server",
                            Category = "General",
                            Difficulty = "Medium",
                            Prompt = "A _________ is a machine that contains resources (like web pages and files) that can be requested by a client."
                        },
                        new
                        {
                            FillInTheBlankId = 50,
                            Answer = "response",
                            Category = "General",
                            Difficulty = "Medium",
                            Prompt = "When a server receives a request from a client, it contructs and sends a _________ containing the resources necessary for that specific page."
                        },
                        new
                        {
                            FillInTheBlankId = 48,
                            Answer = "client",
                            Category = "General",
                            Difficulty = "Medium",
                            Prompt = "A _________ is usually a web browser, like Chrome or Firefox, but can be anything that facilitates interaction with the web."
                        },
                        new
                        {
                            FillInTheBlankId = 53,
                            Answer = "abstraction",
                            Category = "General",
                            Difficulty = "Hard",
                            Prompt = "In object-oriented programming, _________ is the process of hiding and encapsulating complex code so that it's easier to use."
                        },
                        new
                        {
                            FillInTheBlankId = 44,
                            Answer = "exception handling",
                            Category = "General",
                            Difficulty = "Hard",
                            Prompt = "_________ refers to the act of coding a program to handle exceptions in a manner that doesn't lead to the application crashing."
                        },
                        new
                        {
                            FillInTheBlankId = 51,
                            Answer = "encapsulation",
                            Category = "General",
                            Difficulty = "Hard",
                            Prompt = "Allowing a class to have total control over its own fields, preventing other classes from accessing and altering fields, and making code more maintainable are all benefits of _________."
                        },
                        new
                        {
                            FillInTheBlankId = 3,
                            Answer = "arguments",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "Some methods take one or more _________ that provide the method with additional information to help it perform its action."
                        },
                        new
                        {
                            FillInTheBlankId = 5,
                            Answer = "global",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "Variables declared outside of functions have _________ scope which means that all code and functions can access them."
                        },
                        new
                        {
                            FillInTheBlankId = 6,
                            Answer = "local",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "Variables with _________ scope only exist and are available during the execution of the function in which they are defined."
                        },
                        new
                        {
                            FillInTheBlankId = 7,
                            Answer = "business",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "_________ logic handles calculations and manipulation of data 'behind the scenes'."
                        },
                        new
                        {
                            FillInTheBlankId = 8,
                            Answer = "user interface",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "_________ logic handles interacting with the user, including gathering user input, updating and displaying information on the page, etc.."
                        },
                        new
                        {
                            FillInTheBlankId = 10,
                            Answer = "primitive",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "A boolean, integer, and string are a few of types of _________ data types"
                        },
                        new
                        {
                            FillInTheBlankId = 11,
                            Answer = "falsey",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "Empty strings, the number 0, NaN, undefined, null, and false itself are all types of _________ values"
                        },
                        new
                        {
                            FillInTheBlankId = 12,
                            Answer = "Looping",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "_________ allows JavaScript to repeat an action until some condition is met."
                        },
                        new
                        {
                            FillInTheBlankId = 15,
                            Answer = "",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = ""
                        },
                        new
                        {
                            FillInTheBlankId = 21,
                            Answer = "node package manager",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "NPM is used to add open-source JavaScript libraries to your application. What does it stand for?"
                        },
                        new
                        {
                            FillInTheBlankId = 24,
                            Answer = "const",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "We should use _________ when we want to declare a variable that does not change."
                        },
                        new
                        {
                            FillInTheBlankId = 26,
                            Answer = "ECMAscript",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "What is the official name for Javascript?"
                        },
                        new
                        {
                            FillInTheBlankId = 30,
                            Answer = "let",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "We should use _________ when we want to declare a variable that changes."
                        },
                        new
                        {
                            FillInTheBlankId = 31,
                            Answer = "lexical",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "_________ scoping means a variable can only be called in the block where it’s defined."
                        },
                        new
                        {
                            FillInTheBlankId = 34,
                            Answer = "api key",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "An _________ is a special code that gives us permission to request API data, and ties any requests we make in our application to an account we own"
                        },
                        new
                        {
                            FillInTheBlankId = 35,
                            Answer = "json",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "A _________ object is mostly a collection of nested key-value pairs, and is commonly used for transmitting data in web applications."
                        },
                        new
                        {
                            FillInTheBlankId = 32,
                            Answer = "interval",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "set_________() calls a piece of code multiple times, with a specific amount of time between each call."
                        },
                        new
                        {
                            FillInTheBlankId = 33,
                            Answer = "timeout",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "set_________() calls a piece of code once, after a set duration of time."
                        },
                        new
                        {
                            FillInTheBlankId = 27,
                            Answer = "classical",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "_________ inheritance simply means that one class inherits from another class."
                        },
                        new
                        {
                            FillInTheBlankId = 28,
                            Answer = "prototypal",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "With _________ inheritance, objects inherit from other objects."
                        },
                        new
                        {
                            FillInTheBlankId = 22,
                            Answer = "entry point",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "In webpack, the Main.js file is an example of this, the 'door leading into our application'."
                        },
                        new
                        {
                            FillInTheBlankId = 14,
                            Answer = "mapping",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "Array _________ creates a new array with the results of calling the provided function on every element of the original array."
                        },
                        new
                        {
                            FillInTheBlankId = 19,
                            Answer = "constructor",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "A _________ is a function that can be invoked using the 'new' keyword to create new objects."
                        },
                        new
                        {
                            FillInTheBlankId = 29,
                            Answer = "syntactic sugar",
                            Category = "JavaScript",
                            Difficulty = "Hard",
                            Prompt = "_________ is a term developers use for added functionality in a programming language that makes it easier to write and read."
                        },
                        new
                        {
                            FillInTheBlankId = 20,
                            Answer = "prototypes",
                            Category = "JavaScript",
                            Difficulty = "Hard",
                            Prompt = "JavaScript employs _________, which are just objects from which other objects inherit methods."
                        },
                        new
                        {
                            FillInTheBlankId = 16,
                            Answer = "specs",
                            Category = "Testing",
                            Difficulty = "Easy",
                            Prompt = "In Behavior-Driven Development, _________ are examples of small, isolated behaviors a program should demonstrate, including input and output examples."
                        },
                        new
                        {
                            FillInTheBlankId = 17,
                            Answer = "Behavior Driven Development",
                            Category = "Testing",
                            Difficulty = "Easy",
                            Prompt = "What does BDD stand for?"
                        },
                        new
                        {
                            FillInTheBlankId = 18,
                            Answer = "Test Driven Development",
                            Category = "Testing",
                            Difficulty = "Easy",
                            Prompt = "What does TDD stand for?"
                        },
                        new
                        {
                            FillInTheBlankId = 23,
                            Answer = "refactor",
                            Category = "Testing",
                            Difficulty = "Easy",
                            Prompt = "The BDD workflow is known as red, green, _________"
                        },
                        new
                        {
                            FillInTheBlankId = 56,
                            Answer = "try/catch",
                            Category = "Testing",
                            Difficulty = "Medium",
                            Prompt = "We can manually add code to tell our application how to handle exceptions by using _________/_________ blocks."
                        },
                        new
                        {
                            FillInTheBlankId = 43,
                            Answer = "teardown",
                            Category = "Testing",
                            Difficulty = "Medium",
                            Prompt = "A _________ method is used to reset data between each test, ensuring one's test results aren't affected by earlier results."
                        },
                        new
                        {
                            FillInTheBlankId = 54,
                            Answer = "edge cases",
                            Category = "Testing",
                            Difficulty = "Hard",
                            Prompt = "Good testing should cover not just expected inputs but also _________, which are extreme or unusual parameters passed into a method."
                        },
                        new
                        {
                            FillInTheBlankId = 36,
                            Answer = "strictly",
                            Category = "C#",
                            Difficulty = "Easy",
                            Prompt = "C# is a _________-typed compiled language developed by Microsoft."
                        },
                        new
                        {
                            FillInTheBlankId = 55,
                            Answer = "csproj",
                            Category = "C#",
                            Difficulty = "Easy",
                            Prompt = "Anytime we update a ._________ file, we need to run dotnet restore to download and install updated packages."
                        },
                        new
                        {
                            FillInTheBlankId = 58,
                            Answer = "model",
                            Category = "C#",
                            Difficulty = "Easy",
                            Prompt = "In the MVC framework, a _________ represents the application's data."
                        },
                        new
                        {
                            FillInTheBlankId = 59,
                            Answer = "view",
                            Category = "C#",
                            Difficulty = "Easy",
                            Prompt = "In the MVC framework, a _________ represents the user interface of the application."
                        },
                        new
                        {
                            FillInTheBlankId = 60,
                            Answer = "controller",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "In the MVC framework, a _________ acts as the bridge between the data and the user interface."
                        },
                        new
                        {
                            FillInTheBlankId = 61,
                            Answer = "razor",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "The _________ templating engine allows us to add C# logic to our views using models we created."
                        },
                        new
                        {
                            FillInTheBlankId = 37,
                            Answer = "core",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = ".NET _________ is an open-source, light-weight version of the full .NET Framework."
                        },
                        new
                        {
                            FillInTheBlankId = 52,
                            Answer = "property",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "A _________ is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field."
                        },
                        new
                        {
                            FillInTheBlankId = 38,
                            Answer = "namespace",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "A _________ is used to group interrelated and independent classes together. It is a keyword used to ID sets of classes. "
                        },
                        new
                        {
                            FillInTheBlankId = 39,
                            Answer = "using",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "The keyword '_________' is called a directive. It tells C# that the code in this file will be implementing code that isn't contained in this file or in this file's namespace."
                        },
                        new
                        {
                            FillInTheBlankId = 40,
                            Answer = "static",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "_________ methods are methods that are called on the class itself, rather than an instance."
                        },
                        new
                        {
                            FillInTheBlankId = 42,
                            Answer = "casting",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "_________ is the act of turning one variable type into another variable type"
                        },
                        new
                        {
                            FillInTheBlankId = 45,
                            Answer = "interface",
                            Category = "C#",
                            Difficulty = "Hard",
                            Prompt = "An _________ is a blueprint of things (such as declarations, properties and methods) that must be included within any class that utiliizes this."
                        },
                        new
                        {
                            FillInTheBlankId = 46,
                            Answer = "abstract",
                            Category = "C#",
                            Difficulty = "Hard",
                            Prompt = "An _________ class is never intended to be instantiated directly and are typically used to define a base class in the class heirarchy."
                        },
                        new
                        {
                            FillInTheBlankId = 47,
                            Answer = "overloaded",
                            Category = "C#",
                            Difficulty = "Hard",
                            Prompt = "When we define two or more constructors in a class, constructors that differ from the original are called _________ constructors."
                        },
                        new
                        {
                            FillInTheBlankId = 62,
                            Answer = "version control",
                            Category = "Git",
                            Difficulty = "Easy",
                            Prompt = "Git is a distributed _________ system for tracking changes in source code during software development"
                        },
                        new
                        {
                            FillInTheBlankId = 63,
                            Answer = "commit",
                            Category = "Git",
                            Difficulty = "Easy",
                            Prompt = "A _________ in Git is a way of saving changes to the permanent history of our project."
                        },
                        new
                        {
                            FillInTheBlankId = 25,
                            Answer = "gitignore",
                            Category = "Git",
                            Difficulty = "Easy",
                            Prompt = "You create this file so that it isn't trackable by Github. "
                        },
                        new
                        {
                            FillInTheBlankId = 64,
                            Answer = "git remote -v",
                            Category = "Git",
                            Difficulty = "Medium",
                            Prompt = "This command in Git shows the names and URLs for all of the repositories that the project's Git repository has stored."
                        },
                        new
                        {
                            FillInTheBlankId = 65,
                            Answer = "amend",
                            Category = "Git",
                            Difficulty = "Medium",
                            Prompt = "To modify the most recent commit message or add an additional file to the most recent commit, we can use the command 'git commit --_________."
                        },
                        new
                        {
                            FillInTheBlankId = 66,
                            Answer = "checkout -b",
                            Category = "Git",
                            Difficulty = "Hard",
                            Prompt = "The command 'git _________ <new_branch>' will create and switch to a new branch in Git."
                        });
                });

            modelBuilder.Entity("JeopardyAPI.Models.MultipleChoice", b =>
                {
                    b.Property<int>("MultipleChoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Category");

                    b.Property<string>("Difficulty");

                    b.Property<string>("Prompt");

                    b.Property<string>("Wrong1");

                    b.Property<string>("Wrong2");

                    b.Property<string>("Wrong3");

                    b.HasKey("MultipleChoiceId");

                    b.ToTable("MultipleChoice");

                    b.HasData(
                        new
                        {
                            MultipleChoiceId = 1,
                            Answer = "read-evaluate-print-loop",
                            Category = "C#",
                            Difficulty = "Hard",
                            Prompt = "Dotnet script is a REPL tool. What does REPL stand for?",
                            Wrong1 = "refactor-exchange-print-loop",
                            Wrong2 = "refactor-evaluate-print-locate",
                            Wrong3 = "read-exchange-print-locate"
                        },
                        new
                        {
                            MultipleChoiceId = 2,
                            Answer = "Asynchronous JavaScript And XML",
                            Category = "General",
                            Difficulty = "Hard",
                            Prompt = "When retrieving API data, we use something called AJAX to make our web requests. What does AJAX stand for?",
                            Wrong1 = "Asynchronous JSON And XML",
                            Wrong2 = "Application JSON And XML",
                            Wrong3 = "Application JavaScript And XML"
                        },
                        new
                        {
                            MultipleChoiceId = 3,
                            Answer = "Single-threaded and non-blocking",
                            Category = "JavaScript",
                            Difficulty = "Hard",
                            Prompt = "The JavaScript language is considered:",
                            Wrong1 = "Single-threaded and blocking",
                            Wrong2 = "Multi-threaded and non-blocking",
                            Wrong3 = "Multi-threaded and blocking"
                        },
                        new
                        {
                            MultipleChoiceId = 4,
                            Answer = "Completed",
                            Category = "JavaScript",
                            Difficulty = "Medium",
                            Prompt = "A promise can have three states. Which one of the following is NOT one of those?",
                            Wrong1 = "Pending",
                            Wrong2 = "Fulfilled",
                            Wrong3 = "Rejected"
                        },
                        new
                        {
                            MultipleChoiceId = 5,
                            Answer = "Associate",
                            Category = "C#",
                            Difficulty = "Medium",
                            Prompt = "To help keep organized, we break down individual tests into three sections. Which one of the following is NOT one of those?",
                            Wrong1 = "Act",
                            Wrong2 = "Assert",
                            Wrong3 = "Arrange"
                        },
                        new
                        {
                            MultipleChoiceId = 6,
                            Answer = "Identify the simplest possible behavior of the program.",
                            Category = "Testing",
                            Difficulty = "Easy",
                            Prompt = "Which of the following is step one of the BDD process when testing code?",
                            Wrong1 = "Check if code can be refactored.",
                            Wrong2 = "Implement the behavior with the least amount of code possible.",
                            Wrong3 = "Write a coded test."
                        },
                        new
                        {
                            MultipleChoiceId = 7,
                            Answer = "Encapsulation",
                            Category = "General",
                            Difficulty = "Medium",
                            Prompt = "The idea of bundling attributes and methods that work on that data within one unit (i.e. a class in JavaScript or C#) is called what?",
                            Wrong1 = "Abstraction",
                            Wrong2 = "Modularization",
                            Wrong3 = "Privatizing"
                        },
                        new
                        {
                            MultipleChoiceId = 8,
                            Answer = "Abstraction",
                            Category = "General",
                            Difficulty = "Medium",
                            Prompt = "One of the key concepts of object-oriented programming languages is this, the act of reducing complexity by hiding unnecessary details from the user.",
                            Wrong1 = "Encapsulation",
                            Wrong2 = "Modularization",
                            Wrong3 = "Obscuration"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
