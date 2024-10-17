namespace CleanCode.Exercises
{
    public class IsValidNameRefactor
    {
        //you may rename the parameters of this method,
        //but do not change their order or type
        public static (bool, string) IsValidName_Refactored(string name)
        {
            if (IsTooShort(name))
            {
                return (false, "The name is too short.");
            }
            if (IsTooLong(name))
            {
                return (false, "The name is too long.");
            }
            if (DoesStartWithLowercase(name))
            {
                return (false, "The name starts with a lowercase letter.");
            }
            if (DoesContainNonLetterCharacter(name))
            {
                return (false, "The name contains non-letter characters.");
            }
            if (AnyExceptFirstAreUpperCase(name))
            {
                return (false, "The name contains uppercase letters after the first character.");
            }
            return (true, "The name is valid.");

        }

        //feel free to add any helper methods here
        private static bool IsTooLong(string name)
        {
            const int MaxValidLength = 25;
            return name.Length > MaxValidLength;
        }
        private static bool IsTooShort(string name)
        {
            const int MinValidLength = 3;
            return name.Length < MinValidLength;
        }

        private static bool DoesStartWithLowercase(string name)
        {
            return name[0] == char.ToLower(name[0]);
        }

        private static bool DoesContainNonLetterCharacter(
            string name)
        {
            return name.Any(character => !char.IsLetter(character));
        }
        private static bool AnyExceptFirstAreUpperCase(
            string name)
        {
            return name.Skip(1).Any(
                character => char.IsUpper(character));
        }

        //do not modify this method        
        public static (bool, string) IsValidName(string name)
        {
            if (name.Length < 3)
            {
                return (false, "The name is too short.");
            }
            if (IsLong(name))
            {
                return (false, "The name is too long.");
            }
            if (name[0] == char.ToLower(name[0]))
            {
                return (false, "The name starts with a lowercase letter.");
            }
            foreach (var c in name)
            {
                if (!char.IsLetter(c))
                {
                    return (false, "The name contains non-letter characters.");
                }
            }
            for (int i = 1; i < name.Length; i++)
            {
                char c = name[i];
                if (c == char.ToUpper(c))
                {
                    return (false, "The name contains uppercase letters after the first character.");
                }
            }
            return (true, "The name is valid.");
        }

        private static bool IsLong(string name)
        {
            return name.Length > 25;
        }
    }
}
