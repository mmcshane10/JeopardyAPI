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
            );
        }
    }

}