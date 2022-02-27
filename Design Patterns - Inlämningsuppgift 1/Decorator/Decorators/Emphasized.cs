namespace Design_Patterns_Assignment
{
    public class Emphasized : TextDecorator, IEmphasized
    {
        public Emphasized(IText text) : base(text)
        {
            string start = "<em>";
            string end = "</em>";
            StartTag = start;
            EndTag = end;
        }
    }
}
