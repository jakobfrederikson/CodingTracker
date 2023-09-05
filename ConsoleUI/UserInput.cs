/*
 * 
 * Handle user input via the console.
 * 
 */

using CodingTracker.DataValidation;

namespace CodingTracker.ConsoleUI;

internal class UserInput
{
    internal string GetMenuResponse(int answerRange, string message)
    {
        string response = string.Empty;

        if (Validation.IsResponseInteger(response))
        {
            return response;
        }
        else 
        { 
            // I don't like how I'm doing this
            // Let's do this instead:
            // 1. UserInput gets the users input from a menu
            // 2. Validation checks if a response is an integer and inbetween the answers range
            // 3. Validation will take care of telling the user "Please try again"
            // -- now, this class will say the message it needs to and get a response via "Validation.ValidateMenuResponse(range, response);"
            // and we return response;
            // I think i like this better, have fun future jakob
        }

                
        return string.Empty;
    }
}
