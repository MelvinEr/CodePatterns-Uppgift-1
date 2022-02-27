namespace Design_Patterns_Assignment
{
    public class Smaller : TextDecorator, ISmaller
    {
        public Smaller(IText text) : base(text)
        {
            string start = "<small>";
            string end = "</small>";
            StartTag = start;
            EndTag = end;
        }
    }
}
