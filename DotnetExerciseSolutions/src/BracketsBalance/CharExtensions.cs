namespace DotnetExerciseSolutions.src.BracketsBalance
{
    using ScoreImpl;

    public static class CharExtensions
    {
        public static Scope GetScope(this char character)
        {
            switch (character)
            {
                case '(':
                case ')':
                    return new ParenthesisScope();

                case '[':
                case ']':
                    return new BracketsScope();

                case '{':
                case '}':
                    return new CurlyBracketScope();

                default:
                    return default(Scope);
            }
        }
    }
}
