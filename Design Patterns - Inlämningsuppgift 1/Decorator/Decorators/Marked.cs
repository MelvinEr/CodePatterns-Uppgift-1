namespace Design_Patterns_Assignment
{
    public class Marked : TextDecorator, IMarked
    {
        public Marked(IText text) : base(text)
        {
            string start = "<mark>";
            string end = "</mark>";
            StartTag = start;
            EndTag = end;
        }
    }
}
