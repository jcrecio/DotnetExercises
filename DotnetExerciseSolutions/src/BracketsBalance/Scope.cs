namespace DotnetExerciseSolutions.src.BracketsBalance
{
    public abstract class Scope
    {
        public abstract char Opener { get; }
        public abstract char Closer { get; }
        public int Counter { get; set; }

        public override bool Equals(object obj)
        {
            var scope = obj as Scope;
            if (scope == null) return false;

            return Opener == scope.Opener;
        }
    }
}
