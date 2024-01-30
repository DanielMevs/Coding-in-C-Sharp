class UserInputValidator
{
    public  string Validate(string input, int roll)
    {
        int guess;
        bool success = int.TryParse(input, out guess);
        if (success && guess == roll) { 
            return "You win";
        }
        else if(success && guess != roll) {
            return "Wrong number";
        }
        else { return "Incorrect input"; }

    }
}
