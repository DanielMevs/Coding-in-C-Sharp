namespace CleanCode.Exercises
{
    public class ChooseBetterPathRefactor
    {
        public static List<int>? ChooseBetterPath_Refactored(
            List<int> primaryPathSectionsLengths,
            List<int> secondaryPathSectionLengths,
            int maxAcceptableSectionLength)
        {
            // Check if all the numbers are positive
            CheckAllSectionLengthsArePositive(primaryPathSectionsLengths);
            CheckAllSectionLengthsArePositive(secondaryPathSectionLengths);

            // Check if all the numbers do not exceed the max
            bool doesPrimaryContainValuesWithinMaximum = IsAcceptable(
                primaryPathSectionsLengths, maxAcceptableSectionLength);
            bool doesSecondaryContainValuesWithinMaximum = IsAcceptable(
                secondaryPathSectionLengths, maxAcceptableSectionLength);

            return GetBetterPath(
                primaryPathSectionsLengths,
                secondaryPathSectionLengths,
                doesPrimaryContainValuesWithinMaximum,
                doesSecondaryContainValuesWithinMaximum);
        }

        public static List<int>? GetBetterPath(
            List<int> primaryPathSectionsLengths, List<int> secondaryPathSectionsLengths,
            bool isPrimaryPathValid, bool isSecondaryPathValid)
        {
            if (!isPrimaryPathValid && !isSecondaryPathValid)
            {
                return null;
            }
            if (isPrimaryPathValid && isSecondaryPathValid)
            {
                return SelectShorter(
                    primaryPathSectionsLengths,
                    secondaryPathSectionsLengths);
            }
            if (isPrimaryPathValid)
            {
                return primaryPathSectionsLengths;
            }
            return secondaryPathSectionsLengths;
        }

        public static List<int> SelectShorter(
            List<int> primaryPathSectionsLengths,
            List<int> secondaryPathSectionsLengths)
        {
            return primaryPathSectionsLengths.Sum() <= secondaryPathSectionsLengths.Sum()
                ? primaryPathSectionsLengths
                : secondaryPathSectionsLengths;
        }

        public static bool IsAcceptable(List<int> numbers, int maximum)
        {
            return numbers.All(number => number <= maximum);
        }

        public static void CheckAllSectionLengthsArePositive(List<int> numbers)
        {
            if (numbers.Any(number => number <= 0))
            {
                throw new ArgumentException("The input collections can't contain negative or zero lengths.");
            }
        }


            //do not modify this method!
            public static List<int>? ChooseBetterPath(
            List<int> lengths1,
            List<int> lengths2,
            int maxLength)
        {
            foreach (var number in lengths1)
            {
                if (number < 0)
                {
                    throw new ArgumentException(
                        "The input collections can't contain negative lengths.");
                }
            }

            foreach (var number in lengths2)
            {
                if (number < 0)
                {
                    throw new ArgumentException(
                        "The input collections can't contain negative lengths.");
                }
            }

            bool isLengths1Ok = true;
            foreach (var number in lengths1)
            {
                if (number > maxLength)
                {
                    isLengths1Ok = false;
                }
            }

            bool isLengths2Ok = true;
            foreach (var number in lengths2)
            {
                if (number > maxLength)
                {
                    isLengths2Ok = false;
                }
            }

            if (!isLengths1Ok && !isLengths2Ok)
            {
                return null;
            }
            else if (isLengths1Ok && isLengths2Ok)
            {
                if (lengths1.Sum() <= lengths2.Sum())
                {
                    return lengths1;
                }
                return lengths2;
            }
            else if (isLengths1Ok)
            {
                return lengths1;
            }
            return lengths2;
        }
    }
}
