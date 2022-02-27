namespace Design_Patterns_Assignment
{
    public class Italic : TextDecorator, IItalic
    {
        public Italic(IText text) : base(text)
        {
            string start = "<i>";
            string end = "</i>";
            StartTag = start;
            EndTag = end;
        }
    }
}
