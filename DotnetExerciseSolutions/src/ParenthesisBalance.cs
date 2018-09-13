// A string S consisting of N characters is called properly nested if:
//	• S is empty;
//	• S has the form "(U)" where U is a properly nested string;
//	• S has the form "VW" where V and W are properly nested strings.
// For example, string "(()(())())" is properly nested but string "())" isn't.
// Write a function:

//    class Solution { public bool solution(string S); }
// that, given a string S consisting of N characters, returns true if string S is properly nested and false otherwise.
// For example, given S = "(()(())())", the function should return true and given S = "())", the function should return false, as explained above.
// Write an efficientalgorithm for the following assumptions:
// N is an integer within the range[0..1, 000, 000];

namespace DotnetExerciseSolutions
{
    public class ParenthesisBalance
    {
        public static bool IsBalanced(string inputExpression)
        {
            int balance = 0;

            foreach (var character in inputExpression)
            {
                if (character == '(')
                {
                    balance += 1;
                }

                else if (character == ')')
                {
                    if (balance == 0) return false;
                    balance -= 1;
                }
            }

            return balance == 0;
        }
    }
}