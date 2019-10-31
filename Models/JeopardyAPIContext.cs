using Microsoft.EntityFrameworkCore;

namespace JeopardyAPI.Models
{
    public class JeopardyAPIContext : DbContext
    {
        public JeopardyAPIContext(DbContextOptions<JeopardyAPIContext> options)
            : base(options)
        {
        }

        public DbSet<FillInTheBlank> FillInTheBlank { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FillInTheBlank>()
                .HasData(
                    new FillInTheBlank { FillInTheBlankId = 1, Category = "JavaScript", Difficulty = "Easy", Prompt = "+, -, *, /, and % are called _________. They are special characters that indicate an action to be performed.", Answer = "operators" },

                    new FillInTheBlank { FillInTheBlankId = 2, Category = "JavaScript", Difficulty = "Easy", Prompt = "9 % 2; returns the remainder of 9 divided by 2. % is called _________.", Answer = "modulo" },

                    new FillInTheBlank { FillInTheBlankId = 3, Category = "JavaScript", Difficulty = "Easy", Prompt = "Some methods take one or more _________ that provide the method with additional information to help it perform its action.", Answer = "arguments" },

                    new FillInTheBlank { FillInTheBlankId = 4, Category = "JavaScript", Difficulty = "Easy", Prompt = "The _________ is your browser's interpretation of the HTML it reads.", Answer = "DOM" },

                    new FillInTheBlank { FillInTheBlankId = 5, Category = "JavaScript", Difficulty = "Easy", Prompt = "The variable scope of _________ which are declared outside of a function, allowing all functions the ability to access and use them.", Answer = "global variables" },

                    new FillInTheBlank { FillInTheBlankId = 6, Category = "JavaScript", Difficulty = "Easy", Prompt = "Variables with _________ only exist and are available during the execution of the function in which they are defined.", Answer = "local scope" },

                    new FillInTheBlank { FillInTheBlankId = 7, Category = "JavaScript", Difficulty = "Easy", Prompt = "_________ logic handles calculations and manipulation of data 'behind the scenes'.", Answer = "business" },

                    new FillInTheBlank { FillInTheBlankId = 8, Category = "JavaScript", Difficulty = "Easy", Prompt = "_________ logic handles interacting with the user, including gathering user input, updating and displaying information on the page, etc..", Answer = "user interface" },

                    new FillInTheBlank { FillInTheBlankId = 9, Category = "JavaScript", Difficulty = "Easy", Prompt = "Determining the flow of your code based on certain conditions is called _________. (ie: If something is true, do one thing. If this same thing is false, do a different thing.)", Answer = "branching" },

                    new FillInTheBlank { FillInTheBlankId = 10, Category = "JavaScript", Difficulty = "Easy", Prompt = "A boolean, integer, and string are a few of types of _________ data types", Answer = "primitive" },

                    new FillInTheBlank { FillInTheBlankId = 11, Category = "JavaScript", Difficulty = "Easy", Prompt = "Empty strings, the number 0, the number NaN, undefined, null, and false itself are _________", Answer = "falsey" },

                    new FillInTheBlank { FillInTheBlankId = 12, Category = "JavaScript", Difficulty = "Easy", Prompt = "_________ allows JavaScript to repeat an action until some condition is met.", Answer = "Looping" },

                    new FillInTheBlank { FillInTheBlankId = 13, Category = "JavaScript", Difficulty = "Easy", Prompt = "DRY stands for _________ and refers to code that is well-refactored and efficient, instead of redundant. DRY code has many benefits, including being easier for other developers to pick up, being easier to maintain and update, and easier to debug when issues occur.", Answer = "don't repeat yourself" },

                    new FillInTheBlank { FillInTheBlankId = 14, Category = "JavaScript", Difficulty = "Medium", Prompt = "_________ creates a new array with the results of calling the provided function on every element of the original array.", Answer = "array mapping" },

                    new FillInTheBlank { FillInTheBlankId = 15, Category = "JavaScript", Difficulty = "Easy", Prompt = "An _________ initializes a variable with the denoted value.", Answer = "initialization parameter" },

                    new FillInTheBlank { FillInTheBlankId = 16, Category = "JavaScript", Difficulty = "Easy", Prompt = "In Behavior-Driven Development, _________ are examples of small, isolated behaviors a program should demonstrate, including input and output examples.", Answer = "specs" },

                    new FillInTheBlank { FillInTheBlankId = 17, Category = "JavaScript", Difficulty = "Easy", Prompt = "What does BDD stand for?", Answer = "Behavior Driven Development" },

                    new FillInTheBlank { FillInTheBlankId = 18, Category = "JavaScript", Difficulty = "Easy", Prompt = "What does TDD stand for?", Answer = "Test Driven Development" },

                    new FillInTheBlank { FillInTheBlankId = 19, Category = "JavaScript", Difficulty = "Medium", Prompt = "A _________ is a function that can be invoked using the new keyword to create new objects.", Answer = "constructor" },

                    new FillInTheBlank { FillInTheBlankId = 20, Category = "JavaScript", Difficulty = "Medium", Prompt = "JavaScript employs _________, which are just objects from which other objects inherit methods.", Answer = "prototypes" },

                    new FillInTheBlank { FillInTheBlankId = 21, Category = "JavaScript", Difficulty = "Easy", Prompt = "NPM is used to add open-source JavaScript libraries to your application. What does it stand for?", Answer = "node package manager" },

                    new FillInTheBlank { FillInTheBlankId = 22, Category = "JavaScript", Difficulty = "Medium", Prompt = "In webpack, the Main.js file is an example of this, the 'door leading into our application'.", Answer = "entry point" },

                    new FillInTheBlank { FillInTheBlankId = 23, Category = "JavaScript", Difficulty = "Easy", Prompt = "The BDD workflow is known as red, green, _________", Answer = "refactor" },

                    new FillInTheBlank { FillInTheBlankId = 24, Category = "JavaScript", Difficulty = "Easy", Prompt = "We should use _________ when we want to declare a variable that does not change.", Answer = "const" },

                    new FillInTheBlank { FillInTheBlankId = 25, Category = "JavaScript", Difficulty = "Easy", Prompt = "You create this file so that it isn't trackable by Github. ", Answer = "gitignore" },

                    new FillInTheBlank { FillInTheBlankId = 26, Category = "JavaScript", Difficulty = "Easy", Prompt = "What is the official name for Javascript?", Answer = "ECMAscript" },

                    new FillInTheBlank { FillInTheBlankId = 27, Category = "JavaScript", Difficulty = "Medium", Prompt = "_________ inheritance simply means that one class inherits from another class.", Answer = "classical" },

                    new FillInTheBlank { FillInTheBlankId = 28, Category = "JavaScript", Difficulty = "Medium", Prompt = "With _________ inheritance, objects inherit from other objects.", Answer = "prototypal" },

                    new FillInTheBlank { FillInTheBlankId = 29, Category = "JavaScript", Difficulty = "Medium", Prompt = "_________ is a term developers use for added functionality in a programming language that makes it easier to write and read.", Answer = "syntactic sugar" },

                    new FillInTheBlank { FillInTheBlankId = 30, Category = "JavaScript", Difficulty = "Easy", Prompt = "We should use _________ when we want to declare a variable that changes.", Answer = "let" },

                    new FillInTheBlank { FillInTheBlankId = 31, Category = "JavaScript", Difficulty = "Easy", Prompt = "_________ scoping means a variable can only be called in the block where it’s defined.", Answer = "lexical" },

                    new FillInTheBlank { FillInTheBlankId = 32, Category = "JavaScript", Difficulty = "Medium", Prompt = "set_________() calls a piece of code multiple times, with a specific amount of time between each call.", Answer = "interval" },

                    new FillInTheBlank { FillInTheBlankId = 33, Category = "JavaScript", Difficulty = "Medium", Prompt = "set_________() calls a piece of code once, after a set duration of time.", Answer = "timeout" },

                    new FillInTheBlank { FillInTheBlankId = 34, Category = "JavaScript", Difficulty = "Easy", Prompt = "An _________ is a special code that gives us permission to request API data, and ties any requests we make in our application to an account we own", Answer = "api key" },

                    new FillInTheBlank { FillInTheBlankId = 35, Category = "JavaScript", Difficulty = "Medium", Prompt = "A _________ object is mostly a collection of nested key-value pairs, and is commonly used for transmitting data in web applications.", Answer = "json" },

                    new FillInTheBlank { FillInTheBlankId = 36, Category = "C#", Difficulty = "Easy", Prompt = "_________ is a strictly-typed compiled language developed by Microsoft.", Answer = "c#" },

                    new FillInTheBlank { FillInTheBlankId = 37, Category = "C#", Difficulty = "Medium", Prompt = ".NET _________ is an open-source, light-weight version of the full .NET Framework.", Answer = "core" },

                    new FillInTheBlank { FillInTheBlankId = 38, Category = "C#", Difficulty = "Medium", Prompt = "A _________ is used to group interrelated and independent classes together. It is a keyword used to ID sets of classes. ", Answer = "namespace" },

                    new FillInTheBlank { FillInTheBlankId = 39, Category = "C#", Difficulty = "Medium", Prompt = "The keyword '_________' is called a directive. It tells C# that the code in this file will be implementing code that isn't contained in this file or in this file's namespace.", Answer = "using" },

                    new FillInTheBlank { FillInTheBlankId = 40, Category = "C#", Difficulty = "Medium", Prompt = "_________ methods are methods that are called on the class itself, rather than an instance.", Answer = "static" },

                    new FillInTheBlank { FillInTheBlankId = 41, Category = "General", Difficulty = "Easy", Prompt = "_________ is the process of restructuring existing code without changing its external behavior and with the purpose of improving its readability and reducing its complexity.", Answer = "refactoring" },

                    new FillInTheBlank { FillInTheBlankId = 42, Category = "C#", Difficulty = "Medium", Prompt = "_________ is the act of turning one variable type into another variable type", Answer = "casting" },

                    new FillInTheBlank { FillInTheBlankId = 43, Category = "Testing", Difficulty = "Hard", Prompt = "A _________ method is used to reset data between each test, ensuring one's test results aren't affected by earlier results.", Answer = "teardown" },

                    new FillInTheBlank { FillInTheBlankId = 44, Category = "General", Difficulty = "Hard", Prompt = "_________ refers to the act of coding a program to handle exceptions in a manner that doesn't lead to the application crashing.", Answer = "exception handling" },

                    new FillInTheBlank { FillInTheBlankId = 45, Category = "C#", Difficulty = "Hard", Prompt = "An _________ is a blueprint of things (such as declarations, properties and methods) that must be included within any class that utiliizes this.", Answer = "interface" }

                    new FillInTheBlank { FillInTheBlankId = 46, Category = "C#", Difficulty = "Hard", Prompt = "An _________ class is never intended to be instantiated directly and are typically used to define a base class in the class heirarchy.", Answer = "abstract" },

                    new FillInTheBlank { FillInTheBlankId = 47, Category = "C#", Difficulty = "Hard", Prompt = "When we define two or more constructors in a class, constructors that differ from the original are called _________ constructors.", Answer = "overloaded" },

                    new FillInTheBlank { FillInTheBlankId = 48, Category = "General", Difficulty = "Medium", Prompt = "A _________ is usually a web browser, like Chrome or Firefox, but can be anything that facilitates interaction with the web.", Answer = "client" },

                    new FillInTheBlank { FillInTheBlankId = 49, Category = "General", Difficulty = "Medium", Prompt = "A _________ is a machine that contains resources (like web pages and files) that can be requested by a client.", Answer = "server" },

                    new FillInTheBlank { FillInTheBlankId = 50, Category = "General", Difficulty = "Medium", Prompt = "When a server receives a request from a client, it contructs and sends a _________ containing the resources necessary for that specific page.", Answer = "response" }

                    
            );
        }
    }

}