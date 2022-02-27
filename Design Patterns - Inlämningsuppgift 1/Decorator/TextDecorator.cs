namespace Design_Patterns_Assignment
{
    public abstract class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string StartTag;
        public string EndTag;

        public TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetStartTag()
        {
            return StartTag;
        }

        public string GetEndTag()
        {
            return EndTag;
        }
    }
}
