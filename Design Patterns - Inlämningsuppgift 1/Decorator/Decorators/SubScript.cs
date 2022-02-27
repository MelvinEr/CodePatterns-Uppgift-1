namespace Design_Patterns_Assignment
{
    public class SubScript : TextDecorator, ISubScript
    {
        public SubScript(IText text) : base(text)
        {
            string start = "<sub>";
            string end = "</sub>";
            StartTag = start;
            EndTag = end;
        }
    }
}
