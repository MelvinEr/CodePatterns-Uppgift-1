namespace Design_Patterns_Assignment
{
    public class Inserted : TextDecorator, IInserted
    {
        public Inserted(IText text) : base(text)
        {
            string start = "<ins>";
            string end = "</ins>";
            StartTag = start;
            EndTag = end;
        }
    }
}
