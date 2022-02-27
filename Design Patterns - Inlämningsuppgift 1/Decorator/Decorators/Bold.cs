namespace Design_Patterns_Assignment
{
    public class Bold : TextDecorator, IBold
    {
        public Bold(IText text) : base(text)
        {
            string start = "<b>";
            string end = "</b>";
            StartTag = start;
            EndTag = end;
        }
    }
}
