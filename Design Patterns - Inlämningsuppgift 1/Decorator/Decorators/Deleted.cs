namespace Design_Patterns_Assignment
{
    public class Deleted : TextDecorator, IDeleted
    {
        public Deleted(IText text) : base(text)
        {
            string start = "<del>";
            string end = "</del>";
            StartTag = start;
            EndTag = end;
        }
    }
}
