//A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

//S is empty;
//S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
//S has the form "VW" where V and W are properly nested strings.
//For example, the string "{[()()]}" is properly nested but "([)()]" is not.

//Write a function:

//int solution(char* S);

//that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

//For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range[0..200, 000];
//string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".

namespace DotnetExerciseSolutions.src.BracketsBalance
{
    using System.Collections;
    using System.Linq;

    public static class BracketsBalance
    {
        private static char[] openBrackets = { '(', '[', '{' };
        private static char[] closeBrackets = { ')', ']', '}' };

        public static bool IsBalanced(string input)
        {
            Stack scopeStack = new Stack();
            Scope currentScope = default(Scope);

            foreach (var character in input)
            {
                if (IsOpenBracket(character))
                {
                    if (!CharacterIsInSameScope(currentScope, character))
                    {
                        currentScope = character.GetScope();
                        scopeStack.Push(currentScope);
                    }

                    currentScope.Counter++;
                    continue;
                }

                if (IsCloseBracket(character))
                {
                    if (FindWrongBracketsCombination(currentScope, character)) return false;

                    currentScope.Counter--;
                    if (currentScope.Counter == 0)
                    {
                        if (scopeStack.Count > 0)
                        {
                            scopeStack.Pop();
                        }

                        currentScope = scopeStack.Count > 0
                                ? scopeStack.Peek() as Scope
                                : null;
                    }
                }
            }

            return scopeStack.Count == 0;
        }

        private static bool FindWrongBracketsCombination(Scope currentScope, char character)
        {
            return !CharacterIsInSameScope(currentScope, character) || ExpresionIsClosedInAdvance(currentScope);
        }

        private static bool ExpresionIsClosedInAdvance(Scope currentScope)
        {
            return currentScope.Counter <= 0;
        }

        private static bool CharacterIsInSameScope(Scope currentScope, char character)
        {
            return currentScope != null && currentScope.Equals(character.GetScope());
        }

        private static bool IsCloseBracket(char character)
        {
            return closeBrackets.Contains(character);
        }

        private static bool IsOpenBracket(char character)
        {
            return openBrackets.Contains(character);
        }
    }
}
