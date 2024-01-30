
class DiceGame
{
    public void playGame()
    {
        GameIntroduction.IntroduceGame();
        var dice_roll_obj = new DiceRoll();
        var dice_roll = dice_roll_obj.Roll;

        var validator = new UserInputValidator();
        var userInput = new UserInput();
        

        int tries = 0;
        while (tries < 3)
        {
            var input = userInput.getUserInput();
            var validate_message = validator.Validate(input, dice_roll);
            Console.WriteLine(validate_message);
            if (validate_message == "You win")
            {
                return;
            }
            else if (validate_message == "Incorrect input")
            {
                continue;
            }
            else
            {
                tries++;
            }

        }

        
        Console.WriteLine("You lose");
        
    }
}
