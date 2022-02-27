namespace Design_Patterns_Assignment
{
    public class Important : TextDecorator, IImportant
    {
        public Important(IText text) : base(text)
        {
            string start = "<strong>";
            string end = "</strong>";
            StartTag = start;
            EndTag = end;
        }
    }
}
